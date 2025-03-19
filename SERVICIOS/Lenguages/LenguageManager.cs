using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICIOS.Lenguages
{
    public class LenguageManager
    {
        private ResourceManager _resMan;

        public LenguageManager(string language)
        {
            _resMan = new ResourceManager($"YourNamespace.Resources.{language}", typeof(LenguageManager).Assembly);
        }

        public void ApplyResources(Control parent)
        {
            string name = parent is Form ? "$this" : parent.Name;
            string text = _resMan.GetString(name + ".Text");
            if (text != null)
            {
                parent.Text = text;
            }

            foreach (Control ctl in parent.Controls)
            {
                ApplyResources(ctl);
            }
        }


    }
}
