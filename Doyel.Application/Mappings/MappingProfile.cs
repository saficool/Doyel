using AutoMapper;
using Doyel.Application.DTOs;
using Doyel.Domain.Entities;

namespace Doyel.Application.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<UserRegisterDto, ApplicationUser>();
		}
	}
}
