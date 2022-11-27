using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawPiecesAction : Action
    {
        private VideoService videoService;
        
        public DrawPiecesAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            List<Actor> pieces = cast.GetActors(Constants.PIECE_GROUP);
            foreach (Actor actor in pieces)
            {
                Piece piece = (Piece)actor;
                Body body = piece.GetBody();

                if (piece.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
                }

                Animation animation = piece.GetAnimation();
                Image image = animation.NextImage();
                Point position = body.GetPosition();
                videoService.DrawImage(image, position);
                
                if (piece.IsSelected())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
                }
            }
        }
    }
}