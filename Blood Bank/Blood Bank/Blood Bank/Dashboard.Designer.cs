
namespace Blood_Bank
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewDonor = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDonorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.allDonorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBloodDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreseStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(1293, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.searchBloodDonorToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.deleteDonorToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1339, 68);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewDonor,
            this.updateDonorDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.allDonorDetailsToolStripMenuItem});
            this.donorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donorToolStripMenuItem.Image")));
            this.donorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(115, 64);
            this.donorToolStripMenuItem.Text = "Donor";
            // 
            // AddNewDonor
            // 
            this.AddNewDonor.Image = ((System.Drawing.Image)(resources.GetObject("AddNewDonor.Image")));
            this.AddNewDonor.Name = "AddNewDonor";
            this.AddNewDonor.Size = new System.Drawing.Size(237, 26);
            this.AddNewDonor.Text = "Add New Donor";
            this.AddNewDonor.Click += new System.EventHandler(this.addNewDonorToolStripMenuItem_Click);
            // 
            // updateDonorDetailsToolStripMenuItem
            // 
            this.updateDonorDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateDonorDetailsToolStripMenuItem.Image")));
            this.updateDonorDetailsToolStripMenuItem.Name = "updateDonorDetailsToolStripMenuItem";
            this.updateDonorDetailsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.updateDonorDetailsToolStripMenuItem.Text = "Update Donor Details";
            this.updateDonorDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDonorDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // allDonorDetailsToolStripMenuItem
            // 
            this.allDonorDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allDonorDetailsToolStripMenuItem.Image")));
            this.allDonorDetailsToolStripMenuItem.Name = "allDonorDetailsToolStripMenuItem";
            this.allDonorDetailsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.allDonorDetailsToolStripMenuItem.Text = "All Donor Details";
            this.allDonorDetailsToolStripMenuItem.Click += new System.EventHandler(this.allDonorDetailsToolStripMenuItem_Click_1);
            // 
            // searchBloodDonorToolStripMenuItem
            // 
            this.searchBloodDonorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorLocationToolStripMenuItem,
            this.locationToolStripMenuItem});
            this.searchBloodDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchBloodDonorToolStripMenuItem.Image")));
            this.searchBloodDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchBloodDonorToolStripMenuItem.Name = "searchBloodDonorToolStripMenuItem";
            this.searchBloodDonorToolStripMenuItem.Size = new System.Drawing.Size(207, 64);
            this.searchBloodDonorToolStripMenuItem.Text = "Search Blood Donor";
            // 
            // donorLocationToolStripMenuItem
            // 
            this.donorLocationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donorLocationToolStripMenuItem.Image")));
            this.donorLocationToolStripMenuItem.Name = "donorLocationToolStripMenuItem";
            this.donorLocationToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.donorLocationToolStripMenuItem.Text = "Blood Group";
            this.donorLocationToolStripMenuItem.Click += new System.EventHandler(this.donorLocationToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("locationToolStripMenuItem.Image")));
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseStockToolStripMenuItem,
            this.decreseStockToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.stockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockToolStripMenuItem.Image")));
            this.stockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(109, 64);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // increaseStockToolStripMenuItem
            // 
            this.increaseStockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("increaseStockToolStripMenuItem.Image")));
            this.increaseStockToolStripMenuItem.Name = "increaseStockToolStripMenuItem";
            this.increaseStockToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.increaseStockToolStripMenuItem.Text = "Increase Stock";
            this.increaseStockToolStripMenuItem.Click += new System.EventHandler(this.increaseStockToolStripMenuItem_Click);
            // 
            // decreseStockToolStripMenuItem
            // 
            this.decreseStockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decreseStockToolStripMenuItem.Image")));
            this.decreseStockToolStripMenuItem.Name = "decreseStockToolStripMenuItem";
            this.decreseStockToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.decreseStockToolStripMenuItem.Text = "Decrease Stock";
            this.decreseStockToolStripMenuItem.Click += new System.EventHandler(this.decreseStockToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detailsToolStripMenuItem.Image")));
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.detailsToolStripMenuItem.Text = "Available Stocks";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // deleteDonorToolStripMenuItem
            // 
            this.deleteDonorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorListToolStripMenuItem});
            this.deleteDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonorToolStripMenuItem.Image")));
            this.deleteDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            this.deleteDonorToolStripMenuItem.Size = new System.Drawing.Size(163, 64);
            this.deleteDonorToolStripMenuItem.Text = "Delete Donor";
            // 
            // donorListToolStripMenuItem
            // 
            this.donorListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donorListToolStripMenuItem.Image")));
            this.donorListToolStripMenuItem.Name = "donorListToolStripMenuItem";
            this.donorListToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.donorListToolStripMenuItem.Text = "Donor details";
            this.donorListToolStripMenuItem.Click += new System.EventHandler(this.donorListToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(134, 64);
            this.logoutToolStripMenuItem.Text = "Logout ";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1339, 597);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBloodDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewDonor;
        private System.Windows.Forms.ToolStripMenuItem updateDonorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem allDonorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreseStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorListToolStripMenuItem;
    }
}