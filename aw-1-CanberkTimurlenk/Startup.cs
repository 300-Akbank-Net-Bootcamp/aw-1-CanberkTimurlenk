using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace aw_1_CanberkTimurlenk;
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        // Add FluentValidation to the pipeline, enable integration between Asp.Net Core Validation and FluentValidation
        services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

        // Register all validators from this assembly
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(configure => configure.MapControllers());
    }
}