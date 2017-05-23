﻿using SistemiShitjesPOS.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.BusinessLayer;


namespace SistemiShitjesPOS.UI
{
    public partial class UC_Items : UserControl
    {
        public UC_Items()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            try
            {
                dgListOfItems.DataSource = blItems.GetAll();
            }
            catch (Exception)
            {

                MessageBox.Show("Nuk eshte ne rregull");
            }
          


        }

        private void btnNewItems_Click(object sender, EventArgs e)
        {
            UC_NewItems newItems = new UC_NewItems();
            panNew.Controls.Clear();
            panNew.Controls.Add(newItems);
        }

        private void txtSearchItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchItems_Click(object sender, EventArgs e)
        {
            
            try
            {
                dgListOfItems.DataSource = blItems.SearchById(int.Parse(txtSearchItems.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Shkruaj Barkodin Perseri");
            }
            

        }   

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearchItems_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchItems.Clear();
        }

        private void dgListOfItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dgListOfItems_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dataValue = dgListOfItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            UC_UpdateItems u = new UC_UpdateItems();


            panNew.Controls.Clear();
            panNew.Controls.Add(u);
           


        }

        private void dgListOfItems_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panSearchItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
