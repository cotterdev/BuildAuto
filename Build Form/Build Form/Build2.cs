using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Build_Form
{
    public partial class Build : Form
    {
        public Build()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            string targetPath = @"C:\_Target";

            //Read each line of the config file into an array
            //string[] sourceTargetFileName = System.IO.File.ReadAllLines(@"C:\_Config\AvitAutoConfig.txt");
            string[] sourceTargetFileName = System.IO.File.ReadAllLines(@"C:\_Config\AvitAutoConfig.txt");

            // Create a new target folder, only if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location
            for (int i = 0; i < sourceTargetFileName.Length; i=i+2)
            {
                if (sourceTargetFileName[i+1] != null)  //Probably don't need this if statement, was orig setup for when we had unused array elements.  Now we shouldn't have unused elements.
                {
                    sourceTargetFileName[i] = sourceTargetFileName[i].Remove(0, 7);
                    sourceTargetFileName[i+1] = sourceTargetFileName[i+1].Remove(0, 7);
                    System.IO.File.Copy(sourceTargetFileName[i], sourceTargetFileName[i+1], true); //true = // overwrite the destination file if it already exists.
                }
            }//End for loop

            //Notify user copy is complete
            Console.WriteLine("Copy is complete!");
        }//End Build_Click


        private void BtnTest_Click(object sender, EventArgs e)
        {
            string[] sourceTargetFileName = System.IO.File.ReadAllLines(@"C:\_Config\AvitAutoConfig.txt");

            string removeString = sourceTargetFileName[0].Remove(0, 7);
            Console.WriteLine("Filename: {0}", removeString);
        }//End Test_Click


        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//End Quit_Click
    }
}
