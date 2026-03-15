using myapp_domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp_domain.Interfaces
{
    public interface IExternalVendorRepository
    {
        public interface IExternalVendorRepository
        {
            Task<CoindeskData> GetData();
            Task<JokeModel> GetJoke();
        }
    }
}

