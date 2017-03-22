using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Build_Machine
{
    public partial class Build_Form : Form
    {
        public Build_Form()
        {
            InitializeComponent();
        }

        private void Build_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hey Build");
            Console.ReadLine();
        }
    }
}
