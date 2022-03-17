using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace ProvaSuficiencia.Extensions
{
    public interface IAspNetUser
    {
        string Name { get; }
        Guid GetUserId();
        string GetUserEmail();
        bool IsAuthenticated();
        bool IsInRole(string role);
        IEnumerable<Claim> GetClaimsIdentity();
    }
}