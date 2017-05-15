using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathDrawerGame2.UI
{
    public class UILayer
    {
        List<Button> buttonlist = new List<Button>();
        internal void Add(Button button)
        {
            buttonlist.Add(button);
        }

        internal void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach(Button button in buttonlist){
                spriteBatch.Begin();
                spriteBatch.Draw(button.texture2D, new Vector2(button.p2, button.p3), Color.White);
                spriteBatch.End();
            }
        }
    }
}
