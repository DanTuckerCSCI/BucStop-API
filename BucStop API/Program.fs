open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open System.IO

[<EntryPoint>]
let main args =
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(fun webBuilder ->
            webBuilder
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>() |> ignore)
        .Build()
        .Run()
    0 // Return an integer exit code
