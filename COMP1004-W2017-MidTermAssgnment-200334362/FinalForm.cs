﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200334362
{
    public partial class FinalForm : Form
    {
        public JobForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fina data of your process is send to printer....");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
