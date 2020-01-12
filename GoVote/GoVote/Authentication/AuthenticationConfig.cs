using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace GoVote.Authentication
{
    public static class AuthenticationConfig
    {
        public static void ConfigureJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("Keys").GetSection("Key").Value));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenValidationParams = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                ValidIssuer = "https://localhost:44380",
                ValidateLifetime = true,
                ValidAudience = "https://localhost:44380",
                ValidateAudience = true,
                RequireSignedTokens = true,
                IssuerSigningKey = credentials.Key,
                ClockSkew = TimeSpan.FromMinutes(120)

            };

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = tokenValidationParams;
                options.RequireHttpsMetadata = false;
            });

        }

    }
}
