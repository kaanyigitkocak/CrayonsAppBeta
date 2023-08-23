using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.HangfireJobs.RecurringJobs;
public class RecurringJobs
{
    public static void MailSend(int userId, string message)
    {
        Hangfire.RecurringJob.AddOrUpdate<MainJobs.MainJobs>(recurringJobId:"MailSendJob0",
            x => x.MailSend(userId, message), 
            Cron.Minutely());
        
    }
}
