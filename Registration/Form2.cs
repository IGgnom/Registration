using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form2 : Form
    {
        private static readonly string ConnectionString = @"Data Source = IGGNOMPC\SQLEXPRESS; Initial Catalog = Регистрация; Integrated Security = True";

        private static readonly SqlConnection Connection = new SqlConnection(ConnectionString);

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.участникиTableAdapter1.Fill(this.регистрацияDataSet1.Участники);
            //this.участникиTableAdapter.Fill(this.регистрацияDataSet.Участники);   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.Open();

            Form1 Frm1 = new Form1();

            string CommandString = "SELECT [ФИО участника конференции] FROM [Участники]";

            SqlCommand Command = new SqlCommand(CommandString, Connection);

            SqlDataReader Reader = Command.ExecuteReader();

            List<string> Data = new List<string>();

            while (Reader.Read())
                Data.Add(Reader["ФИО участника конференции"].ToString());

            Connection.Close();

            for (int i = 0; i < Data.ToArray().Length; i++)
                if (Data[i].Contains(textBox1.Text))
                    Frm1.Search = Data[i];

            Reader.Close();
            //Frm1.Hide();
            //Frm1.Show();
            Frm1.label6.Hide();
            Frm1.label6.Show();
        }
    }
}
