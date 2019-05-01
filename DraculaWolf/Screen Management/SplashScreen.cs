using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DraculaWolf
{
    public class SplashScreen : GameScreen
    {
        KeyboardState keystate;
        SpriteFont font;


        public SplashScreen()
        {
        }

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            if (font == null)
            {
                font = content.Load<SpriteFont>("font1");
            }
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }
        public override void Update(GameTime gametime)
        {
            keystate = Keyboard.GetState();
            if (keystate.IsKeyDown(Keys.Z))
            {
                ScreenManager.Instance.AddScreen(new TitleScreen());
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "SplashScreen",
                new Vector2(100, 100), Color.Black);
        }

    }
}
