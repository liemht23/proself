using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Proself;

[Dependency(ReplaceServices = true)]
public class ProselfBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Proself";
}
