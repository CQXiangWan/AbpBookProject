using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.SignalR;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace Acme.mianshiBookProject.SignalRDemo
{
    [Authorize]
    [HubRoute("/chatHubnew")]
    public class ChatHub : AbpHub
    {

        private readonly IIdentityUserRepository _identityUserRepository;
        private readonly ILookupNormalizer _lookupNormalizer;
        private readonly ICurrentUser _currentUser; // 注入 ICurrentUser

        public ChatHub(IIdentityUserRepository identityUserRepository, ILookupNormalizer lookupNormalizer, ICurrentUser currentUser)
        {
            _identityUserRepository = identityUserRepository;
            _lookupNormalizer = lookupNormalizer;
            _currentUser = currentUser; // 赋值
        }

        public async Task SendMessage(string targetUserName, string message)
        {
            //var currentUserName = CurrentUser.UserName; //Access to the current user info
            //var txt = L["MyText"]; //Localization
            var username = _currentUser.UserName; // 使用注入的 ICurrentUser
            var targetUser = await _identityUserRepository.FindByNormalizedUserNameAsync(_lookupNormalizer.NormalizeName(targetUserName));
            message = $"{username}: {message}"; // 使用 username
            await Clients
                .User(targetUser.Id.ToString())
                .SendAsync("ReceiveMessage", message);
            //// 广播模式的
            //await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}