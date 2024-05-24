using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TempProject.Service.Controling.Application.Services.Interface;
using TempProject.Service.Controling.Application.Services.Service;
using TempProject.Service.Controling.Core.Repository.Interface;
using TempProject.Service.Controling.Core.Repository.Repository;
using TempProject.Service.Controling.Infrastructure.DataBase.Server;

namespace Temp.Service.Controling.APi
{
    public class Startup
    {

        public IConfiguration _configuration { get; }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Obsolete]
        public void ConfigureService(IServiceCollection service)
        {
            #region Config_Start
            service.AddControllers();
            service.AddEndpointsApiExplorer();
            service.AddDbContext<TestProjectContext>(options => options.UseMySql(connectionString: _configuration.GetConnectionString("AppData"), ServerVersion.Parse("8.0.30-mysql")));
            #endregion


            #region Repositories
            service.AddScoped<IRepositoryTest, RepositoryTest>();

            #endregion



            #region Service
            service.AddScoped<ITestService, TestService>();
            #endregion

            #region Identity
            service.AddSwaggerGen();

            service.AddMediatR(Assembly.GetExecutingAssembly());

            var assembly = Assembly.GetExecutingAssembly();
            service.AddMediatR(assembly);
        #endregion
        }
    }
}
