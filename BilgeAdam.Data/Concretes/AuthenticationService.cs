using BilgeAdam.Common.Library.Constants;
using BilgeAdam.Common.Library.Extensions;
using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Dtos;
using System.Data.SqlClient;

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

        public bool AddNewUserWithSqlParameter(NewUserDto dto)
        {
            var hashPassword = dto.Password + ConstantStrings.PasswordKey;
            var query = "INSERT INTO Users VALUES ( @FirstName, @LastName, @Email, @Password, @CreatedAt, @CreatedBy, @SecurityQuestionId, @Answer)";
            return databaseManager.ExecuteWithParameter(query, new SqlParameter[] {
                new SqlParameter("@FirstName", dto.FirstName),
                new SqlParameter("@LastName", dto.LastName),
                new SqlParameter("@Email", dto.Email),
                new SqlParameter("@Password", hashPassword.ComputeHash()),
                new SqlParameter("@CreatedAt", DateTime.Now),
                new SqlParameter("@CreatedBy", "Admin"),
                new SqlParameter("@SecurityQuestionId", dto.SecurityQuestionId),
                new SqlParameter("@Answer", dto.Answer),
            });
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

        public UserQuestionDto GetUserByEmail(string email)
        {
            var query = @$"SELECT u.Id, q.Question, u.Answer FROM Users u
                                INNER JOIN SecurityQuestions q ON q.Id = u.SecurityQuestionId
                                WHERE u.Email = '{email}'";


            return databaseManager.GetByQuery<UserQuestionDto>(query, UserQuestionMapper);



            //return databaseManager.GetByQuery<UserQuestionDto>(query, reader => new UserQuestionDto
            //{
            //    Id = reader.GetInt32(0),
            //    Question = reader.GetString(1),
            //    Answer = reader.GetString(2)
            //});
        }

        public bool UpdateUserPassword(UpdateUserPasswordDto dto)
        {
            var hashPassword = dto.Password + ConstantStrings.PasswordKey;
            var query = $"UPDATE Users SET Password = '{hashPassword.ComputeHash()}' WHERE Id = {dto.UserId}";
            return databaseManager.Update(query);
        }


        private UserQuestionDto UserQuestionMapper(SqlDataReader reader)
        {
            while (reader.Read())
            {
                return new UserQuestionDto
                {
                    Id = reader.GetInt32(0),
                    Question = reader.GetString(1),
                    Answer = reader.GetString(2)
                };
            }
            return null;
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