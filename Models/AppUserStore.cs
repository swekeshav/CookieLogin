﻿using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CookieLogin.Models
{
    public class AppUserStore : IUserStore<ApplicationUser>
    {
        public Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
        }

        public Task<ApplicationUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ApplicationUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return new ApplicationUser { UserName = "Keshav" };
        }

        public Task<string> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(ApplicationUser user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetUserNameAsync(ApplicationUser user, string userName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}