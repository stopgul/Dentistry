using Dentistry.EntityFramework;
using Dentistry.Web.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net.Http;

namespace Dentistry.Test.Shared
{
    public  class TestBase
    {
        protected readonly DentistryDbContext DentistryInMemoryContext;

        public TestBase()
        {
            DentistryInMemoryContext = GetInitializedDbContext();
        }

        public static DentistryDbContext GetInitializedDbContext()
        {
            var inMemoryContext = GetEmptyDbContext();

            //inMemoryContext.AddRange(PermissionConsts.AllPermissions());
            //inMemoryContext.AddRange(RoleConsts.AdminRole, RoleConsts.ApiUserRole);
            //inMemoryContext.AddRange(AllTestUsers);
            //inMemoryContext.AddRange(AdminUserRole, TestUserRole);
            //inMemoryContext.AddRange(AdminRolePermission, ApiUserRolePermission);

            inMemoryContext.SaveChanges();
            return inMemoryContext;
        }

        public static DentistryDbContext GetEmptyDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DentistryDbContext>();
            optionsBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            //optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.EnableSensitiveDataLogging();
            var inMemoryContext = new DentistryDbContext(optionsBuilder.Options);
            return inMemoryContext;
        }

        private static HttpClient GetTestServer()
        {
            var server = new TestServer(
                new WebHostBuilder()
                    .UseStartup<Startup>()
                    .ConfigureAppConfiguration(config =>
                    {
                        config.SetBasePath(Path.Combine(Path.GetFullPath(@"../../../.."), "Dentistry.Tests.Shared"));
                        config.AddJsonFile("appsettings.json", false);
                    })
            );
            return server.CreateClient();
        }

        private static HttpClient GetTestServer1()
        {
            var server = new TestServer(
                new WebHostBuilder()
                    .UseStartup<Startup>()
                    .ConfigureAppConfiguration(config =>
                    {
                        config.SetBasePath(Path.Combine(Path.GetFullPath(@"../../../.."), "Kodkod.Tests.Shared"));
                        config.AddJsonFile("appsettings.json", false);
                    })
            );
            return server.CreateClient();
        }
    }
}
