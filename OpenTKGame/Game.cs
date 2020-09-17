using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.ES10;
using OpenTK.Input;
using System;

namespace OpenTKGame
{
    class Game : GameWindow
    {
        public Game(int width, int height, string title) :
            base(width, height, GraphicsMode.Default, title)
        { }

        

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            KeyboardState input = Keyboard.GetState();
            if(input.IsKeyDown(Key.Escape))
            {
                Exit();
            }
            base.OnUpdateFrame(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            
            //GL.ClearColor(0.2f, 0.3f, 03f, 1.0f);
            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //GL.Clear((int)ClearBufferMask.ColorBufferBit);

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            //GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }
    }
}
