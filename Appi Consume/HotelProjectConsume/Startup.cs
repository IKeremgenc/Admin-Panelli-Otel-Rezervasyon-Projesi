using HotelProject.DataAccsesLayer.Abstract;
using HotelProject.DataAccsesLayer.Concrete;
using HotelProject.DataAccsesLayer.EntityFreamwork;
using HotelsProject.BussinesLayer.Abstract;
using HotelsProject.BussinesLayer.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectConsume
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
            services.AddDbContext<Context>();
            services.AddScoped<IStaffDal, EFStaffDal>();
            services.AddScoped<IStaffService, StaffManager>();

            services.AddScoped<IRoomDal, EFRoomDal>();
            services.AddScoped<IRoomService, RoomManager>();

            services.AddScoped<IServicesDal, EFServicesDal>();
            services.AddScoped<IServiceServices, ServiceManager_>();

            services.AddScoped<ISubscribesDal, EFSubscribeDal>();
            services.AddScoped<ISubscribeService, SubscribeManager>();

            services.AddScoped<ITestimonailDal, EFTestimonialDal>();
            services.AddScoped<ITestimonailService, TestimonialManager>();

            services.AddScoped<IStaffDal, EFStaffDal>();
            services.AddScoped<IStaffService, StaffManager>();

            services.AddScoped<IAboutDal, EFAboutDal>();
            services.AddScoped<IAboutService, AboutManger>();

            services.AddScoped<IBookingDal, EFBookingDal>();
            services.AddScoped<IBookingService, BookingManagewr>();

            services.AddScoped<IContectDal, EFContectDal>();
            services.AddScoped<IContectService, ContectManager>();

            services.AddScoped<IGuestDalcs, EFGuestDal>();
            services.AddScoped<IGuestServie, GuestManager>();

            services.AddScoped<ISendMessageDal, EFSendMessageDal>();
            services.AddScoped<ISenderMessageService, SendMeesagger>();


            services.AddScoped<ImmessageCategoryDal, EFCategoryMessageDal>();
            services.AddScoped<ICategorMessageService, CategorMessageManager>();

            services.AddScoped<IWorkLocationDal, EFWorkLocationsDal>();
            services.AddScoped<IWorkLocationService, WorkLocationManager>();

            services.AddScoped<IAppUserDal, EFUserdal>();
            services.AddScoped<IAppuserService, AppuserManger>();

            services.AddAutoMapper(typeof(Startup));
            //services.AddScoped<>

            services.AddCors(opt =>
            {
                opt.AddPolicy("Otelapicors", opt =>
                {
                    opt.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling =
            Newtonsoft.Json.ReferenceLoopHandling.Ignore);


            services.AddSwaggerGen(c =>
 {
     c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotelProjectConsume", Version = "v1" });
 });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HotelProjectConsume v1"));
            }

            app.UseRouting();
            app.UseCors("Otelapicors");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
