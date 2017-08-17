using RLNET;

namespace RogueSharpV3Tutorial.Core
{
    public class Colors
    {
        public static RLColor FloorBackground = RLColor.Black;
        public static RLColor Floor = Palette.AlternateDarkest;
        public static RLColor FloorBackgroundFov = Palette.DbDark;
        public static RLColor FloorFov = Palette.Alternate;

        public static RLColor WallBackground = Palette.SecondaryDarkest;
        public static RLColor Wall = Palette.Secondary;
        public static RLColor WallBackgroundFov = Palette.SecondaryDarker;
        public static RLColor WallFov = Palette.SecondaryLighter;

        public static RLColor TextHeading = RLColor.White;
        public static RLColor Text = Palette.DbLight;
        public static RLColor Gold = Palette.DbSun;

        //Monster colors
        public static RLColor KoboldColor = Palette.DbBrightWood;

        //Player Color
        public static RLColor Player = Palette.DbLight;
    }
}