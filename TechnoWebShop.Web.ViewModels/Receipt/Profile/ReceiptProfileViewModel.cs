﻿using AutoMapper;
using System;
using System.Linq;
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Web.ViewModels.Receipt.Profile
{
    public class ReceiptProfileViewModel : IMapFrom<ReceiptServiceModel>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public DateTime IssuedOn { get; set; }

        public decimal Total { get; set; }

        public int Products { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
                .CreateMap<ReceiptServiceModel, ReceiptProfileViewModel>()
                .ForMember(destination => destination.Total,
                            opts => opts.MapFrom(origin => origin.Orders.Sum(order => order.Product.Price * order.Quantity)))
                .ForMember(destination => destination.Products,
                            opts => opts.MapFrom(origin => origin.Orders.Sum(order => order.Quantity)));
        }
    }
}
