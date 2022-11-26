// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace Unit05.Game.Casting
// {
//     public class Player1
//     {
//         protected override void PrepareBody()
//         {
//             int x = Constants.MAX_X / 2;
//             int y = Constants.MAX_Y / 2;

//             for (int i = 0; i < Constants.SNAKE_LENGTH; i++)
//             {
//                 Point position = new Point(x - i * Constants.CELL_SIZE, y);
//                 Point velocity = new Point(1 * Constants.CELL_SIZE, 0);
//                 string text = i == 0 ? "8" : "#";
//                 Color color = i == 0 ? Constants.WHITE : Constants.RED;

//                 Actor segment = new Actor();
//                 segment.SetPosition(position);
//                 segment.SetVelocity(velocity);
//                 segment.SetText(text);
//                 segment.SetColor(color);
//                 segments.Add(segment);
//             base.PrepareBody();
//             }
//         }
//     }
// }