using MaterialSkin;
using MaterialSkin.Controls;

namespace Sismio
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, // primary
                Primary.BlueGrey900, // darkPrimary
                Primary.BlueGrey500, // lightPrimary
                Accent.LightBlue200, // accent
                TextShade.WHITE);   // textShade
        }
    }
}
