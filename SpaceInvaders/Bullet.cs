using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvaders
{
    class Bullet
    {
        

        Texture2D texture;
        Vector2 position;
        float velocity = 3;

        bool isDestroyed;
        
        public Bullet(Texture2D tex, Vector2 pos, bool isPlayer)
        {
            texture = tex;
            position = pos;
            isDestroyed = false;
            if (isPlayer)
                velocity *= -1;

        }
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
        public float Velocity
        {
            get { return velocity; }
        }
        public bool IsDestroyed
        {
            get { return isDestroyed; }
            set { isDestroyed = value; }

        }

    }
}
