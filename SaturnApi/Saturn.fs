module Server

open Saturn
open Giraffe
open Types
open FSharp.Control.Tasks.V2.ContextInsensitive

let hello ctx = task {
    let response = {
        Text = "Hello world, from Saturn api!"
    }
    return! Controller.json ctx response
}

let helloController = controller {
    index hello
}

let apiRouter = router {
    forward "/hello" helloController
}

let appRouter = router {
    forward "/api" apiRouter
}

let app url' = application {
    use_router appRouter
    url url'
    service_config (fun s -> s.AddGiraffe())
}