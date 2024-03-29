using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// A collection of actors.
    /// </summary>
    public class Cast
    {
        private Dictionary<string, List<Actor>> actors = new Dictionary<string, List<Actor>>();

        /// <summary>
        /// Constructs a new instance of Cast.
        /// </summary>
        public Cast()
        {
        }

        /// <summary>
        /// Adds the given actor to the given group.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <param name="actor">The actor to add.</param>
        public void AddActor(string group, Actor actor)
        {
            if (!actors.ContainsKey(group))
            {
                actors[group] = new List<Actor>();
            }

            if (!actors[group].Contains(actor))
            {
                actors[group].Add(actor);
            }
        }

        /// <summary>
        /// Clears the actors in the given group.
        /// </summary>
        /// <param name="group">The given group.</param>
        public void ClearActors(string group)
        {
            if (actors.ContainsKey(group))
            {
                actors[group] = new List<Actor>();
            }
        }

        /// <summary>
        /// Clears all the actors in the cast.
        /// </summary>
        public void ClearAllActors()
        {
            foreach(string group in actors.Keys)
            {
                actors[group] = new List<Actor>();
            }
        }

        /// <summary>
        /// Gets the actors in the given group. Returns an empty list if there aren't any.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <returns>The list of actors.</returns>
        public List<Actor> GetActors(string group)
        {
            List<Actor> results = new List<Actor>();
            if (actors.ContainsKey(group))
            {
                results.AddRange(actors[group]);
            }
            return results;
        }

        /// <summary>
        /// Gets all the actors in the cast.
        /// </summary>
        /// <returns>A list of all actors.</returns>
        public List<Actor> GetAllActors()
        {
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> result in actors.Values)
            {
                results.AddRange(result);
            }
            return results;
        }

        /// <summary>
        /// Gets the first actor in the given group.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <returns>The first actor.</returns>
        public Actor GetFirstActor(string group)
        {
            Actor result = null;
            if (actors.ContainsKey(group))
            {
                if (actors[group].Count > 0)
                {
                    result = actors[group][0];
                }
            }
            return result;
        }

        /// <summary>
        /// Removes the given actor from the given group.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <param name="actor">The actor to remove.</param>
        public void RemoveActor(string group, Actor actor)
        {
            if (actors.ContainsKey(group))
            {
                actors[group].Remove(actor);
            }
        }

        public bool IsAnyPieceSelected()
        {
            Piece piece = FindSelectedPiece();
            return piece != null;
        }

        public Piece FindSelectedPiece()
        {
            Piece selectedPiece = null;

            foreach (Piece piece in GetActors(Constants.PIECE_GROUP))
            {
                if (piece.IsSelected())
                {
                    selectedPiece = piece;
                    break;
                }
            }

            return selectedPiece;
        }
    }
}