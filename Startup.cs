using Attendance_Management_System.Repository;
using Attendance_Management_System.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Attendance_Management_System.Repository;
using Attendance_Management_System.Services;
using Attendance_Management_System.Models;



namespace Attendance_Management_System
{
    public class Startup
    {
      //  public const string SECRET = "THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE  IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.AddEntityFrameworkSqlServer();
            services.AddControllers();
            services.AddDbContext<AttendanceManagementContext>(options =>
            options.UseSqlServer(Configuration.GetSection("SqlConnection:ConnectionString").Value));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeServices, EmployeeServices>();
            services.AddScoped<IManagerRepository, ManagerRepository>();
            services.AddScoped<IManagerServices, ManagerServices>();
            services.AddScoped<ILeaveRepository, LeaveRepository>();
            services.AddScoped<ILeaveServices, LeaveServices>();
            services.AddScoped<IAttendanceRepository, AttendanceRepository>();
            services.AddScoped<IAttendenceServices, AttendenceServices>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Attendance_Management_System", Version = "v1" });
            });

            
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Attendance_Management_System v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseHttpsRedirection();
            app.UseAuthentication();
        }
    }
}
