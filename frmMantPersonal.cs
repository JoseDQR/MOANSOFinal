﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoMOANSOT2
{
    public partial class frmMantPersonal : Form
    {
        public frmMantPersonal()
        {
            InitializeComponent();
        }

        private void btnNuevoPer_Click(object sender, EventArgs e)
        {
            Form formNuevoPer = new NuevoPersonal();
            formNuevoPer.Show();
        }
    }
}
