using AutoMapper;
using System;
using System.Collections.Generic;
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Web.ViewModels.Receipt.Details
{
    public class ReceiptDetailsViewModel : IMapFrom<ReceiptServiceModel>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string Recipient { get; set; }

        public DateTime IssuedOn { get; set; }

        public List<ReceiptDetailsOrderViewModel> Orders { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
                .CreateMap<ReceiptServiceModel, ReceiptDetailsViewModel>()
                .ForMember(destination => destination.Recipient,
                            opts => opts.MapFrom(origin => origin.Recipient.UserName));
        }
    }
}
