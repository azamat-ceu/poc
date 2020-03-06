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



namespace WindowsFormsApp3
{
    
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=303-14;Initial Catalog=azam;Integrated security=true;");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand($"Select [FIO_manager] From manager where Login_manager = '{textBox1.Text}' and Password = '{textBox2.Text}'", con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                MessageBox.Show("Вход успешно выполнен");
                Form2 f = new Form2();
                f.Show();
                this.Hide();
                dr.Close();
            }
            else
                MessageBox.Show("Отойди");
            con.Close();
            


    }

    private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
