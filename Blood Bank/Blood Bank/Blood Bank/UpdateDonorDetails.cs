using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
    public partial class UpdateDonorDetails : Form
    {
        function fn = new function();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDonorID.Text.ToString());
            String query = "select = from newDonor where did = " + id + "";
            DataSet ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][1].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDOB.Text = ds.Tables[0].Rows[0][1].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][1].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][1].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][1].ToString();
                txtBloodGroup.Text = ds.Tables[0].Rows[0][1].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][1].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if(txtDonorID.Text == "")
            {
                txtName.Clear();
                txtFather.Clear();
                txtMother.Clear();
                txtDOB.ResetText();
                txtMobile.Clear();
                txtGender.ResetText();
                txtEmail.Clear();
                txtBloodGroup.ResetText();
                txtCity.Clear();
                txtAddress.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             
            String query = "update newDonor set dname ='"+txtName.Text+ "',fname'" + txtFather.Text + "',mname ='" + txtMother.Text + "',dob ='" + txtDOB.Text + "',mobile ='" + txtMobile.Text + "',gender ='" + txtGender.Text + "',email ='" + txtEmail.Text + "',bloodgroup ='" + txtBloodGroup.Text + "',city ='" + txtCity.Text + "',address ='"+txtAddress.Text+"' where did = "+txtDonorID.Text+"";
            fn.setDate(query);
            UpdateDonorDetails_Load(this, null);
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }
    }
}
