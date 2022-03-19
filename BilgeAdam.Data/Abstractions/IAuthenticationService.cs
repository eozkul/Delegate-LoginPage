using BilgeAdam.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.Abstractions
{
    public interface IAuthenticationService
    {
        bool CheckUser(CheckUserDto dto);
        List<SecurityQuestionOptionDto> GetSercurityQuestions();
        bool AddNewUser(NewUserDto dto);
    }
}
