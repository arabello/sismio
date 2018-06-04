using MaterialSkin;
using System.Drawing;

namespace Sismio.io.sismio.ui
{
    class SismioColor : ColorScheme
    {
        private static SismioColor instance = null;

        public static SismioColor Scheme
        {
            get
            {
                if (instance == null)
                {
                    instance = new SismioColor();
                }
                return instance;
            }
        }

        public static Color BackColor { get => Color.FromArgb(100, 215, 215, 215); }

    private SismioColor() : base(
                Primary.LightBlue600, // primary
                Primary.LightBlue900, // darkPrimary
                Primary.LightBlue400, // lightPrimary
                Accent.LightBlue400, // accent
                TextShade.WHITE)   // textShade
        {
           
        }
    }
}
