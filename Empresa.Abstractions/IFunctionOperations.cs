using Empresa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Abstractions
{
    public interface IFunctionOperations
    {
        Task<List<UserDTO>> GetDataUsers();
    }
}
