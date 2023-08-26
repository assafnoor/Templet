using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Templet.Core.Models;

namespace Templet.Core.Interfaces
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
        Task<string> DeleteRoleAsync(AddRoleModel model);
    }
}
