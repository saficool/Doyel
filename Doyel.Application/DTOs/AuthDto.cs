namespace Doyel.Application.DTOs
{
	public record UserRegisterDto(string FirstName, string LastName, string Email, string Password);
	public record UserLoginDto(string Email, string Password);
}
