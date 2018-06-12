using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnermodul
{
    public partial class Einstellungen : StyleContext.StyleContextAwareForm
    {
        public Einstellungen() : base()
        {
            InitializeComponent();
        }

        private void btn_font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
           
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                
                StyleContext.StyleContextAwareForm.styleContext =
                    new StyleContext.StyleContext(
                        fontDialog1.Font,
                        StyleContext.StyleContextAwareForm.styleContext.bgColor,
                        fontDialog1.Color);
            }
        }

        private void btn_bgcolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                StyleContext.StyleContextAwareForm.styleContext =
                    new StyleContext.StyleContext(
                        StyleContext.StyleContextAwareForm.styleContext.font,
                        colorDialog1.Color,
                        StyleContext.StyleContextAwareForm.styleContext.fgColor
                        );
            }
        }
    }
}
