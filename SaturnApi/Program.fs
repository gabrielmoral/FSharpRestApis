module GiraffeApi.Program

open Saturn
open Server

[<EntryPoint>]
let main _ =
    let exitCode = 0
    app "http://0.0.0.0:8085/" |> run
        
    exitCode