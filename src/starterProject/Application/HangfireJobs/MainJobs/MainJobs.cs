using Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.HangfireJobs.MainJobs;
public  class MainJobs
{
    public Task MailSend(int userId,string message)
    {
        Console.WriteLine($"{userId} mail yollandi.{message}");
        return Task.CompletedTask;
    }
}
