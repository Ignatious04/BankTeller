using BankTeller.User_Interface_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankTeller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            BalanceForm balanceForm = new BalanceForm(this);
            balanceForm.Show();
            this.Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(this);
            depositForm.Show();
            this.Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm(this);
            withdrawForm.Show();
            this.Hide();
        }

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            ViewTransactionsForm viewTransactionsForm = new ViewTransactionsForm(this);
            viewTransactionsForm.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
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
