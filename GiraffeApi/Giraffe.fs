module Controller

open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.DependencyInjection
open Giraffe
open FSharp.Control.Tasks.V2.ContextInsensitive
open Types

let handleGetHello next ctx = task {
    let response = {
        Text = "Hello world, from Giraffe api!"
    }
    return! json response next ctx
}

let webApp =
    choose [
        subRoute "/api"
            (choose [
                GET >=> choose [
                    route "/hello" >=> handleGetHello
                ]
            ])
        setStatusCode 404 >=> text "Not Found" ]

let configureApp (app : IApplicationBuilder) =
    app
        .UseHttpsRedirection()
        .UseGiraffe(webApp)

let configureServices (services : IServiceCollection) =
    services.AddGiraffe() |> ignore