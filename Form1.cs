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
        public static string connectionString = Properties.Settings.Default.dbConnectionString;
        public static OleDbConnection database = new OleDbConnection(connectionString);
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

        private void MainForm_ForeColorChanged(object sender, EventArgs e)
        {

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

        private void toolStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            LoadDataGrid(datGridDBTables, tbRequest.Text);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //btnConnect.Enabled = false;
            //btnRequest.Enabled = true;
            //tbRequest.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LoadDataGrid(DataGridView MyDataGridView, string sqlQueryString)
        {
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
            MyDataGridView.DataSource = null;
            SQLQuery.Connection = null;
            OleDbDataAdapter dataAdapter = null;
            datGridDBTables.Columns.Clear();
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            MyDataGridView.DataSource = data;
            MyDataGridView.AllowUserToAddRows = false;
            MyDataGridView.ReadOnly = true;
        }
    }
}
