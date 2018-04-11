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
    public class DatenNichtValideFehler : Exception { }

    public partial class universelleseingabemodul : Form
    {
        private RechnermodulBibliothek.UIElement[] elements;

        public universelleseingabemodul()
        {
            InitializeComponent();
        }

        private class UserData : RechnermodulBibliothek.UserDataInterface
        {
            private Dictionary<string, string> values;
            private Dictionary<string, string[]> arrays;

            public UserData(Dictionary<string, string> stringValues, Dictionary<string, string[]> stringArrays)
            {
                this.values = stringValues;
                this.arrays = stringArrays;
            }

            string RechnermodulBibliothek.UserDataInterface.getStringValue(string key)
            {
                if (!this.values.ContainsKey(key))
                {
                    throw new Exception("Der Schlüssel ist halt nicht verfügbar");
                }
                return this.values[key];
            }

            string[] RechnermodulBibliothek.UserDataInterface.getStringArray(string key)
            {
                if (!this.arrays.ContainsKey(key))
                {
                    throw new Exception("Der Schlüssel ist halt nicht verfügbar");
                }
                return this.arrays[key];
            }
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

        public void buildUi(RechnermodulBibliothek.UIBuilderInterface uiBuilder)
        {
            this.elements = uiBuilder.getUIElements();

            int y = 0;

            for (int i = 0; i < this.elements.Length; i++)
            {
                RechnermodulBibliothek.UIElement element = this.elements[i];
                Label label = new Label();
                label.Text = element.getDescription();
                label.Name = "l_" + element.getKey();
                label.AutoSize = true;
                label.Top = y;
                label.Show();
                funktionsPanel.Controls.Add(label);
                y += 20;

                if (element.getType() == RechnermodulBibliothek.UIElement.TYPE_SINGLE)
                {
                    TextBox tb = new TextBox();
                    tb.Name = "tb_" + element.getKey();
                    tb.Left = 0;
                    tb.Width = funktionsPanel.Width - 20;
                    tb.Top = y;
                    tb.Show();
                    tb.Validating += (sender, e) => { this.validate_single_entry(tb, element.getModifiers()); };
                    funktionsPanel.Controls.Add(tb);
                    y += 25;
                }
                else
                {
                    Button btn_add = new Button();
                    Button btn_rm = new Button();
                    TextBox tb_new = new TextBox();
                    ListBox lb = new ListBox();

                    tb_new.Name = "tb_" + element.getKey();
                    tb_new.Top = y;
                    tb_new.Left = 50;
                    tb_new.Width = funktionsPanel.Width - 75;
                    tb_new.Validating += (sender, e) => { this.validate_single_entry(tb_new, element.getModifiers()); };
                    tb_new.Show();

                    btn_add.Text = "Add";
                    btn_add.Left = 0;
                    btn_add.Top = y + (tb_new.Height - btn_add.Height) / 2;
                    btn_add.Width = 40;
                    btn_add.Click += (sender, e) => this.add_clicked(element.getKey(), element.getModifiers());
                    btn_add.Show();

                    btn_rm.Text = "Del";
                    btn_rm.Left = 0;
                    btn_rm.Top = y + 30;
                    btn_rm.Width = 40;
                    btn_rm.Click += (sender, e) => this.del_clicked(element.getKey());
                    btn_rm.Show();

                    lb.Name = "lb_" + element.getKey();
                    lb.Top = y + 30;
                    lb.Left = tb_new.Left;
                    lb.Width = tb_new.Width;
                    lb.Height = 100;
                    y += 130;

                    funktionsPanel.Controls.Add(btn_add);
                    funktionsPanel.Controls.Add(btn_rm);
                    funktionsPanel.Controls.Add(tb_new);
                    funktionsPanel.Controls.Add(lb);
                }

            }
            funktionsPanel.Height = y;

            eingabePanel.Top = y + 50;
            this.Size = new Size(this.Size.Width, eingabePanel.Height + funktionsPanel.Height + 50);
        }

        private void validate_single_entry(TextBox tb, RechnermodulBibliothek.ModifierChain mc)
        {
            try
            {
                tb.Text = mc.run(tb.Text);
                errorProvider1.SetError(tb, "");
            } catch (RechnermodulBibliothek.NutzerEingabeFehler e)
            {
                errorProvider1.SetError(tb, e.Message);
            }
        }

        public void add_clicked(string key, RechnermodulBibliothek.ModifierChain mc)
        {
            ListBox lb = null;
            TextBox tb = null;

            string tb_key = "tb_" + key;
            string lb_key = "lb_" + key;

            foreach (Control c in funktionsPanel.Controls)
            {
                if (c.Name.Equals(tb_key))
                {
                    tb = (TextBox)c;
                }
                else if (c.Name.Equals(lb_key))
                {
                    lb = (ListBox)c;
                }
            }

            if (lb != null && tb != null)
            {
               if (errorProvider1.GetError(tb) == "")
                {
                    lb.Items.Add(mc.run(tb.Text));
                }
            }
        }

        public void del_clicked(string key)
        {
            string lb_key = "lb_" + key;

            foreach (Control c in funktionsPanel.Controls)
            {
                if (c.Name.Equals(lb_key))
                {
                    ListBox lb = (ListBox)c;
                    if (lb.SelectedIndex > -1)
                    {
                        lb.Items.RemoveAt(lb.SelectedIndex);
                    }
                }
            }
        }

        public RechnermodulBibliothek.UserDataInterface getData()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            Dictionary<string, string[]> arrays = new Dictionary<string, string[]>();

            foreach (Control c in funktionsPanel.Controls)
            {
                if (c.Name.StartsWith("tb_"))
                {
                    TextBox tb = (TextBox)c;
                    if (errorProvider1.GetError(tb) != "")
                    {
                        throw new DatenNichtValideFehler();
                    }
                    values.Add(tb.Name.Replace("tb_", ""), tb.Text);
                }
                else if (c.Name.StartsWith("lb_"))
                {
                    ListBox lb = (ListBox)c;
                    if (lb.Items.Count == 0)
                    {
                        throw new DatenNichtValideFehler();
                    }
                    string[] v = new string[lb.Items.Count];
                    for (int i = 0; i < lb.Items.Count; i++)
                    {
                        v[i] = (string)lb.Items[i];
                    }
                    arrays.Add(lb.Name.Replace("lb_", ""), v);
                }
            }


            return new UserData(values, arrays);
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
    }

    public class NumericInputButton : Button
    {
        public NumericInputButton()
        {
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
