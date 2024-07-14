using System;
using System.Collections.Generic;
using System.Text;
using Proself.Localization;
using Volo.Abp.Application.Services;

namespace Proself;

/* Inherit your application services from this class.
 */
public abstract class ProselfAppService : ApplicationService
{
    protected ProselfAppService()
    {
        LocalizationResource = typeof(ProselfResource);
    }
}
