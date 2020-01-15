using Volo.Abp.Settings;

namespace Mju.Datacenter.Settings
{
    public class DatacenterSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DatacenterSettings.MySetting1));
        }
    }
}
