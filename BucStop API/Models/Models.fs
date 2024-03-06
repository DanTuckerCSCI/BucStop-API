namespace BucStop_API.Models

type GameDetails =
    { GameName : string
      GameDescription : string
      HowToPlay : string
      GameThumbnail : string
      GameJavaScript : string
      LeaderboardInfo : string }

type GameResult =
    { GameName : string
      UserInitials : string
      Score : int }
