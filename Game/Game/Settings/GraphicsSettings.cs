using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Settings
{
    public class GraphicsSettings
    {
        const int DEFAULT_BRIGHTNESS = 50;
        const int DEFAULT_CONTRAST = 50;
        const bool DEFAULT_IS_MONO = false;

        private int brightness;
        private int contrast;
        private bool is_mono;

        public GraphicsSettings() {
        //enable default settings
        }
        public GraphicsSettings(int brightness, int contrast, bool is_mono) {
        }
    }
}
