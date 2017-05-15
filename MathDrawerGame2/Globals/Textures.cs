using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathDrawerGame2.Globals
{
    public static class Textures
    {
        public static Texture2D SAVE_ICON;
        public static Texture2D NEW_ICON;
        public static Texture2D LOAD_ICON;

        public static void LoadTextures(Microsoft.Xna.Framework.Content.ContentManager contentManager)
        {
            SAVE_ICON = contentManager.Load<Texture2D>("saveicon");
            NEW_ICON = contentManager.Load<Texture2D>("newicon");
            LOAD_ICON = contentManager.Load<Texture2D>("loadicon");
        }
    }
}
