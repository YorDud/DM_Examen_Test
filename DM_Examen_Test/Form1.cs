﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Examen_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.name". При необходимости она может быть перемещена или удалена.
            this.nameTableAdapter.Fill(this.testDataSet.name);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameTableAdapter.Update(this.testDataSet.name);
        }
    }
}
