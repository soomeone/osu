using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.ColorHandler
{
    abstract class ColorDriver
    {
        public abstract void SetColor(Color4 color);
        public virtual Color4 GetColor() { return Color4.White; }
        public virtual void Close() { }
    }
}
