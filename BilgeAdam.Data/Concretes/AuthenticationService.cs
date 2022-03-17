using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.Concretes
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly DatabaseManager databaseManager;
        public AuthenticationService()
        {
            databaseManager = new DatabaseManager();
        }
        public bool CheckUser(CheckUserDto dto)
        {
            var query = $"SELECT Id FROM Users WHERE Email = '{dto.Email}' AND Password = '{dto.Password}'";
            return databaseManager.Any(query);
        }
    }
}
