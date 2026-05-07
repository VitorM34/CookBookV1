using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.Services.AutoMapper;

public class AutoMapping : Profile

{
    public AutoMapping()
    {
        RequestToDomain();
    }

    private void RequestToDomain()
    {
        CreateMap<RequestRegisterUserJson, Domain.Entities.User>();
            .ForMember(dest => dest.Password, opt => opt.Ignore);
    }
}