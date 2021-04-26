using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvaders
{
    class Enemy
    {
        Texture2D texture;
        Vector2 position;
        int type;


        public Enemy(Vector2 pos, int t)
        {
            
            position = pos;
            if(type == 1)
                texture = enemy1
        }
        public void Move()
        {

        }
        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
