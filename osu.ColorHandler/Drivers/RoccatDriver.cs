using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;
using Roccat_Talk.TalkFX;

namespace osu.ColorHandler.Drivers
{
    class RoccatDriver : ColorDriver
    {
        TalkFxConnection TalkFX = new TalkFxConnection();
        public override void SetColor(Color4 color)
        {
            // Color is delivering RGB from 0 to 1, so multiply by 255 to get the right byte value
            TalkFX.SetLedRgb(Zone.Event, KeyEffect.On, Speed.Normal, new Color(Convert.ToByte(color.R * 255), Convert.ToByte(color.G *255), Convert.ToByte(color.B*255)));
            //System.Diagnostics.Debug.WriteLine("Colors: " + color.R + " " + color.G + " " + color.B);
        }

        public override void Close()
        {
            TalkFX.RestoreLedRgb();
        }
    }
}
