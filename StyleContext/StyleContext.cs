using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StyleContext
{
    public class StyleContextAwareForm : Form 
    {
        private static StyleContext stylectx = null;
        private static List<StyleContextAwareForm> members = new List<StyleContextAwareForm>();

        public static StyleContext styleContext
        {
            get
            {
                return StyleContextAwareForm.stylectx;
            }
            set
            {
                StyleContextAwareForm.stylectx = value;
                foreach (StyleContextAwareForm member in StyleContextAwareForm.members)
                {
                    member.updateStyle();
                }
            }
        } 

        public StyleContextAwareForm()
        {
            if (null == StyleContextAwareForm.stylectx)
            {
                StyleContextAwareForm.stylectx = new StyleContext(new Font("Arial", 8), Color.White, Color.Black);
            }
            StyleContextAwareForm.members.Add(this);
            this.Load += this.load;
            this.FormClosed += (object o, FormClosedEventArgs e) => StyleContextAwareForm.members.Remove(this);
        }

        private void updateStyle()
        {
            List<Control> list = new List<Control>();
            this.GetAllControls(this, list);
            this.BackColor = StyleContextAwareForm.stylectx.bgColor;


            foreach (Control c in list)
            {
                c.Font = StyleContextAwareForm.stylectx.font;
                c.BackColor = StyleContextAwareForm.stylectx.bgColor;
                c.ForeColor = StyleContextAwareForm.stylectx.fgColor;
            }
        }

        private void load(object sender, EventArgs e)
        {
            this.updateStyle();
        }

        private void GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    GetAllControls(c, list);
                else
                    list.Add(c);
            }
        }
    }

    public class StyleContext
    {
        public Font font;
        public Color bgColor;
        public Color fgColor;

        public StyleContext(Font font, Color bgColor, Color fgColor)
        {
            this.font = font;
            this.bgColor = bgColor;
            this.fgColor = fgColor;
        }
    }
}
