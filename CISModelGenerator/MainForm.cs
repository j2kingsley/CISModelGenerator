using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISModelGenerator
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Enables form move when form is clicked and moved
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        //Prevents maximising the window
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MAXIMIZEBOX = 0x00010000;
                var cp = base.CreateParams;
                cp.Style &= ~WS_MAXIMIZEBOX;
                return cp;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (!panel_main.Controls.Contains(DashboardUserControl.Instance))
            {
                panel_main.Controls.Add(DashboardUserControl.Instance);
                DashboardUserControl.Instance.Dock = DockStyle.Fill;
                DashboardUserControl.Instance.BringToFront();
            }
            else
                DashboardUserControl.Instance.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_dashBoard_Click(object sender, EventArgs e)
        {
            panel_left.Height = button_dashBoard.Height;
            panel_left.Top = button_dashBoard.Top;

            if (!panel_main.Controls.Contains(DashboardUserControl.Instance))
            {
                panel_main.Controls.Add(DashboardUserControl.Instance);
                DashboardUserControl.Instance.Dock = DockStyle.Fill;
                DashboardUserControl.Instance.BringToFront();
            }
            else
                DashboardUserControl.Instance.BringToFront();
        }

        private void button_folders_Click(object sender, EventArgs e)
        {
            panel_left.Height = button_folders.Height;
            panel_left.Top = button_folders.Top;

            if(!panel_main.Controls.Contains(foldersControl.Instance))
            {
                panel_main.Controls.Add(foldersControl.Instance);
                foldersControl.Instance.Dock = DockStyle.Fill;
                foldersControl.Instance.BringToFront();
            }
            else
                foldersControl.Instance.BringToFront();
        }

        private void button_security_groups_Click(object sender, EventArgs e)
        {
            panel_left.Height = button_security_groups.Height;
            panel_left.Top = button_security_groups.Top;

            
           if (!panel_main.Controls.Contains(UserControls.SecurityGroupsControl.Instance))
            {
                panel_main.Controls.Add(UserControls.SecurityGroupsControl.Instance);
                UserControls.SecurityGroupsControl.Instance.Dock = DockStyle.Fill;
                UserControls.SecurityGroupsControl.Instance.BringToFront();
            }
            else
                UserControls.SecurityGroupsControl.Instance.BringToFront();
        }

        private void button_minimise_Click(object sender, EventArgs e)
        {            
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_minimise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'm')
                this.WindowState = FormWindowState.Minimized;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
