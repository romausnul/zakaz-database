﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        // Выход из формы
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Обработчик кнопки поиска по записям в БД
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = Owner as Form1;
            if(main !=null)
            {
                for(int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    main.dataGridView1.Rows[1].Selected = false;
                    for(int j = 0; j < main.dataGridView1.ColumnCount; j++)
                        if(main.dataGridView1.Rows[i].Cells[j].Value !=null)
                            if(main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
