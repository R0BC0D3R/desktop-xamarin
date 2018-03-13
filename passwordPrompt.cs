﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurtleWallet
{
    public partial class PasswordPrompt : TurtleWalletForm
    {
        public string WalletPassword
        {
            get;
            set;
        }

        public PasswordPrompt()
        {
            InitializeComponent();

            this.Text = "Turtle Wallet";

            walletPasswordLabel.Text = String.Format("{0} Wallet Password:", System.IO.Path.GetFileNameWithoutExtension(Properties.Settings.Default.walletPath));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Utilities.CloseProgram(e);
        }

        private void PasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (passwordText.Text != "" && passwordText.Text.Length > 6)
                {
                    WalletPassword = passwordText.Text;
                    Utilities.SetDialogResult(this, DialogResult.OK);
                    Utilities.Close(this);
                }
            }
        }

        private void CancelButton_MouseEnter(object sender, EventArgs e)
        {
            var backcolor = Color.FromArgb(44, 44, 44);
            var forcolor = Color.FromArgb(39, 170, 107);
            var currentButton = (Label)sender;
            currentButton.BackColor = backcolor;
            currentButton.ForeColor = forcolor;
        }

        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            var backcolor = Color.FromArgb(52, 52, 52);
            var forcolor = Color.FromArgb(224, 224, 224);
            var currentButton = (Label)sender;
            currentButton.BackColor = backcolor;
            currentButton.ForeColor = forcolor;
        }

        private void CreateWalletButton_MouseEnter(object sender, EventArgs e)
        {
            var backcolor = Color.FromArgb(44, 44, 44);
            var forcolor = Color.FromArgb(39, 170, 107);
            var currentButton = (Label)sender;
            currentButton.BackColor = backcolor;
            currentButton.ForeColor = forcolor;
        }

        private void CreateWalletButton_MouseLeave(object sender, EventArgs e)
        {
            var backcolor = Color.FromArgb(52, 52, 52);
            var forcolor = Color.FromArgb(224, 224, 224);
            var currentButton = (Label)sender;
            currentButton.BackColor = backcolor;
            currentButton.ForeColor = forcolor;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Turtle Wallet Cancel?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Utilities.Close(this);
            }
        }

        private void CreateWalletButton_Click(object sender, EventArgs e)
        {
            WalletPassword = passwordText.Text;
            Utilities.SetDialogResult(this, DialogResult.OK);
            Utilities.Close(this);
        }
    }
}
