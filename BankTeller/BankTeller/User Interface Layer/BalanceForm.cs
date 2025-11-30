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
    public partial class BalanceForm : Form
    {
        private MainForm _parentForm;

        public BalanceForm(MainForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            lblBalance.Text = AccountEntity.Balance.ToString();
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
