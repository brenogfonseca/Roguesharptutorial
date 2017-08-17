using RogueSharp;
using RLNET;
using RogueSharpV3Tutorial.Core;

namespace RogueSharpV3Tutorial.Systems
{
    public class CommandSystem
    {
        public bool MovePlayer (Direction direction)
        {
            int x = Game.Player.X;
            int y = Game.Player.Y;
            switch (direction)
            {
                case Direction.Up:
                    {
                        y = Game.Player.Y - 1;
                        break;
                    }
                case Direction.Down:
                    {
                        y = Game.Player.Y + 1;
                        break;
                    }
                case Direction.Left:
                    {
                        x = Game.Player.X - 1;
                        break;
                    }
                case Direction.Right:
                    {
                        x = Game.Player.X + 1;
                        break;
                    }
                case Direction.DownRight:
                    {
                        y = Game.Player.Y + 1;
                        x = Game.Player.X + 1;
                        break;
                    }
                case Direction.DownLeft:
                    {
                        y = Game.Player.Y + 1;
                        x = Game.Player.X - 1;
                        break;
                    }
                case Direction.UpRight:
                    {
                        y = Game.Player.Y - 1;
                        x = Game.Player.X + 1;
                        break;
                    }
                case Direction.UpLeft:
                    {
                        y = Game.Player.Y - 1;
                        x = Game.Player.X - 1;
                        break;
                    }
                default:
                    {
                        return false;
                    }
            }
            if (Game.DungeonMap.SetActorPosition (Game.Player, x, y ))
            {
                return true;
            }
            return false;
        }
    }
}
