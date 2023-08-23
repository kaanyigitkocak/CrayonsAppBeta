using System;
using Hangfire;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.HangfireJobs.FireAndForgetJobs;
public class FireAndForgetJobs
{

    public static void MailSend(int userId, string message)
    {
        Hangfire.BackgroundJob.Enqueue<MainJobs.MainJobs>(x => x.MailSend(userId,message));
    }
}
