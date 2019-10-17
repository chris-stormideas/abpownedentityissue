using Volo.Abp.Settings;

namespace OwnedEntities.Settings
{
    public class OwnedEntitiesSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(OwnedEntitiesSettings.MySetting1));
        }
    }
}
