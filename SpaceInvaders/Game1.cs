using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace SpaceInvaders
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        
        Texture2D bullet;
        Texture2D enemy1;
        Texture2D enemy2;
        Texture2D enemy3;
        
        List<Bullet> bullets = new List<Bullet>();
        List<Enemy> enemies = new List<Enemy>();
       

        Content.PlayerSpaceship Player = new Content.PlayerSpaceship();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Player.Pos = new Vector2(GraphicsDevice.Viewport.Width /2, GraphicsDevice.Viewport.Height - 70);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            Player.SpaceshipTex = Content.Load<Texture2D>("Seeker");
            bullet = Content.Load<Texture2D>("Laser");
            enemy1 = Content.Load<Texture2D>("Player");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.A)|| Keyboard.GetState().IsKeyDown(Keys.Left))
                Player.Move('L');
            if (Keyboard.GetState().IsKeyDown(Keys.D)|| Keyboard.GetState().IsKeyDown(Keys.Right))
                Player.Move('R');

            if (Keyboard.GetState().IsKeyDown(Keys.E) && Player.Cooldown >= 500)
            {
                enemies.Add(new Enemy(enemy1, new Vector2(100,100)));
                Player.Cooldown = 0;
            }

            Player.Cooldown += gameTime.ElapsedGameTime.TotalMilliseconds;

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && Player.Cooldown >= 500)
            {
                bullets.Add(new Bullet(bullet, Player.Pos, true));
                Player.Cooldown = 0;
            }
            try
            {
                foreach (Bullet b in bullets)
                {
                    b.Position = new Vector2(b.Position.X , b.Position.Y + b.Velocity);
                }
            }
            catch (System.NullReferenceException) { }
           

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            
            _spriteBatch.Begin();

            try
            {
                foreach (Enemy e in enemies)
                    _spriteBatch.Draw(e.Texture, e.Position, Color.White);
            }
            catch (System.NullReferenceException) { }

            try
            {
                foreach (Bullet b in bullets)
                    _spriteBatch.Draw(bullet, b.Position, Color.White);
            }
            catch (System.NullReferenceException) { }
            
            

            _spriteBatch.Draw(Player.SpaceshipTex, Player.Pos, Color.White);
            
            
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
