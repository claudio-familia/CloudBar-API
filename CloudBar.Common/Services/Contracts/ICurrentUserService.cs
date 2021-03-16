using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.Common.Services.Contracts
{
    public interface ICurrentUserService
    {
        int? UserId { get; }
        bool IsAuthenticated { get; }
    }
}
