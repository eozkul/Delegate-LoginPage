using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Dtos;
using BilgeAdam.Common.Library.Extensions;
using System.Data.SqlClient;
using BilgeAdam.Common.Library.Constants;

namespace BilgeAdam.Data.Concretes
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly DatabaseManager databaseManager;

        public AuthenticationService()
        {
            databaseManager = new DatabaseManager();
        }

        public bool AddNewUser(NewUserDto dto)
        {
            var hashPassword = dto.Password + ConstantStrings.PasswordKey;
            var query = @$"INSERT INTO Users VALUES (
                                            '{dto.FirstName}',
                                            '{dto.LastName}',
                                            '{dto.Email}',
                                            '{hashPassword.ComputeHash()}',
                                             GETDATE(),
                                            'Admin',
                                             {dto.SecurityQuestionId},
                                            '{dto.Answer}')";
            return databaseManager.Execute(query);
        }

        public bool CheckUser(CheckUserDto dto)
        {
            var hashPassword = dto.Password + ConstantStrings.PasswordKey;
            var query = $"SELECT Id FROM Users WHERE Email = '{dto.Email}' AND Password = '{hashPassword.ComputeHash()}'";
            return databaseManager.Any(query);
        }

        public List<SecurityQuestionOptionDto> GetSercurityQuestions()
        {
            return databaseManager.GetAll("SecurityQuestions", SecurityQuestionMapper);
        }

        private List<SecurityQuestionOptionDto> SecurityQuestionMapper(SqlDataReader reader)
        {
            var result = new List<SecurityQuestionOptionDto>();
            while (reader.Read())
            {
                result.Add(new SecurityQuestionOptionDto
                {
                    Id = reader.GetInt32(0),
                    Question = reader.GetString(1),
                });
            }
            return result;
        }
    }
}