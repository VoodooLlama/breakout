using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwistedLogik.Ultraviolet;

namespace Breakout.Models
{
    /// <summary>
    /// Respresents an object which is coll
    /// </summary>
    public abstract class CollisionObject
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public CollisionObject()
        {
            this.isActive = false;
        }

        /// <summary>
        /// Represents whether the object is actively colliding
        /// </summary>
        public bool isActive { get; protected set; }

        /// <summary>
        /// Represents the current position of the object
        /// </summary>
        public Point2F position { get; set; }

        /// <summary>
        /// Represents the collision box of the current object
        /// </summary>
        public RectangleF collisionBox { get; set; }

        /// <summary>
        /// Determines if two collision objects are intersecting
        /// </summary>
        /// <param name="potentialCollision">Object to compare collision boxes with</param>
        /// <returns>Indicator representing whether the two object collid</returns>
        public virtual bool isColliding(CollisionObject potentialCollision)
        {
            var rectA = this.collisionBox;
            var rectB = potentialCollision.collisionBox;

            return !(rectA.Top < rectA.Bottom && rectA.Bottom > rectA.Top &&
                     rectA.Left < rectB.Right && rectA.Right > rectB.Left);
        }
    }
}
