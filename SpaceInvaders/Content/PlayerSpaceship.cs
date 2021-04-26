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
        double cooldown = 0;
        
        
        Vector2 scale = new Vector2(1, 1);


        public PlayerSpaceship()
        {
            // hitbox = new Rectangle(Convert.ToInt32(pos.X), Convert.ToInt32(pos.Y), 100, 100);
            
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
        public double Cooldown
        {
            get { return cooldown; }
            set { cooldown = value; }
        }
       
    }
}
