using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


namespace TodoApi
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
            //使用内存数据库
            // services.AddDbContext<TodoContext>(opt =>
            //     opt.UseInMemoryDatabase("TodoList"));

            //使用MySql数据库，配置连接字符串和Mysql的版本
            //这里创建了一个单例单TodoContext对象，用于实现依赖注入
            services.AddDbContextPool<TodoContext>(
                 options => options.UseMySql("Server=localhost;Database=todoDb;User=root;Password=root;", // replace with your Connection String
                     mySqlOptions =>
                     {
                         mySqlOptions.ServerVersion(new Version(8, 0, 12), ServerType.MySql); // replace with your Server Version and Type
                    }
             ));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()){
                app.UseDeveloperExceptionPage();
            }else {
                app.UseHsts();
            }
            //自动创建库
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<TodoContext>();
                context.Database.EnsureCreated();
            }

            //使用html页面和其他静态资源
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
