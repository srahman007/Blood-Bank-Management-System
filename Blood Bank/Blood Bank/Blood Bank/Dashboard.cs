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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor and = new AddNewDonor();
            and.Show();


        }

        private void updateDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonorDetails udd = new UpdateDonorDetails();
            udd.Show();
        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDetails add = new AllDonorDetails();
            add.Show();
        }

        private void allDonorDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AllDonorDetails add = new AllDonorDetails();
            add.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBloodDonorAddress sba = new SearchBloodDonorAddress();
            sba.Show();
        }

        private void donorLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorByBlood sd = new SearchDonorByBlood();
            sd.Show();
        }

        private void increaseStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockIncrease si = new StockIncrease();
            si.Show();
        }

        private void decreseStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDecrease sd = new StockDecrease();
            sd.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BloodStockDetails sk = new BloodStockDetails();
            sk.Show();
        }

        private void donorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDonor dd = new DeleteDonor();
            dd.Show();
        }
    } 
}
