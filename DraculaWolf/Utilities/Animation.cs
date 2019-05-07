using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DraculaWolf
{
    public class Animation
    {
        protected ContentManager content;
        protected Texture2D image;
        protected string text;
        protected SpriteFont font;
        protected Color color;
        protected Rectangle sourceRect;
        float rotation, scale, axis;
        Vector2 origin, position;

        public virtual void LoadContent(ContentManager Content, Texture2D image, string text, Vector2 position)
        {
            content = new ContentManager(Content.ServiceProvider, "Content");
            this.image = image;
            this.text = text;
            this.position = position;

            if (text != string.Empty)
            {
                font = content.Load<SpriteFont>("AnimationFont");
                color = new Color(114, 52, 143);
            }
            if (image != null)
            {
                sourceRect = new Rectangle(0, 0, image.Width, image.Height);
            }
            scale = 1.0f;
            rotation = 0.0f;
            axis = 0.0f;
        }

        public virtual void UnloadContent()
        {
            content.Unload();
        }

        public virtual void Update(GameTime gameTime) { }

        public virtual void Draw(SpriteBatch spritebatch)
        {

        }

        public Animation()
        {
        }
    }
}
