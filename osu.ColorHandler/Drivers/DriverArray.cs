using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;
using osu.ColorHandler.Drivers;

namespace osu.ColorHandler
{
    class DriverArray : ColorDriver
    {
        // Combines multiple drivers (in this case all avaliable), so they can be controlled centrally

        ColorDriver[] Drivers = {new ChromaDriver(), new RoccatDriver()};
        Color4 LastColor = Color4.White;

        public override void SetColor(Color4 color)
        {
            foreach (ColorDriver d in Drivers)
            {
                d.SetColor(color);
            }

            LastColor = color;
        }

        public override Color4 GetColor()
        {
            return LastColor;
        }

        public override void Close()
        {
            foreach (ColorDriver d in Drivers)
            {
                d.Close();
            }
        }
    }
}
