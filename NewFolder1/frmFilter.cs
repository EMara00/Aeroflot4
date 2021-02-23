using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4
{
    public partial class frmFilter : Form
    {
        FilterContr filter_controler;
        LogExpFactory factory;

        Label[] names;
        TextBox[] textBoxs;
        CheckBox[] checkBoxs;
        RadioButton[,] radioButtons;
        Panel[] panelButtons;
        List<Field> fields;

        public frmFilter(FilterContr new_filter_controler)
        {
            InitializeComponent();
            filter_controler = new_filter_controler;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fields = FieldTypeCol.get_value();
            int count = fields.Count;
            int[] x_pos = { 10, 130, 250, 300 };
            int y_pos = 10;

            names = new Label[count];
            textBoxs = new TextBox[count];
            checkBoxs = new CheckBox[count];
            radioButtons = new RadioButton[count, 4];
            panelButtons = new Panel[count];

            for (int i = 0; i < count; ++i)
            {
                names[i] = new Label();
                textBoxs[i] = new TextBox();
                checkBoxs[i] = new CheckBox();
                for (int t = 0; t < 4; ++t) radioButtons[i, t] = new RadioButton();
                panelButtons[i] = new Panel();
            }

            for (int i = 0; i < count; ++i)
            {
                y_pos += 30;

                int index = 0;

                names[i].Text = fields[i].GetName();
                names[i].Left = x_pos[index++];
                names[i].Top = y_pos;
                names[i].Name = fields[i].TypeField();
                names[i].Width = 120;
                textBoxs[i].Width = 100;
                textBoxs[i].Left = x_pos[index++];
                textBoxs[i].Top = y_pos;
                checkBoxs[i].Text = "Нет";
                checkBoxs[i].Left = x_pos[index++];
                checkBoxs[i].Top = y_pos;
                checkBoxs[i].Width = 50;
                checkBoxs[i].Checked = true;


                panelButtons[i].Left = 300;
                panelButtons[i].Top = y_pos;
                panelButtons[i].Height = 30;
                panelButtons[i].Width = 400;
                radioButtons[i, 0].Text = "=";
                radioButtons[i, 0].Left = 10;
                radioButtons[i, 0].Top = 0;
                radioButtons[i, 0].Width = 50;
                radioButtons[i, 1].Text = "!=";
                radioButtons[i, 1].Left = 60;
                radioButtons[i, 1].Top = 0;
                radioButtons[i, 1].Width = 50;
                radioButtons[i, 2].Left = 110;
                radioButtons[i, 2].Top = 0;
                radioButtons[i, 2].Width = 100;
                radioButtons[i, 3].Left = 220;
                radioButtons[i, 3].Top = 0;
                radioButtons[i, 3].Width = 100;

                if (fields[i].TypeField() == "string")
                {
                    radioButtons[i, 2].Text = "Содержит";
                    radioButtons[i, 3].Text = "Не содержит";
                }
                else if (fields[i].TypeField() == "date" || fields[i].TypeField() == "int")
                {
                    radioButtons[i, 2].Text = ">";
                    radioButtons[i, 3].Text = "<";
                }
            }

            for (int k = 0; k < count; ++k)
            {
                this.Controls.Add(names[k]);
                this.Controls.Add(textBoxs[k]);
                this.Controls.Add(checkBoxs[k]);
                for (int i = 0; i < 4; i++) panelButtons[k].Controls.Add(radioButtons[k, i]);
                this.Controls.Add(panelButtons[k]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            factory = new LogExpFactory();
            int n_fields = FieldTypeCol.GetSize();

            for (int i = 0; i < n_fields; ++i)
            {
                bool[] mark = new bool[4];
                int n_radio_but = -1;

                for (int k = 0; k < 4; ++k)
                {
                    mark[k] = radioButtons[i, k].Checked;
                    if (mark[k]) n_radio_but = k + 1;
                }

                if (checkBoxs[i].Checked == false && (n_radio_but != -1))
                    factory.add_filter(names[i].Text, textBoxs[i].Text, names[i].Name, n_radio_but);
            }
            filter_controler.sort(factory.get_filters());
            this.Close();
        }
    }
}