namespace TruckApp
{
    partial class FormGarages
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
            this.pbGarages = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pbPickUpTruck = new System.Windows.Forms.PictureBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.tbTruckТumber = new System.Windows.Forms.MaskedTextBox();
            this.InfLable1 = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.btnNewTransport = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGarages)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickUpTruck)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGarages
            // 
            this.pbGarages.Location = new System.Drawing.Point(0, 28);
            this.pbGarages.Margin = new System.Windows.Forms.Padding(4);
            this.pbGarages.Name = "pbGarages";
            this.pbGarages.Size = new System.Drawing.Size(1016, 539);
            this.pbGarages.TabIndex = 0;
            this.pbGarages.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.pbPickUpTruck);
            this.groupBox.Controls.Add(this.btnPick);
            this.groupBox.Controls.Add(this.tbTruckТumber);
            this.groupBox.Controls.Add(this.InfLable1);
            this.groupBox.Location = new System.Drawing.Point(1024, 368);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(147, 199);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Pick up truck";
            // 
            // pbPickUpTruck
            // 
            this.pbPickUpTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPickUpTruck.Location = new System.Drawing.Point(5, 111);
            this.pbPickUpTruck.Margin = new System.Windows.Forms.Padding(4);
            this.pbPickUpTruck.Name = "pbPickUpTruck";
            this.pbPickUpTruck.Size = new System.Drawing.Size(133, 74);
            this.pbPickUpTruck.TabIndex = 3;
            this.pbPickUpTruck.TabStop = false;
            // 
            // btnPick
            // 
            this.btnPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPick.Location = new System.Drawing.Point(31, 52);
            this.btnPick.Margin = new System.Windows.Forms.Padding(4);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(100, 28);
            this.btnPick.TabIndex = 2;
            this.btnPick.Text = "Pick";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // tbTruckТumber
            // 
            this.tbTruckТumber.Location = new System.Drawing.Point(83, 20);
            this.tbTruckТumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbTruckТumber.Name = "tbTruckТumber";
            this.tbTruckТumber.Size = new System.Drawing.Size(55, 22);
            this.tbTruckТumber.TabIndex = 1;
            this.tbTruckТumber.Text = "1";
            // 
            // InfLable1
            // 
            this.InfLable1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InfLable1.AutoSize = true;
            this.InfLable1.Location = new System.Drawing.Point(5, 23);
            this.InfLable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfLable1.Name = "InfLable1";
            this.InfLable1.Size = new System.Drawing.Size(59, 17);
            this.InfLable1.TabIndex = 0;
            this.InfLable1.Text = "A place:";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(1024, 33);
            this.listBoxLevels.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(145, 116);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // btnNewTransport
            // 
            this.btnNewTransport.Location = new System.Drawing.Point(1023, 164);
            this.btnNewTransport.Name = "btnNewTransport";
            this.btnNewTransport.Size = new System.Drawing.Size(147, 87);
            this.btnNewTransport.TabIndex = 5;
            this.btnNewTransport.Text = "New transport";
            this.btnNewTransport.UseVisualStyleBackColor = true;
            this.btnNewTransport.Click += new System.EventHandler(this.btnNewTransport_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1179, 28);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(1024, 257);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(147, 87);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // FormGarages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnNewTransport);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pbGarages);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGarages";
            this.Text = "FormGarages";
            ((System.ComponentModel.ISupportInitialize)(this.pbGarages)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickUpTruck)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGarages;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label InfLable1;
        private System.Windows.Forms.MaskedTextBox tbTruckТumber;
        private System.Windows.Forms.PictureBox pbPickUpTruck;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button btnNewTransport;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSort;
    }
}