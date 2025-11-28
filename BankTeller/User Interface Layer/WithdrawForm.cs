using BankTeller.Business_Logic_Layer;
using BankTeller.Entity_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankTeller.User_Interface_Layer
{
    public partial class WithdrawForm : Form
    {
        private readonly Computation _computation;
        private MainForm _parentForm;

        public WithdrawForm(MainForm parentForm)
        {
            InitializeComponent();
            _computation = new Computation();
            _parentForm = parentForm;
            lblMessage.Text = string.Empty;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNum.Text))
            {
                decimal withdrawAmount = Convert.ToDecimal(txtNum.Text);

                if (withdrawAmount > 0)
                {
                    if (AccountEntity.Balance > withdrawAmount)
                    {
                        _computation.Withdraw(withdrawAmount);

                        DialogResult result = MessageBox.Show("Withdraw transaction successful. Do you wish to do another transaction?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            this.Close();
                            _parentForm.Show();
                        }
                        else
                        {
                            result = MessageBox.Show("Are you sure? Doing so will immediately close the program.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    else
                    {
                        lblMessage.Text = "Insufficient Balance.";
                    }
                }
                else
                {
                    lblMessage.Text = "Please enter a valid amount.";
                }
            }
            else
            {
                lblMessage.Text = "Please enter the desired amount.";
            }    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            _parentForm.Show();
        }
    }
}
