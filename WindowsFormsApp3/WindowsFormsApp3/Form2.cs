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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=303-14;Initial Catalog=azam;Integrated security=true;");//подключение БД
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public int id;
        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand($"Select * From coeefs, grade where coeefs.id = '{id}' and coeefs.id = grade.id", con);//поиск коэффициентов
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                textBox1.Text = dr["Junior"].ToString();
                textBox2.Text = dr["Middle"].ToString();
                textBox3.Text = dr["Senior"].ToString();
                textBox4.Text = dr["coef_analiz"].ToString();
                textBox5.Text = dr["coef_device"].ToString();
                textBox6.Text = dr["coef_service"].ToString();
                textBox7.Text = dr["coef_time"].ToString();
                textBox8.Text = dr["coef_complexity"].ToString();
                textBox9.Text = dr["coef_money"].ToString();
                dr.Close();

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
