using OwnedEntities.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OwnedEntities.Permissions
{
    public class OwnedEntitiesPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(OwnedEntitiesPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(OwnedEntitiesPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OwnedEntitiesResource>(name);
        }
    }
}
