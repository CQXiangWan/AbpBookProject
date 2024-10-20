using Acme.mianshiBookProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.mianshiBookProject.Permissions;

public class mianshiBookProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(mianshiBookProjectPermissions.GroupName, L("Permission:mianshiBookProject"));

        var booksPermission = bookStoreGroup.AddPermission(mianshiBookProjectPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(mianshiBookProjectPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(mianshiBookProjectPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(mianshiBookProjectPermissions.Books.Delete, L("Permission:Books.Delete"));  //权限组 4个权限

        var authorsPermission = bookStoreGroup.AddPermission(
    mianshiBookProjectPermissions.Authors.Default, L("Permission:Authors"));

        authorsPermission.AddChild(
            mianshiBookProjectPermissions.Authors.Create, L("Permission:Authors.Create"));

        authorsPermission.AddChild(
            mianshiBookProjectPermissions.Authors.Edit, L("Permission:Authors.Edit"));

        authorsPermission.AddChild(
            mianshiBookProjectPermissions.Authors.Delete, L("Permission:Authors.Delete"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<mianshiBookProjectResource>(name);
    }
}
