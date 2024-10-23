using AutoMapper;
using NetByForms.Application.Models.Dto;
using NetByForms.Application.Models.Request.Command;
using NetByForms.Domain.Entities;

namespace NetByForms.Application.MapConfig
{
    public class FormProfile : Profile
    {
        public FormProfile()
        {
            CreateMap<Form, FormDto>().ReverseMap();
            CreateMap<FormInput, FormInputDto>().ReverseMap();
            CreateMap<FormInputOption, FormInputOptionDto>().ReverseMap();

            CreateMap<CreateFormCommand, Form>()
                .ForMember(dest => dest.Inputs, opt => opt.MapFrom(src => src.Inputs));
        }
    }

}
