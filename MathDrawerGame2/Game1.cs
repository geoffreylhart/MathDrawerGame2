using MathDrawerGame2.Globals;
using MathDrawerGame2.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MathDrawerGame2
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        UILayer uilayer;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            uilayer = new UILayer();
        }

        protected override void Initialize()
        {
            Textures.LoadTextures(this.Content);
            uilayer.Add(new Button("Save", 5, 5, Textures.SAVE_ICON));
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            uilayer.Draw(gameTime, spriteBatch);
        }
    }
}
