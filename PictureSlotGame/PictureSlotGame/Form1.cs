using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureSlotGame
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private Image[] wheelImahe = { Resources.apple0, Resources.Banana, Resource.grapes };
        private 

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
