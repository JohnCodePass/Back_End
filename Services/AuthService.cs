using System.Collections.Generic;
using Back_End.Models;
using System.Linq;
using Google.Apis.Sheets;
using Back_End.Context;

namespace Back_End.Services
{
    public class AuthService
    {
        private readonly Data _dataFromService;

        public AuthService(Data dataFromService)
        {
            _dataFromService = dataFromService;
        }

        
        public bool addUser(UserInfo info)
        {
            _dataFromService.Add(info);
            _dataFromService.SaveChanges();
            return true;
        }

        public IEnumerable<UserInfo> getAllUsers()
        {
            return _dataFromService.Users;
        }
    }
}