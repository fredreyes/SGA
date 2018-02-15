using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Presentacion
{
  public  class EstiloMenu
    {
        public void AplicarEstilo(MaterialForm x)
        {
            try
            {
                MaterialSkinManager m = MaterialSkinManager.Instance;
                m.AddFormToManage(x);
                m.Theme = MaterialSkinManager.Themes.LIGHT;
                m.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue500, Accent.LightBlue700, TextShade.WHITE);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
