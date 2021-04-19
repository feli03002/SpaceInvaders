using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvaders.Content
{
    class PlayerSpaceship
    {
        Texture2D spaceshipTex;
        Vector2 pos;
        Vector2 scale = new Vector2(1, 1);
        Vector2 origin = new Vector2(0, 0);
        
        public PlayerSpaceship()
        {
           

        }
        public void Move(Char direction)
        {
            if (direction == 'L')
                pos.X-=4;
            if (direction == 'R')
                pos.X+=4;
        }
        public Texture2D SpaceshipTex
        {
            get { return spaceshipTex; }
            set { spaceshipTex = value; }
        }
        public Vector2 Pos
        {
            get { return pos; }
            set { pos = value; }
        }
        public Vector2 Scale
        {
            get { return scale; }
            set { scale = value; }
        }
        public Vector2 Origin
        {
            get { return origin; }
            set { origin = value; }
        }
    }
}
