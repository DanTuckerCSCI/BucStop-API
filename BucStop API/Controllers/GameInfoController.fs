namespace BucStop_API.Controllers

open Microsoft.AspNetCore.Mvc
open BucStop_API.Models
open System.Collections.Generic

[<ApiController>]
[<Route("[controller]")>]
type GameInfoController() =
    inherit ControllerBase()

    member this.GetGameDetails(gameName: string) =
        let gameDetails = 
            { GameName = gameName
              GameDescription = "Placeholder Description"
              HowToPlay = "Placeholder Instructions"
              GameThumbnail = "Placeholder Thumbnail URL or base64"
              GameJavaScript = "Placeholder JavaScript Code"
              LeaderboardInfo = "Placeholder Leaderboard Data" }
        Ok(gameDetails) :> IActionResult
