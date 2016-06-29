namespace Breakout.Models
{
    /// <summary>
    /// Represents a grid of CollisionObjects
    /// </summary>
    public abstract class Grid
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        /// <param name="columns">Number of Columns</param>
        /// <param name="rows">Number of Rows</param>
        /// <param name="width">Grid Width</param>
        /// <param name="height">Grid Height</param>
        public Grid(int columns, int rows, int width, int height) : base()
        {
            this.nodes = new CollisionObject[columns, rows];
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Width of the Grid
        /// </summary>
        public int width;

        /// <summary>
        /// Height of the Grid
        /// </summary>
        public int height;

        /// <summary>
        /// Nodes represented in the current grid
        /// </summary>
        public CollisionObject[,] nodes
        {
            get;
            private set;
        }

        /// <summary>
        /// Searches the grid and returns the first active grid object which collides with the passed object if found
        /// </summary>
        /// <param name="potentialCollision">Object to be collision tested against each active grid object</param>
        /// <returns>Collision Object</returns>
        public CollisionObject findGridCollision(CollisionObject potentialCollision)
        {
            foreach (var gridObject in this.nodes) {
                if (gridObject.isActive && gridObject.isColliding(potentialCollision))
                {
                    return gridObject;
                }
            }

            return null;
        }

        /// <summary>
        /// Determines if the grid has no active items
        /// </summary>
        /// <returns>Indicator representing if the grid is empty</returns>
        public bool isEmpty()
        {
            foreach (var node in this.nodes)
            {
                if (node.isActive == true)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
