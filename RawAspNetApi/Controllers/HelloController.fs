namespace RawAspNetApi.Controllers

open Microsoft.AspNetCore.Mvc
open Types

[<ApiController>]
[<Route("api/[controller]")>]
type HelloController () =
    inherit ControllerBase()

    [<HttpGet>]
    member __.Get() : Message =
        { Text = "Hello world, from RawAspNet api!"  }
