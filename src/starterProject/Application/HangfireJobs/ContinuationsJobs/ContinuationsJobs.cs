using Application.HangfireJobs.MainJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.HangfireJobs.ContinuationsJobs;
public class ContinuationsJobs
{
    public static void MailSend(string jobId,int userId, string message)
    {
        Hangfire.BackgroundJob.ContinueJobWith<MainJobs.MainJobs>(jobId, x => x.MailSend(userId, message));
    }
}
