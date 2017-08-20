using Corale.Colore.Core;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.ColorHandler
{
    class ChromaDriver : ColorDriver
    {
        public override void SetColor(Color4 color)
        {
            Color c = new Color(color.R, color.G, color.B);
            //Debug.WriteLine("Colors: "+  color.R + " "+ color.G + " "+ color.B);
            Chroma.Instance.SetAll(c);
        }
    }
}
