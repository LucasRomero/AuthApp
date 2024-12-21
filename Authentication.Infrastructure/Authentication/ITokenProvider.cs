using Authentication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Authentication
{
    public interface ITokenProvider
    {
        string GetToken(User user);
    }
}
