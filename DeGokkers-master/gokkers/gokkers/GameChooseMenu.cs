using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gokkers
{
    public partial class GameChooseMenu : Form
    {
        public GameChooseMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.SetNextForm(new Form3());
            this.Close();
        }

        private void simulatedButton_Click(object sender, EventArgs e)
        {
            Program.SetNextForm(new Form2());
            this.Close();
        }
    }
}
