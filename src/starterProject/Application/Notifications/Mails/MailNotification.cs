using Application.Features.Auth.Constants;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using System.Diagnostics;

namespace Application.Notifications.Mails;


public class MailNotification : INotification
{
    public MailNotification(string title, string message) 
    {
        Title = title;
        Message = message;
    }
    public MailNotification()
    {
    }
    public string Title { get; set; }
    public string Message { get; set; }
}

public class MailNotificationHandler : INotificationHandler<MailNotification>
{
    public Task Handle(MailNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"{notification.Title} calisiyor. {notification.Message} ");
        return Task.CompletedTask;
    }
}