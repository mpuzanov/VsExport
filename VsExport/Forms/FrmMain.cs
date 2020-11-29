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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemIvc_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is FrmIvc)
                    return;
            }
            FrmIvc frmIvc = new FrmIvc();
            frmIvc.MdiParent = this;
            frmIvc.Show();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void MenuItemCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuItemTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuItemTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void MenuItemCloseWindow_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void MenuItemCloseAll_Click(object sender, EventArgs e)
        {
            Form[] forms = MdiChildren;
            foreach (Form f in forms)
                f.Close();
        }

        private void MenuItemHelp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "help\\Квартплата.chm");
        }

        private void NotifyMenuItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            notifyIcon1.Text = this.Text;
            //notifyIcon1.Click += notifyIcon1_Click;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
