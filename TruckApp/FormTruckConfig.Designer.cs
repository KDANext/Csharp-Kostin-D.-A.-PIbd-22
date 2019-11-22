namespace TruckApp
{
    partial class formTruckConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFuelTruck = new System.Windows.Forms.Label();
            this.labelTruck = new System.Windows.Forms.Label();
            this.pbExampleTruck = new System.Windows.Forms.PictureBox();
            this.panelTruck = new System.Windows.Forms.Panel();
            this.labelTankColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.Color1 = new System.Windows.Forms.Label();
            this.Color3 = new System.Windows.Forms.Label();
            this.Color4 = new System.Windows.Forms.Label();
            this.Color2 = new System.Windows.Forms.Label();
            this.Color8 = new System.Windows.Forms.Label();
            this.Color6 = new System.Windows.Forms.Label();
            this.Color7 = new System.Windows.Forms.Label();
            this.Color5 = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.btnAddTransport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExampleTruck)).BeginInit();
            this.panelTruck.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFuelTruck);
            this.groupBox1.Controls.Add(this.labelTruck);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transport";
            // 
            // labelFuelTruck
            // 
            this.labelFuelTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFuelTruck.Location = new System.Drawing.Point(7, 53);
            this.labelFuelTruck.Name = "labelFuelTruck";
            this.labelFuelTruck.Size = new System.Drawing.Size(100, 23);
            this.labelFuelTruck.TabIndex = 1;
            this.labelFuelTruck.Text = "FuelTruck";
            this.labelFuelTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFuelTruck_MouseDown);
            // 
            // labelTruck
            // 
            this.labelTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTruck.Location = new System.Drawing.Point(7, 22);
            this.labelTruck.Name = "labelTruck";
            this.labelTruck.Size = new System.Drawing.Size(100, 23);
            this.labelTruck.TabIndex = 0;
            this.labelTruck.Text = "Truck";
            this.labelTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTruck_MouseDown);
            // 
            // pbExampleTruck
            // 
            this.pbExampleTruck.Location = new System.Drawing.Point(27, 20);
            this.pbExampleTruck.Name = "pbExampleTruck";
            this.pbExampleTruck.Size = new System.Drawing.Size(161, 96);
            this.pbExampleTruck.TabIndex = 1;
            this.pbExampleTruck.TabStop = false;
            // 
            // panelTruck
            // 
            this.panelTruck.AllowDrop = true;
            this.panelTruck.Controls.Add(this.labelTankColor);
            this.panelTruck.Controls.Add(this.labelMainColor);
            this.panelTruck.Controls.Add(this.pbExampleTruck);
            this.panelTruck.Location = new System.Drawing.Point(279, 65);
            this.panelTruck.Name = "panelTruck";
            this.panelTruck.Size = new System.Drawing.Size(225, 286);
            this.panelTruck.TabIndex = 2;
            this.panelTruck.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragDrop);
            this.panelTruck.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragEnter);
            // 
            // labelTankColor
            // 
            this.labelTankColor.AllowDrop = true;
            this.labelTankColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTankColor.Location = new System.Drawing.Point(27, 191);
            this.labelTankColor.Name = "labelTankColor";
            this.labelTankColor.Size = new System.Drawing.Size(100, 23);
            this.labelTankColor.TabIndex = 3;
            this.labelTankColor.Text = "FuelTruck";
            this.labelTankColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelTankColor_DragDrop);
            this.labelTankColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(27, 154);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(100, 23);
            this.labelMainColor.TabIndex = 2;
            this.labelMainColor.Text = "mainColor";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // Color1
            // 
            this.Color1.BackColor = System.Drawing.Color.White;
            this.Color1.Location = new System.Drawing.Point(22, 34);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(50, 50);
            this.Color1.TabIndex = 3;
            this.Color1.Text = " ";
            this.Color1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Color3
            // 
            this.Color3.BackColor = System.Drawing.Color.Coral;
            this.Color3.Location = new System.Drawing.Point(22, 84);
            this.Color3.Name = "Color3";
            this.Color3.Size = new System.Drawing.Size(50, 50);
            this.Color3.TabIndex = 4;
            this.Color3.Text = " ";
            this.Color3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Color4
            // 
            this.Color4.BackColor = System.Drawing.Color.Cyan;
            this.Color4.Location = new System.Drawing.Point(78, 84);
            this.Color4.Name = "Color4";
            this.Color4.Size = new System.Drawing.Size(50, 50);
            this.Color4.TabIndex = 6;
            this.Color4.Text = " ";
            this.Color4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Color2
            // 
            this.Color2.BackColor = System.Drawing.Color.Black;
            this.Color2.Location = new System.Drawing.Point(78, 34);
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(50, 50);
            this.Color2.TabIndex = 5;
            this.Color2.Text = " ";
            this.Color2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Color8
            // 
            this.Color8.BackColor = System.Drawing.Color.Fuchsia;
            this.Color8.Location = new System.Drawing.Point(78, 184);
            this.Color8.Name = "Color8";
            this.Color8.Size = new System.Drawing.Size(50, 50);
            this.Color8.TabIndex = 10;
            this.Color8.Text = " ";
            this.Color8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Color6
            // 
            this.Color6.BackColor = System.Drawing.Color.Lime;
            this.Color6.Location = new System.Drawing.Point(78, 134);
            this.Color6.Name = "Color6";
            this.Color6.Size = new System.Drawing.Size(50, 50);
            this.Color6.TabIndex = 9;
            this.Color6.Text = " ";
            this.Color6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Color7
            // 
            this.Color7.BackColor = System.Drawing.Color.Blue;
            this.Color7.Location = new System.Drawing.Point(22, 184);
            this.Color7.Name = "Color7";
            this.Color7.Size = new System.Drawing.Size(50, 50);
            this.Color7.TabIndex = 8;
            this.Color7.Text = " ";
            this.Color7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // Color5
            // 
            this.Color5.BackColor = System.Drawing.Color.Red;
            this.Color5.Location = new System.Drawing.Point(22, 134);
            this.Color5.Name = "Color5";
            this.Color5.Size = new System.Drawing.Size(50, 50);
            this.Color5.TabIndex = 7;
            this.Color5.Text = " ";
            this.Color5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.Color8);
            this.groupBoxColor.Controls.Add(this.Color6);
            this.groupBoxColor.Controls.Add(this.Color7);
            this.groupBoxColor.Controls.Add(this.Color5);
            this.groupBoxColor.Controls.Add(this.Color4);
            this.groupBoxColor.Controls.Add(this.Color2);
            this.groupBoxColor.Controls.Add(this.Color3);
            this.groupBoxColor.Controls.Add(this.Color1);
            this.groupBoxColor.Location = new System.Drawing.Point(609, 78);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(150, 272);
            this.groupBoxColor.TabIndex = 11;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Colors";
            // 
            // btnAddTransport
            // 
            this.btnAddTransport.Location = new System.Drawing.Point(12, 238);
            this.btnAddTransport.Name = "btnAddTransport";
            this.btnAddTransport.Size = new System.Drawing.Size(75, 23);
            this.btnAddTransport.TabIndex = 12;
            this.btnAddTransport.Text = "Add";
            this.btnAddTransport.UseVisualStyleBackColor = true;
            this.btnAddTransport.Click += new System.EventHandler(this.btnAddTransport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(108, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // formTruckConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTransport);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelTruck);
            this.Controls.Add(this.groupBox1);
            this.Name = "formTruckConfig";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExampleTruck)).EndInit();
            this.panelTruck.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFuelTruck;
        private System.Windows.Forms.Label labelTruck;
        private System.Windows.Forms.PictureBox pbExampleTruck;
        private System.Windows.Forms.Panel panelTruck;
        private System.Windows.Forms.Label labelTankColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Label Color1;
        private System.Windows.Forms.Label Color3;
        private System.Windows.Forms.Label Color4;
        private System.Windows.Forms.Label Color2;
        private System.Windows.Forms.Label Color8;
        private System.Windows.Forms.Label Color6;
        private System.Windows.Forms.Label Color7;
        private System.Windows.Forms.Label Color5;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Button btnAddTransport;
        private System.Windows.Forms.Button btnCancel;
    }
}