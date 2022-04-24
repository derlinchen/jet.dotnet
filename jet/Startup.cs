using jet.Config;
using jet.Filters;
using jet.Repository;
using jet.Repository.interfaces;
using jet.Service;
using jet.Service.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace jet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();
            services.AddSwaggerGen();

            services.AddDbContext<EFCoreContext>(options => options.UseMySql(Configuration.GetConnectionString("MysqlConnection"), MySqlServerVersion.LatestSupportedServerVersion));

            services.AddControllers(ops =>
            {
                //添加过滤器
                ops.Filters.Add(new ResultFilter());
                ops.Filters.Add(new ServiceFilterAttribute(typeof(ExceptionFilter)));
            });

            //添加repository注入
            services.AddTransient<IBaseDicRepository, BaseDicRepository>();
            //添加service注入
            services.AddTransient<IBaseDicService, BaseDicService>();

            services.AddScoped<ExceptionFilter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
