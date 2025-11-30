using BankTeller.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankTeller.User_Interface_Layer
{
    public partial class ViewTransactionsForm : Form
    {
        private MainForm _parentForm;

        public ViewTransactionsForm(MainForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            dgvTransactions.AutoGenerateColumns = false;

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Time",
                DataPropertyName = "TimeStamp",
                Name = "TimeStamp",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Transaction Type",
                DataPropertyName = "TransactionType",
                Name = "TransactionType",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Amount",
                DataPropertyName = "Amount",
                Name = "Amount",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void ViewTransactionsForm_Load(object sender, EventArgs e)
        {
            dgvTransactions.DataSource = TransactionLog.TransactionLogs;
            dgvTransactions.Columns["Amount"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
            dgvTransactions.Columns["Amount"].DefaultCellStyle.Format = "C2";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
            _parentForm.Show();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? Doing so will immediately close the program.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
