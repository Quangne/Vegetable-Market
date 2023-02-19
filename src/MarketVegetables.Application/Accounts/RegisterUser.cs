using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.Identity;

namespace MarketVegetables.Accounts
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(IIdentityUserAppService), typeof(IdentityUserAppService), typeof(RegisterUser))]
    public class RegisterUser : IdentityUserAppService
    {
        public RegisterUser(
        IdentityUserManager userManager,
        IIdentityUserRepository userRepository,
        IIdentityRoleRepository guidGenerator,
        IOptions<IdentityOptions> identityOptions) : base(
        userManager,
        userRepository,
        guidGenerator,
        identityOptions)
        {

        }
        public async override Task<IdentityUserDto> CreateAsync(IdentityUserCreateDto input)
        {
            return await base.CreateAsync(input);
        }
    }
}
