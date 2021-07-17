using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Modul_202107.Controllers
{
    public abstract class Modul_202107ControllerBase: AbpController
    {
        protected Modul_202107ControllerBase()
        {
            LocalizationSourceName = Modul_202107Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
