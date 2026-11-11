using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_csharp.Views
{
    public partial class FormLogin : Form
    {
        string konfig = "server=localhost;user=root;password=;database=db_pp_sekolah_xii";
        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = new System.Windows.Forms.Button();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterPetugas FormRegisterPetugas = new FormRegisterPetugas();
            FormRegisterPetugas.Show();

            FormLogin nyumput = new FormLogin();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

           
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            else
            {

            }
            FormDashboard FormDashboard = new FormDashboard();
            FormDashboard.Show();
            FormRegisterPetugas nyumput = new FormRegisterPetugas();
            this.Hide();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
