﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WorkFlowDesigner
{
    public partial class AddAtribute : DevExpress.XtraEditors.XtraForm
    {
        public AddAtribute()
        {
            InitializeComponent();
        }
        public AddAtribute(Attribute a)
        {
            this.atribute = a;
            InitializeComponent();
        }

    }
}