using System.Collections.Generic;
using Back_End.Models;
using System.Linq;
using Google.Apis.Sheets;
using Back_End.Context;

namespace Back_End.Services
{
    public class FaresService
    {
        private readonly Data _dataFromService;
        public FaresService(Data dataFromService)
        {
            _dataFromService = dataFromService;
        }
        
    }
}