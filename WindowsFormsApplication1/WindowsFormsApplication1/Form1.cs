﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Админ")
            {
                if (textBox2.Text == "1234567")
                {

                    if (comboBox1.Text == "Администратор")
                    {
                        Form2 frmMain = new Form2();
                        frmMain.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                if (textBox1.Text == "Пользователь")
                {
                    if (textBox2.Text == "987654321")
                    {

                        if (comboBox1.Text == "Пользователь")
                        {
                            Form2 frmMain = new Form2();
                            frmMain.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
            

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация frmMain = new Регистрация();
            frmMain.Show();
            this.Hide();
        }
    }
}
