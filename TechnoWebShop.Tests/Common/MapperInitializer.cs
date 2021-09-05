using System.Reflection;
using TechnoWebShop.Data.Models;
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;

namespace TechnoWebShop.Tests.Common
{
    public static class MapperInitializer
    {
        public static void InitializeMapper()
        {
            AutoMapperConfig.RegisterMappings(
                typeof(ProductServiceModel).GetTypeInfo().Assembly,
                typeof(Product).GetTypeInfo().Assembly);
        }
    }
}
