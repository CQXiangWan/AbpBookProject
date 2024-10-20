using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Emailing;

namespace Acme.mianshiBookProject.houtaizuoye
{
    public class EmailSendingJob : BackgroundJob<EmailSendingArgs>, ITransientDependency
    {
        private readonly IEmailSender _emailSender;

        public EmailSendingJob(IEmailSender emailSender)  //使用 EmailSendingArgs 对象发送电子邮件:
        {
            _emailSender = emailSender;
        }

        public override void Execute(EmailSendingArgs args)
        {
            _emailSender.SendAsync(
                args.EmailAddress,
                args.Subject,
                args.Body
            );
        }
    }
}
