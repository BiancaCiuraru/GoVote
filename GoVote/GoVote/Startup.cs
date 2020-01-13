using GoVote.Authentication;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System.Reflection;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace GoVote
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.ConfigureJwtAuthentication(Configuration);

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder(JwtBearerDefaults.AuthenticationScheme).RequireAuthenticatedUser().Build();
            });

            services.AddControllers();
            services.AddDbContext<Data.CitizenDatabaseContext>(options =>
               options.UseSqlServer(@"Server=.\SQLEXPRESS; Database=CitizenDatabaseContext;Trusted_Connection=True;")
           );

           services.AddDbContext<Data.PartyDatabaseContext>(options =>
               options.UseSqlServer(@"Server=.\SQLEXPRESS; Database=PartyDatabaseContext;Trusted_Connection=True;")
           );

            services.AddDbContext<Data.CandidateDatabaseContext>(options =>
               options.UseSqlServer(@"Server=.\SQLEXPRESS; Database=CandidateDatabaseContext;Trusted_Connection=True;")
           );

            services.AddDbContext<Data.VotingTypeDatabaseContext>(options =>
               options.UseSqlServer(@"Server=.\SQLEXPRESS; Database=VotingTypeDatabaseContext;Trusted_Connection=True;")
           );

            services.AddDbContext<Data.LoginTokenDatabaseContext>(options =>
              options.UseSqlServer(@"Server=.\SQLEXPRESS; Database=LoginTokenDatabaseContext;Trusted_Connection=True;")
          );

            services.AddMvc(option => option.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.AllowAnyHeader()
                           .AllowAnyMethod()
                           .AllowAnyOrigin();
                });
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GoVoteAPI", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "GoVoteAPI V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
