namespace RawAspNetApi

open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting

module Program =
    let exitCode = 0

    let CreateHostBuilder args =
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(fun webBuilder ->
                webBuilder
                    .UseStartup<Startup>()
                    .UseUrls("http://0.0.0.0:8085/")|> ignore
            )

    [<EntryPoint>]
    let main args =
        CreateHostBuilder(args).Build().Run()

        exitCode
