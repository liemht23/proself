using Volo.Abp.Settings;

namespace Proself.Settings;

public class ProselfSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProselfSettings.MySetting1));
    }
}
