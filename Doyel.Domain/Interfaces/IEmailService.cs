namespace Doyel.Domain.Interfaces;
 
public interface IEmailService
{
	Task SendEmailAsync(List<string> tos, List<string> ccs, List<string> bccs, string subject, string body, bool isHtml = false);
}
