using EntityModels.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestWebApp.Helpers.Validators
{
        public class PasswordValidator : IPasswordValidator<UserEntity>
        {
            public Task<IdentityResult> ValidateAsync(UserManager<UserEntity> manager, UserEntity user, string password)
            {
                return Task.Run(() =>
                {
                    if (password.Length >= 4) return IdentityResult.Success;
                    else { return IdentityResult.Failed(new IdentityError { Code = "SHORTPASSWORD", Description = "Password too short" }); }
                });
            }
        }
}
