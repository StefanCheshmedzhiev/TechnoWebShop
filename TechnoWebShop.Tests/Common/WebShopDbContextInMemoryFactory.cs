using Microsoft.EntityFrameworkCore;
using System;
using TechnoWebShop.Data;

namespace TechnoWebShop.Tests.Common
{
    public static class WebShopDbContextInMemoryFactory
    {
        public static TechnoWebShopDbContext InitializeContext()
        {
            var options = new DbContextOptionsBuilder<TechnoWebShopDbContext>()
               .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
               .Options;

            return new TechnoWebShopDbContext(options);
        }
    }
}
