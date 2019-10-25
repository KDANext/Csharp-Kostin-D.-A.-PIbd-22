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
            this.btnTruckInGarage = new System.Windows.Forms.Button();
            this.btnFuelTruckInGarage = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pbPickUpTruck = new System.Windows.Forms.PictureBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.tbTruckТumber = new System.Windows.Forms.MaskedTextBox();
            this.InfLable1 = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGarages)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickUpTruck)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGarages
            // 
            this.pbGarages.Location = new System.Drawing.Point(0, 1);
            this.pbGarages.Name = "pbGarages";
            this.pbGarages.Size = new System.Drawing.Size(762, 460);
            this.pbGarages.TabIndex = 0;
            this.pbGarages.TabStop = false;
            // 
            // btnTruckInGarage
            // 
            this.btnTruckInGarage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTruckInGarage.Location = new System.Drawing.Point(768, 136);
            this.btnTruckInGarage.Name = "btnTruckInGarage";
            this.btnTruckInGarage.Size = new System.Drawing.Size(110, 36);
            this.btnTruckInGarage.TabIndex = 1;
            this.btnTruckInGarage.Text = "Truck in garage";
            this.btnTruckInGarage.UseVisualStyleBackColor = true;
            this.btnTruckInGarage.Click += new System.EventHandler(this.btnSetTruckInGarege_Click);
            // 
            // btnFuelTruckInGarage
            // 
            this.btnFuelTruckInGarage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuelTruckInGarage.Location = new System.Drawing.Point(768, 178);
            this.btnFuelTruckInGarage.Name = "btnFuelTruckInGarage";
            this.btnFuelTruckInGarage.Size = new System.Drawing.Size(110, 40);
            this.btnFuelTruckInGarage.TabIndex = 2;
            this.btnFuelTruckInGarage.Text = "Fuel truck in garage";
            this.btnFuelTruckInGarage.UseVisualStyleBackColor = true;
            this.btnFuelTruckInGarage.Click += new System.EventHandler(this.btnSetFuelTruckInGarege_Click);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.pbPickUpTruck);
            this.groupBox.Controls.Add(this.btnPick);
            this.groupBox.Controls.Add(this.tbTruckТumber);
            this.groupBox.Controls.Add(this.InfLable1);
            this.groupBox.Location = new System.Drawing.Point(768, 299);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(110, 162);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Pick up truck";
            // 
            // pbPickUpTruck
            // 
            this.pbPickUpTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPickUpTruck.Location = new System.Drawing.Point(4, 90);
            this.pbPickUpTruck.Name = "pbPickUpTruck";
            this.pbPickUpTruck.Size = new System.Drawing.Size(100, 60);
            this.pbPickUpTruck.TabIndex = 3;
            this.pbPickUpTruck.TabStop = false;
            // 
            // btnPick
            // 
            this.btnPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPick.Location = new System.Drawing.Point(23, 42);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 2;
            this.btnPick.Text = "Pick";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // tbTruckТumber
            // 
            this.tbTruckТumber.Location = new System.Drawing.Point(62, 16);
            this.tbTruckТumber.Name = "tbTruckТumber";
            this.tbTruckТumber.Size = new System.Drawing.Size(42, 20);
            this.tbTruckТumber.TabIndex = 1;
            this.tbTruckТumber.Text = "1";
            // 
            // InfLable1
            // 
            this.InfLable1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InfLable1.AutoSize = true;
            this.InfLable1.Location = new System.Drawing.Point(4, 19);
            this.InfLable1.Name = "InfLable1";
            this.InfLable1.Size = new System.Drawing.Size(46, 13);
            this.InfLable1.TabIndex = 0;
            this.InfLable1.Text = "A place:";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(768, 1);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(110, 121);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // FormGarages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnFuelTruckInGarage);
            this.Controls.Add(this.btnTruckInGarage);
            this.Controls.Add(this.pbGarages);
            this.Name = "FormGarages";
            this.Text = "FormGarages";
            ((System.ComponentModel.ISupportInitialize)(this.pbGarages)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickUpTruck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGarages;
        private System.Windows.Forms.Button btnTruckInGarage;
        private System.Windows.Forms.Button btnFuelTruckInGarage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label InfLable1;
        private System.Windows.Forms.MaskedTextBox tbTruckТumber;
        private System.Windows.Forms.PictureBox pbPickUpTruck;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}