﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Laboratory_Excercise
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void bntUpload_Click(object sender, EventArgs e)
        {
            lvShowText.Items.Clear();
            MessageBox.Show("Successfully Uploaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
