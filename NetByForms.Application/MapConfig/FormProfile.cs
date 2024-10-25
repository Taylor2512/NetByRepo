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
            // Mapeo de CreateFormCommand a Form
            CreateMap<CreateFormCommand, Form>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
            // Mapeo de ForInputRequest a FormInput
            CreateMap<ForInputRequest, FormInput>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Options));

            // Mapeo de FormInputOptionRequest a FormInputOption
            CreateMap<FormInputOptionRequest, FormInputOption>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));

            // Mapeo de Form a FormDto
            CreateMap<Form, FormDto>()
                .ForMember(dest => dest.Inputs, opt => opt.MapFrom(src => src.Inputs));

            // Mapeo de FormInput a FormInputDto
            CreateMap<FormInput, FormInputDto>()
                .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Options));

            // Mapeo de FormInputOption a FormInputOptionDto
            CreateMap<FormInputOption, FormInputOptionDto>();

            // Mapeo inverso de los DTOs a las entidades del dominio
            CreateMap<FormDto, Form>();
            CreateMap<FormInputDto, FormInput>();
            CreateMap<FormInputOptionDto, FormInputOption>();

            // Mapeo de comandos individuales a DTOs y entidades
            CreateMap<CreateFormInputCommand, FormInput>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.FormId, opt => opt.MapFrom(src => src.FormId));

            CreateMap<CreateFormInputOptionCommand, FormInputOption>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.FormInputId, opt => opt.MapFrom(src => src.FormInputId));
        }
    }
}