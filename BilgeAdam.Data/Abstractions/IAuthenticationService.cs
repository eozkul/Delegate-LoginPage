using BilgeAdam.Data.Dtos;

namespace BilgeAdam.Data.Abstractions
{
    public interface IAuthenticationService
    {
        bool CheckUser(CheckUserDto dto);

        List<SecurityQuestionOptionDto> GetSercurityQuestions();

        bool AddNewUser(NewUserDto dto);

        bool AddNewUserWithSqlParameter(NewUserDto dto);

        UserQuestionDto GetUserByEmail(string email);

        bool UpdateUserPassword(UpdateUserPasswordDto dto);
    }
}