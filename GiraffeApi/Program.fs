module GiraffeApi.Program

open System
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Controller
open Microsoft.AspNetCore

[<EntryPoint>]
let main _ =
    let exitCode = 0
    WebHost.CreateDefaultBuilder()
        .Configure(Action<IApplicationBuilder> configureApp)
        .ConfigureServices(configureServices)
        .UseUrls("http://0.0.0.0:8085/")
        .Build()
        .Run()

    exitCode