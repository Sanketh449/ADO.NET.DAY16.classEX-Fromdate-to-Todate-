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
using System.Configuration;

namespace ADO.NET.DAY16.classEX
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["master"].ConnectionString);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["master"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_DisplayPayDate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FromDate", DtpFromDate.Value);
                    cmd.Parameters.AddWithValue("@ToDate", DtpToDate.Value);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    GridEmployee.DataSource = dt;

                }
            }
        }
    }
}
