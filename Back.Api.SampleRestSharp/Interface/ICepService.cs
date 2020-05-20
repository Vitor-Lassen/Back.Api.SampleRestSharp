using Back.Api.SampleRestSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Api.SampleRestSharp.Interface
{
    public interface ICepService
    {
        Address GetAddressByCep(string cep);
    }
}
