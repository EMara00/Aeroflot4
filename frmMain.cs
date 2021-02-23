using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Aeroport
{
    public partial class frmMain : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBaseAeport.mdf;Integrated Security=True";
        string sql = "SELECT * FROM Information";
        SqlConnection sqlConnection;

        public frmMain()
        {
            InitializeComponent();

            dataGridView1.DataSource = GetPass.getNotes(UserId.GlobalUserId);
        }

        private void Form_Data_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dataBaseAeportDataSet21.Information' table. You can move, or remove it, as needed.
            //this.informationTableAdapter2.Fill(this.dataBaseAeportDataSet21.Information);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseAeportDataSet11.Information". При необходимости она может быть перемещена или удалена.
            //this.informationTableAdapter.Fill(this.dataBaseAeportDataSet11.Information);



            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.DataSource = GetPass.getNotes(UserId.GlobalUserId);

        }

        //добавляет пользователя
        private void Add_Click(object sender, EventArgs e)
        {
            //DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            //ds.Tables[0].Rows.Add(row);

            frmCreate af = new frmCreate(this);
            af.Show();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                PassDelete();


            }
            
        }

        public void PassDelete()
        {
            //удаляет выделенный столбец
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DeletePass del = new DeletePass();
                del.DeleteNotes(textBox1.Text);
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
                MessageBox.Show("Введите ID!");
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            //frmFilter fi = new frmFilter();
            //fi.Show();

           



            if (textBox3.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Familia like '{0}%'", textBox3.Text);                 
            }
            else if (textBox2.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Name like '{0}%'", textBox2.Text);
            }
            else if (textBox7.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Compania like '{0}%'", textBox7.Text);
            }
            else if (textBox10.Text != "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("DateTime like '{0}%'", textBox10.Text);
            }

            else
                MessageBox.Show("Введите данные!");

            textBox4.Text = dataGridView1.RowCount.ToString();

        }
    }
}
