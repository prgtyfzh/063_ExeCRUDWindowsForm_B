using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExeCRUDWindowsForm
{
    public partial class Form2 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;

        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rRQDataSet.Hoshi' table. You can move, or remove it, as needed.
            this.hoshiTableAdapter.Fill(this.rRQDataSet.Hoshi);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            comboBox1.Items.Add("Indonesia");
            comboBox2.Items.Add("Head Coach");
            comboBox1.Items.Add("Brazil");
            comboBox2.Items.Add("Coach");
            comboBox2.Items.Add("Player (C)");
            comboBox2.Items.Add("Player");
            textBox5.Enabled = false;
            button2.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            textBox5.Enabled = true;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
            dt = rRQDataSet.Tables["Hoshi"];

            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = rRQDataSet.Tables["Hoshi"];
            dr = dt.NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = textBox4.Text;
            dr[4] = comboBox1.SelectedItem;
            dr[5] = comboBox2.SelectedItem;
            dr[6] = textBox5.Text;
            dt.Rows.Add(dr);
            hoshiTableAdapter.Update(rRQDataSet);
            textBox1.Text = System.Convert.ToString(dr[0]);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            textBox5.Enabled = false;
            this.hoshiTableAdapter.Fill(this.rRQDataSet.Hoshi);
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string code;
            code = textBox1.Text;
            dr = rRQDataSet.Tables["Hoshi"].Rows.Find(code);
            dr.Delete();
            hoshiTableAdapter.Update(rRQDataSet);
        }
    }
}
