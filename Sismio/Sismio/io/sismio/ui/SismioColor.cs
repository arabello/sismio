using MaterialSkin;
using Sismio.io.sismio.eventi;
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

        public static Color Priorita(Priorita p)
        {
            switch (p)
            {
                case eventi.Priorita.Info:
                    return Color.FromArgb(100, 26, 157, 224);
                case eventi.Priorita.Warning:
                    return Color.FromArgb(100, 241, 195, 15);
                case eventi.Priorita.Alert:
                    return Color.FromArgb(100, 211, 83, 0);
                case eventi.Priorita.Critical:
                    return Color.FromArgb(100, 231, 75, 59);
                case eventi.Priorita.Fatal:
                    return Color.Black;
                default:
                    return Color.FromArgb(100, 26, 157, 224);
            }
        }
        

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
