namespace BucStop_API

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting

type Startup() =
    member this.ConfigureServices(services: IServiceCollection) =
        services.AddControllers() |> ignore
        services.AddSwaggerGen() |> ignore

    member this.Configure(app: IApplicationBuilder, env: IWebHostEnvironment) =
        if env.IsDevelopment() then
            app.UseDeveloperExceptionPage()
            app.UseSwagger()
            app.UseSwaggerUI() |> ignore

        app.UseHttpsRedirection() |> ignore
        app.UseRouting() |> ignore
        app.UseAuthorization() |> ignore

        app.UseEndpoints(fun endpoints ->
            endpoints.MapControllers() |> ignore) |> ignore
