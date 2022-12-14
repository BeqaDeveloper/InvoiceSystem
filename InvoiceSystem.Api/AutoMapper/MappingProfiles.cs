using AutoMapper;
using InvoiceSystem.Application.ViewModels;
using InvoiceSystem.Domain.Models;

namespace InvoiceSystem.Api.AutoMapper;
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Invoice, InvoiceViewModel>().ReverseMap();
            CreateMap<Customer, CustomerViewModel>().ReverseMap();
        }
    }
