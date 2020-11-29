using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VsExport
{
    public partial class FrmLogin : Form
    {
        public bool LoginSuccess = false;
        public string Server { get; set; }
        public string Database { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            db.DBConnection.CreateDBConnection(tbServer.Text, tbDB.Text, tbLogin.Text, tbPswd.Text);

            try
            {
                db.DBConnection.SqlConnect.Open();
                LoginSuccess = true;
                db.DBConnection.SqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Not connected, error: {ex.Message}");
            }

            Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            tbServer.Text = Server;
            tbDB.Text = Database;
            tbLogin.Text = Login;
            tbPswd.Text = Password;
        }
    }
}
