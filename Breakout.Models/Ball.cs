using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwistedLogik.Ultraviolet;

namespace Breakout.Models
{
    /// <summary>
    /// Represents an active body ball which bounces
    /// </summary>
    class Ball : CollisionObject
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        /// <param name="position">Initial Position</param>
        /// <param name="collisionBox">Collision box for the object</param>
        /// <param name="direction">Direction of the current ball</param>
        public Ball(Point2F position, RectangleF collisionBox, Vector2 direction) : base()
        {
            this.position = position;
            this.collisionBox = collisionBox;
            this.direction = direction;
        }

        /// <summary>
        /// Vector representing the current direction and magnitude of travel
        /// </summary>
        public Vector2 direction { get; set; }

        /// <summary>
        /// Radius of the ball
        /// </summary>
        public float radius { get; set; }
    }
}
