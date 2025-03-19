using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICIOS.Lenguages
{
    public class JsonManager
    {
        private Dictionary<string, FormResources> _resources;

        public JsonManager(string languageFile)
        {
            var json = File.ReadAllText(languageFile);
            var languageResources = JsonConvert.DeserializeObject<LanguageResources>(json);
            _resources = languageResources.Forms;
        }

        public void ApplyResources(Control parent)
        {
            if (parent is Form form && _resources.TryGetValue(form.Name, out var formResources))
            {
                form.Text = formResources.Text;

                foreach (Control ctl in parent.Controls)
                {
                    if (formResources.Controls.TryGetValue(ctl.Name + ".Text", out var text))
                    {
                        ctl.Text = text;
                    }
                }
            }
        }
    }

    public class FormResources
    {
        public string Text { get; set; }
        public Dictionary<string, string> Controls { get; set; } = new Dictionary<string, string>();
    }

    public class LanguageResources
    {
        public Dictionary<string, FormResources> Forms { get; set; } = new Dictionary<string, FormResources>();
    }


}

