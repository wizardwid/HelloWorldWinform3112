﻿using HelloWorldWinform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWindowForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "쾅!";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 헬로월드정보ToolStriptMenuitem_Click(Object sender, EventArgs e)
        {
            Form formAbout1 = new FormAbout();
            formAbout1.Text = "모달창(Modal)";
            formAbout1.ShowDialog();
            Form formAbout2 = new FormAbout();
            formAbout2.Text = "모달리스창(Medeless)";
            formAbout2.ShowDialog();
        }
    }
}