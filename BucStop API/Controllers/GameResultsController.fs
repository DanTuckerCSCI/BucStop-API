namespace BucStop_API.Controllers

open Microsoft.AspNetCore.Mvc
open BucStop_API.Models

[<ApiController>]
[<Route("[controller]")>]
type GameResultsController() =
    inherit ControllerBase()

    member this.PostGameResult(gameResult: GameResult) =
        // Placeholder for logic to forward game results to the specific game's application
        Ok("Result received and will be forwarded") :> IActionResult
