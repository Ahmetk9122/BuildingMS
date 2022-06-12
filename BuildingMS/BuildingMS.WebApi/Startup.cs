using BuildingMS.Bll;
using BuildingMS.Dal.Abstract;
using BuildingMS.Dal.Concrete.EntityFramework.Context;
using BuildingMS.Dal.Concrete.EntityFramework.Repository;
using BuildingMS.Dal.Concrete.EntityFramework.UnitOfWork;
using BuildingMS.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.WebApi
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
            
            #region JwtTokenService
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(cfg =>
            {
                cfg.SaveToken = true;
                cfg.RequireHttpsMetadata = false;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = Configuration["Tokens:Issuer"],
                    ValidAudience = Configuration["Tokens:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Tokens:Key"])),
                    RequireSignedTokens = true,
                    RequireExpirationTime = true //ExpirationTime kontrol etmesi zorunlu mu ? 
                };
            });

            #endregion
            
            #region ApplicationContext
            services.AddDbContext<BuildingManagementSystemDbContext>();

            /*  services.AddDbContext<BMSDatabaseContext>
                  (
                      ob => ob.UseSqlServer(Configuration.GetConnectionString("SqlServer"))
                  );
            */
            services.AddScoped<DbContext, BuildingManagementSystemDbContext>();
            #endregion

            #region ServiceSection
            services.AddScoped<IApartmentService, ApartmentManager>();
            services.AddScoped<IInvoiceService, InvoiceManager>();
            services.AddScoped<IManagerService, ManagerManager>();
            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserLoginService, UserLoginManager>();
            services.AddScoped<IManagerLoginService, ManagerLoginManager>();

            #endregion

            #region RepositorySection
            services.AddScoped<IApartmentRepository, ApartmentRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IManagerRepository, ManagerRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IManagerLoginRepository, ManagerLoginRepository>();
            services.AddScoped<IUserLoginRepository, UserLoginRepository>();

            #endregion

            #region UnitOfWork

            services.AddScoped<IUnitofWork, UnitofWork>();

            #endregion


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BMS.WebApi", Version = "v1" });
                //Authorization giriþ bloðu.
                #region TokenEntryBlock
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    //Token alma özellikleri
                    In = ParameterLocation.Header,
                    Description = "Please insert token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement{
                  {
                    new OpenApiSecurityScheme {
                        Reference = new OpenApiReference
                        {
                            Type=ReferenceType.SecurityScheme,
                            Id="Bearer"
                        }
                    },
                    new string [] { }
                  }
                });
                #endregion
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BMS.WebApi v1"));
            }
            //Authorization ekleme bloðu.
            #region Authorization
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BMS.WebApi v1");
            });
            #endregion

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }
}
