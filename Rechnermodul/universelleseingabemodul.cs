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
    public partial class universelleseingabemodul : Form
    {
        public const int STATE_NEXT_PARAM = 1;
        public const int STATE_NEXT_VALUE= 2;

        private RechnermodulBibliothek.UIElement[] elements;

        public int state;

        private RechnermodulBibliothek.UIElement element;

        public universelleseingabemodul()
        {
            InitializeComponent();
        }

        private void add_string_in_current_control(string s)
        {
            foreach (Control c in funktionsPanel.Controls)
            {
                if (c.Focused && c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    int cursorPos = tb.SelectionStart;

                    tb.Text = tb.Text.Insert(cursorPos, s);
                    tb.SelectionStart = cursorPos + 1;
                }
            }
        }

        private void backspace_in_current_control()
        {
            foreach (Control c in funktionsPanel.Controls)
            {
                if (c.Focused && c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    int cursorPos = tb.SelectionStart;

                    int len = tb.Text.Length;
                    if (cursorPos == 0)
                    {
                        return;
                    }
                    if (cursorPos == len - 1)
                    {
                        tb.Text = tb.Text.Substring(0, cursorPos - 1);
                        tb.SelectionStart = cursorPos - 1;
                        return;
                    }
                    tb.Text = tb.Text.Substring(0, cursorPos - 1) + tb.Text.Substring(cursorPos);
                    tb.SelectionStart = cursorPos - 1;
                }
            }
        }

        public void buildUi(RechnermodulBibliothek.UIElement element)
        {
            if (element.getType() == RechnermodulBibliothek.UIElement.TYPE_SINGLE)
            {
                int delta_y = panel_array.Height;
                panel_array.Visible = false;
                eingabePanel.Top -= delta_y;
            }

            lb_param_name.Text = element.getDescription();

            this.element = element;
        }

        public void setData(string data)
        {
            tb_param.Text = data;
        }

        public string getData()
        {
            return this.element.getModifiers().run(tb_param.Text);
        }

        private void universelleseingabemodul_Load(object sender, EventArgs e)
        {

        }

        private void numericInputButton1_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("1");
        }

        private void numericInputButton2_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("2");
        }

        private void numericInputButton3_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("3");
        }

        private void numericInputButton4_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("4");
        }

        private void numericInputButton5_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("5");
        }

        private void numericInputButton6_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("6");
        }

        private void numericInputButton7_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("7");
        }

        private void numericInputButton8_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("8");
        }

        private void numericInputButton9_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("9");
        }

        private void numericInputButton10_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("0");
        }

        private void numericInputButtonBackspace_Click(object sender, EventArgs e)
        {
            this.backspace_in_current_control();
        }

        private void numericInputButtonplus_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("+");
        }

        private void numericInputButtonminus_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("-");
        }

        private void numericInputButtonmultiplication_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("*");
        }

        private void numericInputButtondivision_Click(object sender, EventArgs e)
        {
            this.add_string_in_current_control("/");
        }

        private void btn_next_param_Click(object sender, EventArgs e)
        {
            try
            {
                this.element.getModifiers().run(tb_param.Text);
            } 
            catch (RechnermodulBibliothek.NutzerEingabeFehler err)
            {
                errorProvider1.SetError(tb_param, err.Message);

                return;
            }

            this.state = universelleseingabemodul.STATE_NEXT_PARAM;

            this.Close();
        }

        private void btn_next_value_Click(object sender, EventArgs e)
        {
            this.state = universelleseingabemodul.STATE_NEXT_VALUE;

            this.Close();
        }
    }

    public class DatenNichtValideFehler : Exception { }


    public class NumericInputButton : Button
    {
        public NumericInputButton()
        {
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
