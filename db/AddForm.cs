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
    public partial class AddForm : Form
    {
        private object tbMail;

        public AddForm()
        {
            InitializeComponent();
        }

        // Кнопка закрытия окна
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Кнопка для добавления записи в БД
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 main = Owner as Form1;
            if(main !=null)
            {
                DataRow nRow = main.testDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                nRow[2] = tbPhone.Text;
              
                main.testDataSet.Tables[0].Rows.Add(nRow);
                main.contactsTableAdapter.Update(main.testDataSet.contacts);
                main.testDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
                tbPhone.Text = "";
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
