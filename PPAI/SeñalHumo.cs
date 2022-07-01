using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI
{
    public partial class SeñalHumo : Form
    {
        public SeñalHumo()
        {
            InitializeComponent();
        }

        private void SeñalHumo_Load(object sender, EventArgs e)
        {
            gifHumo.Image = Image.FromFile("Resources/humo.gif");
        }

        private void btnSeñalesHumo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
