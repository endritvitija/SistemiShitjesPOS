﻿using System;
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
using SistemiShitjesPOS.EntityLayer;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_Dashboards : UserControl
    {
        public UC_Dashboards()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.lblDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy \n     hh:mm");
            lblDateTime.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {




        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panCmimi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void dgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgSearch.DataSource = blItems.SearchById(int.Parse(txtKerko.Text));
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Search with Barcode ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnShto_Click(object sender, EventArgs e)
        {

            

            foreach (DataGridViewRow row in dgSearch.Rows)
            {

                dgListOfItems.Rows.Add(row.Cells[4].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString());

                
            }

            

            double sum = 0;
            double a = 0.16;
            for (int i = 0; i < dgListOfItems.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgListOfItems.Rows[i].Cells[5].Value);
            }

            lblNoTax.Text = Convert.ToString(sum - (a * sum));
            lblTax.Text = Convert.ToString(a * sum);
            label4.Text = sum.ToString();






        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgListOfItems.Rows.Clear();
            label4.Text = "00.0";
            lblNoTax.Text = "00.0";
            lblTax.Text = "00.0";
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHereQuantity_Click(object sender, EventArgs e)
        {


            txtQuantity.Text = dgListOfItems.CurrentRow.Cells[6].Value.ToString();
            
            
        }
    }
}
