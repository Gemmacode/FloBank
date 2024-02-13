using AutoMapper;
using FloBank.Model.Model;

namespace FloBank.Api.Profiles
{
    public class AutomapperProfile : Profile
    {
        protected AutomapperProfile()
        {
            CreateMap<RegisterNewAccountModel, Account>();
            CreateMap<UpdateAcountModel, Account>();
            CreateMap<Account, GetAccountModel>();
        }
    }

        
}
