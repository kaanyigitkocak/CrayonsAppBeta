using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.HangfireJobs.DelayedJobs;
public class DelayedJobs
{
    public static string MailSend(int userId, string message, int second)
    {
        string JobId = Hangfire.BackgroundJob.Schedule<MainJobs.MainJobs>(x => x.MailSend(userId,message),TimeSpan.FromSeconds(second));
        return JobId;
    }
}
