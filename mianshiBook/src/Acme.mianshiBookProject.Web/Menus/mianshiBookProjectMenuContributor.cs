using System.Threading.Tasks;
using Acme.mianshiBookProject.Localization;
using Acme.mianshiBookProject.MultiTenancy;
using Acme.mianshiBookProject.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Acme.mianshiBookProject.Web.Menus
{
    public class mianshiBookProjectMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<mianshiBookProjectResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("mianshiBookProject.Home", l["Menu:Home"], "~/"));

            var bookStoreMenu = new ApplicationMenuItem(
                "mianshiBookProject",
                l["Menu:mianshiBookProject"],
                icon: "fa fa-book"
            );

            context.Menu.AddItem(bookStoreMenu);

            //CHECK the PERMISSION
            if (await context.IsGrantedAsync(mianshiBookProjectPermissions.Books.Default))
            {
                bookStoreMenu.AddItem(new ApplicationMenuItem(
                    "mianshiBookProject.Books",
                    l["Menu:Books"],
                    url: "/Books"
                ));
            }
            if (await context.IsGrantedAsync(mianshiBookProjectPermissions.Authors.Default))
            {
                bookStoreMenu.AddItem(new ApplicationMenuItem(
                    "BooksStore.Authors",
                    l["Menu:Authors"],
                    url: "/Authors"
                ));
            }
        }
    }
}