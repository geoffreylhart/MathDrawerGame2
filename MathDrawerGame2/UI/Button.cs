using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathDrawerGame2.UI
{
    public class Button
    {
        public string p1;
        public int p2;
        public int p3;
        public Microsoft.Xna.Framework.Graphics.Texture2D texture2D;

        public Button(string p1, int p2, int p3, Microsoft.Xna.Framework.Graphics.Texture2D texture2D)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.texture2D = texture2D;
        }
    }
}
