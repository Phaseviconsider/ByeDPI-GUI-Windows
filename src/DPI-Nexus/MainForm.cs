using System;
using System.Windows.Forms;

namespace DPINexus
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ByeDPI запущен в тестовом режиме!", "DPI-Nexus", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
