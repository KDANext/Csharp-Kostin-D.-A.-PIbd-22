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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pbPickUpTruck = new System.Windows.Forms.PictureBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.tbTruckТumber = new System.Windows.Forms.MaskedTextBox();
            this.InfLable1 = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.btnNewTransport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGarages)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickUpTruck)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGarages
            // 
            this.pbGarages.Location = new System.Drawing.Point(0, 1);
            this.pbGarages.Margin = new System.Windows.Forms.Padding(4);
            this.pbGarages.Name = "pbGarages";
            this.pbGarages.Size = new System.Drawing.Size(1016, 566);
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
            this.listBoxLevels.Location = new System.Drawing.Point(1024, 1);
            this.listBoxLevels.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(145, 148);
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
            // FormGarages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.btnNewTransport);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pbGarages);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label InfLable1;
        private System.Windows.Forms.MaskedTextBox tbTruckТumber;
        private System.Windows.Forms.PictureBox pbPickUpTruck;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button btnNewTransport;
    }
}