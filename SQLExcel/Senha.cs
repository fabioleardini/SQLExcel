﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLExcel
{
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (password.Text.ToString() == "admin") //"")
                {
                    this.Hide();

                    ExportXLS form = new ExportXLS(this);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Senha Inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Senha_Activated(object sender, EventArgs e)
        {
            password.Focus();
        }
    }
}
