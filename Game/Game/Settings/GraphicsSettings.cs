using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Settings
{
    public class GraphicsSettings
    {
        const double DEFAULT_BRIGHTNESS = 0.5;
        const double DEFAULT_CONTRAST = 0.5;
        const bool DEFAULT_IS_MONO = false;

        public double Brightness { get; private set; }
        public double Contrast { get;private set; }
        public bool IsMono { get; private set; }

        public GraphicsSettings() {

        //enable default settings
            Brightness = DEFAULT_BRIGHTNESS;
            Contrast = DEFAULT_CONTRAST;
            IsMono = DEFAULT_IS_MONO;
        }
        public GraphicsSettings(double brightness, double contrast, bool is_mono) {
            Brightness = brightness;
            Contrast = contrast;
            IsMono = is_mono;
        }
    }
}
