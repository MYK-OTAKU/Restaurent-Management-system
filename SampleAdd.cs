﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        public virtual void BtnSave_Click(object sender, EventArgs e)
        {

        }

        public virtual void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SampleAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
