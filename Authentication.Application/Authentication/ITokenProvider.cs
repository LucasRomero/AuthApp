using Authentication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Application.Authentication
{
    public interface ITokenProvider
    {
        string GetToken(User user);
    }
}
