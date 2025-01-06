using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Introduction inro = new Introduction();
            inro.TopMost = true;
            inro.Show();
            this.Hide();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            /*Introduction inro = new Introduction();
            inro.Show();
            this.Hide();*/
        }
    }
}
