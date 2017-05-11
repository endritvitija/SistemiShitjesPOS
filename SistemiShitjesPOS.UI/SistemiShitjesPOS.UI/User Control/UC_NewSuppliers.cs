﻿using SistemiShitjesPOS.EntityLayer;
using SistemiShitjesPOS.BusinessLayer;
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

namespace SistemiShitjesPOS.UI
{
    public partial class UC_NewSuppliers : UserControl
    {
        public UC_NewSuppliers()
        {
            InitializeComponent();
            

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            blSupplier.InsertNewSupplier(new Klienti(rdbAktiv.Checked, txtIdSuppliers.Text, txtEmri.Text, txtEmriFurnitorit.Text, txtMbiemri.Text, txtNrFix.Text, txtAdresa.Text, txtNrTelefonit.Text, txtNrBiznesit.Text, txtWeb.Text, txtEmail.Text, txtpershkrimi.Text));
            //try
            //{

            //    SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
            //    x.Open();
            //    string query = "spShtoFurnizuesin";
            //    SqlCommand da = new SqlCommand(query, x);
            //    da.CommandType = CommandType.StoredProcedure;
            //    da.Parameters.AddWithValue("@_IdKlienti", txtIdSuppliers.Text.ToString());
            //    da.Parameters.AddWithValue("@_Emri", txtEmri.Text.ToString());
            //    da.Parameters.AddWithValue("@_EmriPronarit", txtEmriFurnitorit.Text.ToString());
            //    da.Parameters.AddWithValue("@_MbiemriPronarit", txtMbiemri.Text.ToString());
            //    da.Parameters.AddWithValue("@_Adresa", txtAdresa.Text.ToString());
            //    da.Parameters.AddWithValue("@_NrFix", txtNrFix.Text.ToString());
            //    da.Parameters.AddWithValue("@_Nrtelefonit", txtNrTelefonit.Text.ToString());
            //    da.Parameters.AddWithValue("@_NrBiznesit", txtNrBiznesit.Text.ToString());
            //    da.Parameters.AddWithValue("@_Email", txtEmail.Text.ToString());
            //    da.Parameters.AddWithValue("@_Web", txtWeb.Text.ToString());
            //    da.Parameters.AddWithValue("@_Pershkrimi", txtpershkrimi.Text.ToString());

            //    if (rdbAktiv.Checked)
            //    {
            //        da.Parameters.AddWithValue("@_IsKlient", "1");
            //    }
            //    if (rdbJoAktiv.Checked)
            //    {
            //        da.Parameters.AddWithValue("@_IsKlient", "0");
            //    }
            //    int o = da.ExecuteNonQuery();
            //    MessageBox.Show(" Te dhenat u insertuan", o.ToString());
            //    x.Close();


            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Inserto Te Dhenat Braqul");
            //}
}

        private void UC_NewSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void txtIdSuppliers_MouseDown(object sender, MouseEventArgs e)
        {
            txtIdSuppliers.Clear();
        }

        private void txtEmri_MouseDown(object sender, MouseEventArgs e)
        {
            txtEmri.Clear();
        }

        private void txtEmriFurnitorit_MouseDown(object sender, MouseEventArgs e)
        {
            txtEmriFurnitorit.Clear();
        }

        private void txtMbiemri_MouseDown(object sender, MouseEventArgs e)
        {
            txtMbiemri.Clear();
        }

        private void txtNrTelefonit_MouseDown(object sender, MouseEventArgs e)
        {
            txtNrTelefonit.Clear();
        }

        private void txtNrFix_MouseDown(object sender, MouseEventArgs e)
        {
            txtNrFix.Clear();
        }

        private void txtEmail_MouseDown(object sender, MouseEventArgs e)
        {
            txtEmail.Clear();
        }

        private void txtNrBiznesit_MouseDown(object sender, MouseEventArgs e)
        {
            txtNrBiznesit.Clear();
        }

        private void txtUserName_MouseDown(object sender, MouseEventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtAdresa_MouseDown(object sender, MouseEventArgs e)
        {
            txtAdresa.Clear();
        }

        private void txtWeb_MouseDown(object sender, MouseEventArgs e)
        {
            txtWeb.Clear();
        }

        private void txtpershkrimi_MouseDown(object sender, MouseEventArgs e)
        {
            txtpershkrimi.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blSupplier.DeleteSupplier(txtIdSuppliers.Text);
        }
    }
}
