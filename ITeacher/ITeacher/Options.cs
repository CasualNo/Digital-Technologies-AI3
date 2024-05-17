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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Location = this.Location;
            this.Owner.Size = this.Size;
            this.Owner.Show();
            this.Close();
        }
    }
}
