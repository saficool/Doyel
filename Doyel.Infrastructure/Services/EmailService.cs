using Doyel.Domain.Interfaces;

namespace Doyel.Infrastructure.Services
{
	public class EmailService : IEmailService
	{
		public Task SendEmailAsync(List<string> tos, List<string> ccs, List<string> bccs, string subject, string body, bool isHtml = false)
		{
			throw new NotImplementedException();
		}
	}
}
