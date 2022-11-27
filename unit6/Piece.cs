namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Piece : Actor
    {
        protected Body body;
        protected Animation animation;
        protected int points;

        protected bool isSelected;
        protected bool isWhite;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Piece(Body body, Animation animation, int points, bool debug) : base(debug)
        {
            this.body = body;
            this.animation = animation;
            this.points = points;
            this.isSelected = false;
            this.isWhite = true;
        }

        /// <summary>
        /// Gets the animation.
        /// </summary>
        /// <returns>The animation.</returns>
        public Animation GetAnimation()
        {
            return animation;
        }

        /// <summary>
        /// Gets the body.
        /// </summary>
        /// <returns>The body.</returns>
        public Body GetBody()
        {
            return body;
        }

        public bool IsSelected()
        {
            return isSelected;
        }

        public void SelectPiece()
        {
            isSelected = true;
        }

        public void DeselectPiece()
        {
            isSelected = false;
        }

        /// <summary>
        /// Gets the points.
        /// </summary>
        /// <returns>The points.</returns>
        public int GetPoints()
        {
            return points;
        }


         public void MoveNext()
        {
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();
            Point newPosition = position.Add(velocity);
            body.SetPosition(newPosition);
        }

        public void StopMoving()
        {
            Point velocity = new Point(0, 0);
            body.SetVelocity(velocity);
        }

        // returns true if the given coordinaes are within the bounds of this piece
        public bool IsOverlapping(Point otherPosition)
        {
            Point pieceCoordinates = body.GetPosition();

            if (otherPosition.GetX() > pieceCoordinates.GetX()
                && otherPosition.GetX() < pieceCoordinates.GetX() + Constants.PIECE_WIDTH
                && otherPosition.GetY() > pieceCoordinates.GetY() 
                && otherPosition.GetY() < pieceCoordinates.GetY() + Constants.PIECE_HEIGHT)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool IsExactPositionMatch(Piece otherPiece)
        {
            return body.GetPosition().Equals(otherPiece.GetBody().GetPosition());
        }

        public bool IsOnSameTeam(Piece otherPiece)
        {
            return isWhite == otherPiece.isWhite;
        }
        
    }
}