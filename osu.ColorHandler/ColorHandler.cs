using OpenTK.Graphics;
using osu.ColorHandler.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.ColorHandler
{
    public class ColorHandler
    {
        static ColorDriver Driver = new DriverArray();

        {
            Driver.SetColor(new Color4(255, 102, 170, 255));
        }

        public static void SetComboColor(Color4 color)
        {
            Driver.SetColor(color);
        }

        public static void SetFadeComboColor(Color4 color)
        {
            Driver.SetColor(color); // Fading not implemented yet
        }

        public static void Close()
        {
            // Some drivers require to close manually, so they can work normally again
            Driver.Close();
            System.Diagnostics.Debug.WriteLine("Driver Closed");
        }
    }
}
