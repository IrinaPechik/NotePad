﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_3
{
    public partial class NewWindow : Form1
    {
        public NewWindow()
        {
            InitializeComponent();
            wasCreatedSecondForm = 1;
            countOfNewForms++;
        }
    }
}
