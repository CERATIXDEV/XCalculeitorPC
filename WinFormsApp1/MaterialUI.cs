using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ColorInterface
{
    public class MaterialUI1
    {
        public static void loadMaterial(MaterialForm actualForm)
        {
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(actualForm);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightBlue900, // 
                Primary.LightBlue500,
                Primary.Yellow100, 
                Accent.Yellow400, // CAMBIA EL COLOR DE LOS CHEKBOX Y RADIOBUTTON
                TextShade.WHITE
            );
        }
    }

    public class MaterialUI2
    {
        public static void loadMaterial(MaterialForm actualForm)
        {
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(actualForm);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red200, Primary.Yellow300,
                Primary.Yellow100, Accent.Yellow400,
                TextShade.WHITE
            );
        }
    }
    public class MaterialUI3
    {
        public static void loadMaterial(MaterialForm actualForm)
        {
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(actualForm);
            materialSkinManager.Theme = MaterialSkinManager.Themes. DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, 
                Primary.Blue500,
                Primary.Green200, 
                Accent.Red400,
                TextShade.BLACK
            );
        }
    }
}