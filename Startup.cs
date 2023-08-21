using EFDotNetCorePractice.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace EFDotNetCorePractice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add DbContext to the injection container
            services.AddDbContext<EFDotNetCorePracticeContext>(options =>
                    options.UseSqlServer(
                        this.Configuration.GetConnectionString("EFDotNetCorePracticeContext")));
        }
        public void Configure(IApplicationBuilder app, EFDotNetCorePracticeContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
