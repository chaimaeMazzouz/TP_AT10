using System;
using System.Windows.Forms;

namespace AT10
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        void Changer_Form(Form NewForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            NewForm.MdiParent = this;
            NewForm.Dock = DockStyle.Fill;
            NewForm.Show();
        }
        private void comptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Comptes());
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Client());

        }

        private void mouvementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Mouvement());
        }
    }
}
