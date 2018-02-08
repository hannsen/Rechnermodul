using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversellesEingabeModul
{
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
                return this.values[key];
            }

            string[] RechnermodulBibliothek.UserDataInterface.getStringArray(string key)
            {
                return this.arrays[key];
            }
        }

        public universelleseingabemodul()
        {
            InitializeComponent();
        }

        public void buildUi(RechnermodulBibliothek.UIBuilderInterface uiBuilder)
        {
            this.elements = uiBuilder.getUIElements();

            int y = 0;

            for (int i = 0; i < this.elements.Length;i++ )
            {
                RechnermodulBibliothek.UIElement element = this.elements[i];
                Label label = new Label();
                label.Text = element.getDescription();
                label.Name = "l_" + element.getKey();
                label.AutoSize = true;
                y += 25;
                label.Top = y;
                label.Show();
                panel1.Controls.Add(label);

                if (element.getType() == RechnermodulBibliothek.UIElement.TYPE_SINGLE)
                {
                    TextBox tb = new TextBox();
                    tb.Name = "tb_" + element.getKey();
                    tb.Left = 50;
                    tb.Top = y;
                    tb.Show();
                    panel1.Controls.Add(tb);
                } else
                {
                    y += 25;
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

                    panel1.Controls.Add(btn_add);
                    panel1.Controls.Add(btn_rm);
                    panel1.Controls.Add(tb_new);
                    panel1.Controls.Add(lb);
                }

            }

            panel1.Height = y + 50;
        }

        public void add_clicked(string key, RechnermodulBibliothek.CheckCallback cb)
        {
            ListBox lb = null;
            TextBox tb = null;

            string tb_key = "tb_" + key;
            string lb_key = "lb_" + key;

            foreach (Control c in panel1.Controls)
            {
                if (c.Name.Equals(tb_key))
                {
                    tb = (TextBox) c;
                } else if (c.Name.Equals(lb_key))
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

            foreach (Control c in panel1.Controls)
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

            foreach (Control c in panel1.Controls)
            {
                if (c.Name.StartsWith("tb_"))
                {
                    TextBox tb = (TextBox) c;
                    values.Add(tb.Name.Replace("tb_", ""), tb.Text);
                } else if (c.Name.StartsWith("lb_"))
                {
                    ListBox lb = (ListBox)c;
                    string[] v = new string[lb.Items.Count];
                    for (int i=0;i<lb.Items.Count; i++)
                    {
                        v[i] = (string) lb.Items[i];
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
