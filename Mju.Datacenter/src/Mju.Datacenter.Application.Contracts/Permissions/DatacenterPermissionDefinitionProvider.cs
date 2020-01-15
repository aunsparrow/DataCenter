using Mju.Datacenter.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Mju.Datacenter.Permissions
{
    public class DatacenterPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DatacenterPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(DatacenterPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DatacenterResource>(name);
        }
    }
}
