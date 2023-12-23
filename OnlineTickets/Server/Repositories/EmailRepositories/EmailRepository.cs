using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;


namespace OnlineTickets.Server.Repositories.EmailRepositories;

public class EmailRepository:IEmailRepository
{
    private readonly IConfiguration _configuration;

    public EmailRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Send(string to, string subject, string body)
    {
        var SmtpHost = _configuration["SmtpHost"];
        var SmtpPort = _configuration["SmtpPort"];
        var SmtpUserName = _configuration["SmtpUserName"];
        var SmtpUserEmail = _configuration["SmtpUserEmail"];
        var SmtpPass = _configuration["SmtpPass"];

        var email = new MimeMessage();

        email.From.Add(new MailboxAddress(SmtpUserName, SmtpUserEmail));
        email.To.Add(new MailboxAddress(to, to));
        email.Subject = subject;
        email.Body = new TextPart(TextFormat.Html) { Text = body };

        using var smtp = new SmtpClient();
        smtp.Connect(SmtpHost, Int32.Parse(SmtpPort), SecureSocketOptions.Auto);
        smtp.Authenticate(SmtpUserEmail, SmtpPass);
        smtp.Send(email);
        smtp.Disconnect(true);

    }
}

