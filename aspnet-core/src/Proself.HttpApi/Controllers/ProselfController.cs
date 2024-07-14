using Proself.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Proself.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProselfController : AbpControllerBase
{
    protected ProselfController()
    {
        LocalizationResource = typeof(ProselfResource);
    }
}
