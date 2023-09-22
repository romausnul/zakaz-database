using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.contactsTableAdapter.Fill(this.testDataSet.contacts);

        }

      
        private void SaveButton_Click(object sender, EventArgs e)
        {
            contactsTableAdapter.Update(testDataSet);
        }

 
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("НЕ НАДО ДЯДЯ?", "УААААААААА", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }

   
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }


        

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contactsTableAdapter.Update(testDataSet);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm
            {
                Owner = this
            };
            af.Show();
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm
            {
                Owner = this
            };
            sf.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About af = new About
            {
                Owner = this
            };
            af.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
