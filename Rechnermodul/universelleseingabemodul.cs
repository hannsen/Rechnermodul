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
    public class InputButton : Button
    {
        public InputButton(universelleseingabemodul uem, string text, int width = 30)
        {
            SetStyle(ControlStyles.Selectable, false);
            this.Text = text;
            this.Width = width;
            this.Click += (sender, e) => uem.input_clicked(text);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }

    public partial class universelleseingabemodul : Form
    {
        private RechnermodulBibliothek.UIElement[] elements;

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

        public universelleseingabemodul()
        {
            InitializeComponent();
        }

        private void buildInputPanel()
        {
            int y = 10;

            InputButton btn_backspace = new InputButton(this, "<-");
            btn_backspace.Top = y;
            btn_backspace.Left = 160;
            btn_backspace.Show();
            eingabePanel.Controls.Add(btn_backspace);

            for (int row = 2; row >= 0; row--)
            {
                for (int col = 0; col < 3; col++)
                {
                    string text = (3 * row + col + 1).ToString();
                    Button btn = new InputButton(this, text);
                    btn.Top = y;
                    btn.Left = 10 + 50 * col;
                    btn.Show();

                    eingabePanel.Controls.Add(btn);
                }

                y += 30;
            }
            Button btn_0 = new InputButton(this, "0");
            btn_0.Top = y;
            btn_0.Left = 60;
            btn_0.Show();
            eingabePanel.Controls.Add(btn_0);
            Button btn_berechnen = new InputButton(this, "Berechnen", 100);
            btn_berechnen.Top = y;
            btn_berechnen.Left = 110;
            btn_berechnen.Show();
            eingabePanel.Controls.Add(btn_berechnen);

            eingabePanel.Height = y + 80;
        }

        public void input_clicked(string key)
        {
            foreach (Control c in funktionsPanel.Controls)
            {
                if (c.Focused && c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    int cursorPos = tb.SelectionStart;

                    if (key == "<-")
                    {
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
                        return;
                    }

                    tb.Text = tb.Text.Insert(cursorPos, key);
                    tb.SelectionStart = cursorPos + 1;
                }
            }
        }

        public void buildUi(RechnermodulBibliothek.UIBuilderInterface uiBuilder)
        {
            this.buildInputPanel();

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
                    tb.Top = y;
                    tb.Show();
                    funktionsPanel.Controls.Add(tb);
                    y += 25;
                }
                else
                {
                    Button btn_add = new Button();
                    btn_add.Text = "Add";
                    Button btn_rm = new Button();
                    btn_rm.Text = "Del";

                    btn_add.Left = 0;
                    btn_add.Top = y;
                    btn_add.Width = 50;
                    btn_add.Click += (sender, e) => this.add_clicked(element.getKey(), element.getValidator());
                    btn_rm.Left = 50;
                    btn_rm.Top = y;
                    btn_rm.Width = 50;
                    btn_rm.Click += (sender, e) => this.del_clicked(element.getKey());

                    btn_add.Show();
                    btn_rm.Show();

                    TextBox tb_new = new TextBox();
                    tb_new.Name = "tb_" + element.getKey();
                    tb_new.Top = y + 30;
                    tb_new.Show();

                    ListBox lb = new ListBox();
                    lb.Name = "lb_" + element.getKey();
                    lb.Top = y;
                    lb.Left = 100;
                    lb.Height = 100;
                    y += 100;

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

        public void validate_input(RechnermodulBibliothek.CheckCallback cb, ErrorProvider ep)
        {
        }

        public void add_clicked(string key, RechnermodulBibliothek.CheckCallback cb)
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
                string err;
                if (cb == null || ((err = cb(tb.Text)) == null))
                {
                    lb.Items.Add(tb.Text);

                    return;
                }
                MessageBox.Show(err);
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
                    values.Add(tb.Name.Replace("tb_", ""), tb.Text);
                }
                else if (c.Name.StartsWith("lb_"))
                {
                    ListBox lb = (ListBox)c;
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
    }
}
