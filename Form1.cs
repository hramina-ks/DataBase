using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase.Properties;
using System.Data.OleDb;

namespace DataBase
{
    public partial class MainForm : Form
    {
        public static string connectionString;
        public static OleDbConnection database = new OleDbConnection(connectionString);
        public string SQLRequestText;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа предназначена для работы с БД.\nЕе разработал студент курса ЕШКО: Храмина Ксения Сергеевна.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа предназначена для работы с БД.\nЕе разработал студент курса ЕШКО: Храмина Ксения Сергеевна.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            LoadDataGrid(datGridSQLResult, tbRequest.Text);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Kristall\\source\\repos\\DataBase\\" + tbDatSource.Text;
            comboBox1.Items.Clear();
            OleDbConnection dbCon = new OleDbConnection(connectionString);
            dbCon.Open();
            DataTable tbls = dbCon.GetSchema("Tables", new string[] { null, null, null, "TABLE" }); //список всех таблиц
            foreach (DataRow row in tbls.Rows)
            {
                string TableName = row["TABLE_NAME"].ToString();
                comboBox1.Items.Add(TableName);
            }
            dbCon.Close();
            comboBox1.Enabled = true;
            btnConnect.Enabled = false;
            btnRequest.Enabled = true;
            tbRequest.Enabled = true;
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LoadDataGrid(DataGridView MyDataGridView, string sqlQueryString)
        {
            try
            {
                OleDbDataAdapter dA = new OleDbDataAdapter(sqlQueryString, connectionString);
                DataSet ds = new DataSet();
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    dA.Fill(ds);
                }
                MyDataGridView.DataSource = ds.Tables[0].DefaultView;
                MyDataGridView.ReadOnly = true;
                for (int i = 0; i < MyDataGridView.Columns.Count; i++)
                {
                    MyDataGridView.AutoResizeColumn(i);
                }
                
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_EnabledChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            SQLRequestText = "SELECT * FROM [" + comboBox1.SelectedItem.ToString() + "]";
            tbRequest.Text = SQLRequestText;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SQLRequestText = "SELECT * FROM [" + comboBox1.SelectedItem.ToString() + "]";
            tbRequest.Text = SQLRequestText;

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbRequest.Text = "";
        }
    }
}
