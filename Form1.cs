using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace ADO.NET_WinForm_HW1
{
    public partial class Form1 : Form
    {
        public string ConStr { get; set; }
        public SqlConnection connection { get; set; }
        public Form1()
        {
            ConStr = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=HW1_Fruits_Vegetables;Integrated Security = true;";
            connection = new SqlConnection(ConStr);
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connection.Open();
            labelState.Text = "State: " + connection.State.ToString();
        }
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            connection.Close();
            labelState.Text = "State: " + connection.State.ToString();
        }

        private void RunQuery(string query)
        {
            DataTable data = new DataTable();

            SqlCommand command = new SqlCommand(query, connection);

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(data);
            }

            dataGV.DataSource = data;
        }

        private void task_3_1_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT * FROM FruitsVegetables");
        }

        private void task_3_2_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT Name FROM FruitsVegetables");
        }

        private void task_3_3_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT DISTINCT Color FROM FruitsVegetables");
        }

        private void task_3_4_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT MAX(Calories) AS 'Max Calories' FROM FruitsVegetables");
        }

        private void task_3_5_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT MIN(Calories) AS 'Min Calories' FROM FruitsVegetables");
        }

        private void task_3_6_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT AVG(Calories) AS 'Avg Calories' FROM FruitsVegetables");
        }

        private void task_4_1_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT COUNT(*) AS 'Num of Vegetables' FROM FruitsVegetables WHERE isFruit = 0");
        }

        private void task_4_2_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT COUNT(*) AS 'Num of Fruits' FROM FruitsVegetables WHERE isFruit = 1");
        }

        private void task_4_3_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT COUNT(*) AS 'Num of Green' FROM FruitsVegetables WHERE Color = 'Green'");
        }

        private void task_4_4_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT COUNT(*), Color FROM FruitsVegetables GROUP BY Color");
        }

        private void task_4_5_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT * FROM FruitsVegetables WHERE Calories<100");
        }

        private void task_4_6_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT * FROM FruitsVegetables WHERE Calories>100");
        }

        private void task_4_7_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT * FROM FruitsVegetables WHERE Calories BETWEEN 90 AND 110");
        }

        private void task_4_8_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT * FROM FruitsVegetables WHERE Color IN ('Red', 'Yellow')");
        }
    }
}
