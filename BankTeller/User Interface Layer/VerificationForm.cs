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

namespace BankTeller
{
    public partial class VerificationForm : Form
    {
        private readonly Validation _validation;
        private int _attempts = 3;

        public VerificationForm()
        {
            InitializeComponent();
            _validation = new Validation();
            lblMessage.Text = string.Empty;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!txtPin.Text.Equals(""))
            {
                int pin = Convert.ToInt32(txtPin.Text);
                bool isValid = _validation.ValidatePIN(pin);

                if (isValid)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    if (_attempts > 1)
                    {
                        _attempts--;
                        lblMessage.Text = "Invalid PIN (You have " + _attempts + " attempt(s)).";
                    }
                    else
                    {
                        lblMessage.Text = "Sorry, we cannot process your request at the moment.";
                    }
                }
            }
            else
            {
                lblMessage.Text = "Please enter your pin.";
            }
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
