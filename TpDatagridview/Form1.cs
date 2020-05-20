using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpDatagridview
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        MaskedTextBox mt;
        private void Form1_Load(object sender, EventArgs e)
        {
            mt = new MaskedTextBox();
            mt.Mask = "##/##/####";
            dataGridView1.Columns.Add("nom", "Le nom ");
            dataGridView1.Columns.Add("prenom", "Le Prenom ");
            dataGridView1.Columns.Add("Naissance", "Date_Naissance");
            dataGridView1.Columns.Add("age", "Age");
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        
        private void butt_Remplir_Click(object sender, EventArgs e)
        {
          // string[] tab = dateTimePicker1.Text.Split('/');
           //int age = DateTime.Now.Year - int.Parse(tab[2]);
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text,dateTimePicker1.Text );
              textBox1.Clear();
              textBox2.Text = "";
                
              
        }

        private void butt_Supp_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(index);
            
        }

        private void butt_Vider_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void buttQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void butt_Modifier_Click(object sender, EventArgs e)
        {
            

            string[] tab = dateTimePicker1.Text.Split('/');
            //int age = DateTime.Now.Year - int.Parse(tab[2]);
            dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView1.CurrentRow.Cells[2].Value = dateTimePicker1.Text;
            //dataGridView1.CurrentRow.Cells[3].Value = age;
          
        }
         
        private void butt_Trier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns[3].HeaderCell.SortGlyphDirection == SortOrder.Ascending)
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
            else
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        
    }
}
