namespace OnlineTickets.Server.Repositories.EmailRepositories;

public interface IEmailRepository
{
    void Send(string to, string subject, string body);
}
