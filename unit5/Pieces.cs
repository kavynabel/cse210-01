using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>A long limbless reptile.</para>
    /// <para>The responsibility of Snake is to move itself.</para>
    /// </summary>
    public class Pieces : Actor
    {
        protected Color playerBodyColor;
        protected Color snakeHeadColor;
        protected string textP;
        protected int snake_x;
        protected int snake_y;
        protected List<Actor> segments = new List<Actor>();

        /// <summary>
        /// Constructs a new instance of a Snake.
        /// </summary>
        public Pieces (int x, int y, Color body, Color head, string textLook)
        {
            playerBodyColor = body;
            snakeHeadColor = head;
            textP = textLook;
            snake_x = x;
            snake_y = y;
            PrepareBody(x, y, textP, body);
        }

        /// <summary>
        /// Gets the snake's body segments.
        /// </summary>
        /// <returns>The body segments in a List.</returns>
        public List<Actor> GetBody()
        {
            return new List<Actor>(segments.Skip(1).ToArray());
        }

        /// <summary>
        /// Gets the snake's head segment.
        /// </summary>
        /// <returns>The head segment as an instance of Actor.</returns>
        // public Actor GetHead()
        // {
        //     return segments[0];
        // }

        /// <summary>
        /// Gets the snake's segments (including the head).
        /// </summary>
        /// <returns>A list of snake segments as instances of Actors.</returns>
        public List<Actor> GetSegments()
        {
            return segments;
        }

        /// <summary>
        /// Grows the snake's tail by the given number of segments.
        /// </summary>
        /// <param name="numberOfSegments">The number of segments to grow.</param>
        public void GrowTail(int numberOfSegments)
        {
            for (int i = 0; i < numberOfSegments; i++)
            {
                Actor tail = segments.Last<Actor>();
                Point velocity = tail.GetVelocity();
                Point offset = velocity.Reverse();
                Point position = tail.GetPosition().Add(offset);

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText("$");
                segment.SetColor(playerBodyColor);
                segments.Add(segment);
            }
        }
        public void GrowTail(int numberOfSegments, Color tailColor)
        {
            for (int i = 0; i < numberOfSegments; i++)
            {
                Actor tail = segments.Last<Actor>();
                Point velocity = tail.GetVelocity();
                Point offset = velocity.Reverse();
                Point position = tail.GetPosition().Add(offset);

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText("K");
                segment.SetColor(playerBodyColor);
                segments.Add(segment);
            }
        }

        /// <inheritdoc/>
        public override void MoveNext()
        {
            foreach (Actor segment in segments)
            {
                segment.MoveNext();
            }

            // for (int i = segments.Count - 1; i > 0; i--)
            // {
            //     Actor trailing = segments[i];
            //     Actor previous = segments[i - 1];
            //     Point velocity = previous.GetVelocity();
            //     trailing.SetVelocity(velocity);
            // }
        }

        /// <summary>
        /// Turns the head of the snake in the given direction.
        /// </summary>
        /// <param name="velocity">The given direction.</param>
        public void TurnHead(Point direction)
        {
            //segments[0].SetVelocity(direction);
        }

        /// <summary>
        /// Prepares the snake body for moving.
        /// </summary>
        protected virtual void PrepareBody()
        {
            // int x = Constants.MAX_X / 4;
            // int y = Constants.MAX_Y / 2;
            int x = snake_x;
            int y = 300;

            // for (int i = 0; i < Constants.SNAKE_LENGTH; i++)
            // {
            //     // Point position = new Point(x - i * Constants.CELL_SIZE, y);
            //     // Point velocity = new Point(1 * Constants.CELL_SIZE, 0);
            //     Point position = new Point(x, y + i * Constants.CELL_SIZE);
            //     Point velocity = new Point(0, -1 * Constants.CELL_SIZE);
            //     string text = i == 0 ? "8" : "#";
            //     Color color = i == 0 ? Constants.YELLOW : Constants.GREEN;

            //     Actor segment = new Actor();
            //     segment.SetPosition(position);
            //     segment.SetVelocity(velocity);
            //     segment.SetText(text);
            //     segment.SetColor(color);
            //     segments.Add(segment);
            // }
            Point position = new Point(x, y);
            Point posistion = new Point(x, y);
            string text = "K";
            Color color = Constants.YELLOW;

            Actor segment = new Actor();
            segment.SetPosition(position);
            //segment.SetVelocity(velocity);
            segment.SetText(text);
            segment.SetColor(color);
            segments.Add(segment);


        }
        protected virtual void PrepareBody(int startX, int startY, string setText, Color body)
        {
            int x = startX;
            int y = startY;
            string textPlayer = setText;
            

            // for (int i = 0; i < Constants.SNAKE_LENGTH; i++)
            // {
            //     // Point position = new Point(x - i * Constants.CELL_SIZE, y);
            //     // Point velocity = new Point(1 * Constants.CELL_SIZE, 0);
            //     Point position = new Point(x, y + i * Constants.CELL_SIZE);
            //     Point velocity = new Point(0, -1 * Constants.CELL_SIZE);
            //     string text = i == 0 ? "8" : "#";
            //     Color color = i == 0 ? snakeHeadColor : snakeBodyColor;

            //     Actor segment = new Actor();
            //     segment.SetPosition(position);
            //     segment.SetVelocity(velocity);
            //     segment.SetText(text);
            //     segment.SetColor(color);
            //     segments.Add(segment);
            // }

            Point position = new Point(x, y);
            Point posistion = new Point(x, y);
            string text = textPlayer;
            Color color = body;

            Actor segment = new Actor();
            segment.SetPosition(position);
            //segment.SetVelocity(velocity);
            segment.SetText(text);
            segment.SetColor(color);
            segments.Add(segment);
        }
    }
}