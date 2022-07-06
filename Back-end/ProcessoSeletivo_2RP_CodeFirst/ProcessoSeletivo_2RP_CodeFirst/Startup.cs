using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;


namespace senai_filmes_webAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

           
        //    services.AddSwaggerGen(c =>
        //    {
        //        c.SwaggerDoc("v1", new OpenApiInfo
        //        {
        //            Version = "v1",
        //            Title = "Processo.webApi"

        //        });

        //        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        //        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        //        c.IncludeXmlComments(xmlPath);

        //    });

        //    services
        //        // Define a forma de autenticação
        //        .AddAuthentication(options => {
        //            options.DefaultAuthenticateScheme = "JwtBearer";
        //            options.DefaultChallengeScheme = "JwtBearer";
        //        })

        //        // Define os parâmetros de validação do token
        //        .AddJwtBearer("JwtBearer", options => {
        //            options.TokenValidationParameters = new TokenValidationParameters
        //            {
        //                // Será validado o emissor do token
        //                ValidateIssuer = true,

        //                // Será validado o destinatário do token
        //                ValidateAudience = true,

        //                // Será validado o tempo de vida do token
        //                ValidateLifetime = true,

        //                // Define a chave de segurança
        //                IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Login")),

        //                // Tempo de expiração do token
        //                ClockSkew = TimeSpan.FromMinutes(40),

        //                // Nome do isser, ou seja, quem gerou o token
        //                ValidIssuer = "Processo.webAPI",

        //                // Nome do audience, ou seja, para quem se destina a validação do token
        //                ValidAudience = "Processo.webAPI"
        //            };
        //        });                
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            //app.UseSwagger();


            //// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            //// specifying the Swagger JSON endpoint.
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Processo.webApi");
            //    c.RoutePrefix = string.Empty;
            //});


            
            app.UseAuthentication();    

           
            app.UseAuthorization();     

            app.UseEndpoints(endpoints =>
            {
              
                endpoints.MapControllers();
            });
        }
    }
}