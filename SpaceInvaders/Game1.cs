using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvaders
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

       
        Rectangle SpaceshipBox = new Rectangle(100,100,40, 40);

        Content.PlayerSpaceship Player = new Content.PlayerSpaceship();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Player.Pos = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            Player.SpaceshipTex = Content.Load<Texture2D>("Seeker");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.A)|| Keyboard.GetState().IsKeyDown(Keys.Left))
                Player.Move('L');
            if (Keyboard.GetState().IsKeyDown(Keys.D)|| Keyboard.GetState().IsKeyDown(Keys.Right))
                Player.Move('R');

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            
            _spriteBatch.Begin();
            _spriteBatch.Draw(Player.SpaceshipTex, Player.Pos, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
