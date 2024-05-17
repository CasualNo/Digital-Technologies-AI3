using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITeacher
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void btnLvls_Click(object sender, EventArgs e)
        {
            LvlSelect lvl = new LvlSelect();
            lvl.Owner = this;
            lvl.StartPosition = FormStartPosition.Manual;
            lvl.Location = this.Location;
            lvl.Size = this.Size;
            lvl.Show();
            this.Hide();
        }

        private void btnOpts_Click(object sender, EventArgs e)
        {
            Options opt = new Options();
            opt.Owner = this;
            opt.StartPosition = FormStartPosition.Manual;
            opt.Location = this.Location;
            opt.Size = this.Size;
            opt.Show();
            this.Hide();
        }
    }
}
