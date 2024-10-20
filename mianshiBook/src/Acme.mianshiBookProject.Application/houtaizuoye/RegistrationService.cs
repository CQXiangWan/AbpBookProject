using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.BackgroundJobs;

namespace Acme.mianshiBookProject.houtaizuoye
{
    public class RegistrationService : ApplicationService
    {
        private readonly IBackgroundJobManager _backgroundJobManager;  
        //注入 IBackgroundJobManager 服务了并且使用它的 EnqueueAsync 方法添加一个新的作业到队列中

        public RegistrationService(IBackgroundJobManager backgroundJobManager)
        {
            _backgroundJobManager = backgroundJobManager;
        }

        public async Task RegisterAsync(string userName, string emailAddress, string password)
        {
            //TODO: 创建一个新用户到数据库中...

            await _backgroundJobManager.EnqueueAsync(
                new EmailSendingArgs
                {
                    EmailAddress = emailAddress,
                    Subject = "You've successfully registered!",
                    Body = "..."
                }
            );
        }
    }

}
