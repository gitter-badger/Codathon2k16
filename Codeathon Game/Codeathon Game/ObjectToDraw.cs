﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Codeathon_Game
{
    [Serializable]
    class ObjectToDraw
    {
        public Texture2D texture;
        public Vector2 location;
        public float rotation;
        public int width { get; private set; }
        public int height { get; private set; }
        public bool canBeDraged;

        public ObjectToDraw dock;
        public Vector2 dockOffset;

        public ObjectToDraw(Texture2D texture, Vector2 location)
        {
            this.location = location;
            this.texture = texture;
            width = texture.Width;
            height = texture.Height;
        }

        public ObjectToDraw(GraphicsDevice d, Vector2 location, int width, int height)
        {
            this.location = location;
            this.width = width;
            this.height = height;
            texture = new Texture2D(d, this.width, this.height);
        }

        public ObjectToDraw(Vector2 location, int width, int height)
        {
            this.location = location;
            this.width = width;
            this.height = height;

        }

        virtual public void Draw()
        {
            if (rotation != 0)
            {
                Game.spriteBatch.Draw(texture, new Rectangle((int)location.X, (int)location.Y, texture.Width, texture.Height), null, Color.White, rotation, new Vector2(texture.Width / 2, texture.Height / 2), SpriteEffects.None, 0f);
            }
            else
            {
                Game.spriteBatch.Draw(texture, new Rectangle((int)location.X, (int)location.Y, texture.Width, texture.Height), Color.White);
            }
        }

        public virtual void Update()
        {

        }

        public virtual void CheckEdges()
        {

        }

        public void setData(Color[] data)
        {
            texture.SetData(data);
        }

    }
}
