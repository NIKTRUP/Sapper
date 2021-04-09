using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapper
{
    public partial class Losing : Form
    {
        public Losing()
        {
            InitializeComponent();
            
        }
        private void Losing_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
