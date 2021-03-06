﻿using System;
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
            //string[] fileName = new string[100];
            //= "Test1.txt"
            string sourcePath = @"C:\_Source";
            string targetPath = @"C:\_Target";

            //fileName[0] = "Test1.txt";
            //fileName[1] = "Test3.txt";
            //Read each line of the config file into an array
            string[] fileName = System.IO.File.ReadAllLines(@"C:\_Config\AvitAutoConfig.txt");
            Console.WriteLine("File: {0}", fileName[0]);
            Console.WriteLine("File: {0}", fileName[1]);


            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            foreach (string sFile in fileName)
            {
                if (sFile != null)
                {
                    //string sourceFile = System.IO.Path.Combine(sourcePath, sFile);
                    //string destFile = System.IO.Path.Combine(targetPath, sFile);
                    //System.IO.File.Copy(sourceFile, destFile, true); //true = // overwrite the destination file if it already exists.
                    string destFile = System.IO.Path.Combine(targetPath, "Test1.txt");
                    System.IO.File.Copy(sFile, destFile, true); //true = // overwrite the destination file if it already exists.
                    Console.WriteLine("Copied {0}", sFile);
                }                
            }//End foreach


            //Notify user copy is complete
            Console.WriteLine("Copy is complete!");
            Console.ReadLine();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
