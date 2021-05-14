
namespace Electrical_Bill_Processer
{
    partial class ElectricalBillGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectricalBillGUI));
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxKwhUsed = new System.Windows.Forms.TextBox();
            this.txtBoxNumOfCustomersProcessed = new System.Windows.Forms.TextBox();
            this.listboxCustomerDataDisplay = new System.Windows.Forms.ListBox();
            this.txtBoxAvgBillAmt = new System.Windows.Forms.TextBox();
            this.txtBoxTotalNumOfKwhUsed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(84, 149);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(243, 36);
            this.txtBoxFirstName.TabIndex = 0;
            this.txtBoxFirstName.Text = "Tamika";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(84, 245);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(243, 36);
            this.txtBoxLastName.TabIndex = 1;
            this.txtBoxLastName.Text = "Taylor";
            // 
            // txtBoxKwhUsed
            // 
            this.txtBoxKwhUsed.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxKwhUsed.Location = new System.Drawing.Point(84, 326);
            this.txtBoxKwhUsed.Name = "txtBoxKwhUsed";
            this.txtBoxKwhUsed.Size = new System.Drawing.Size(243, 36);
            this.txtBoxKwhUsed.TabIndex = 2;
            this.txtBoxKwhUsed.Text = "KwH";
            // 
            // txtBoxNumOfCustomersProcessed
            // 
            this.txtBoxNumOfCustomersProcessed.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumOfCustomersProcessed.Location = new System.Drawing.Point(815, 150);
            this.txtBoxNumOfCustomersProcessed.Multiline = true;
            this.txtBoxNumOfCustomersProcessed.Name = "txtBoxNumOfCustomersProcessed";
            this.txtBoxNumOfCustomersProcessed.ReadOnly = true;
            this.txtBoxNumOfCustomersProcessed.Size = new System.Drawing.Size(307, 39);
            this.txtBoxNumOfCustomersProcessed.TabIndex = 7;
            this.txtBoxNumOfCustomersProcessed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listboxCustomerDataDisplay
            // 
            this.listboxCustomerDataDisplay.BackColor = System.Drawing.Color.Beige;
            this.listboxCustomerDataDisplay.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxCustomerDataDisplay.FormattingEnabled = true;
            this.listboxCustomerDataDisplay.ItemHeight = 21;
            this.listboxCustomerDataDisplay.Location = new System.Drawing.Point(-1, 458);
            this.listboxCustomerDataDisplay.Name = "listboxCustomerDataDisplay";
            this.listboxCustomerDataDisplay.Size = new System.Drawing.Size(1210, 151);
            this.listboxCustomerDataDisplay.TabIndex = 6;
            // 
            // txtBoxAvgBillAmt
            // 
            this.txtBoxAvgBillAmt.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxAvgBillAmt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAvgBillAmt.Location = new System.Drawing.Point(815, 327);
            this.txtBoxAvgBillAmt.Name = "txtBoxAvgBillAmt";
            this.txtBoxAvgBillAmt.ReadOnly = true;
            this.txtBoxAvgBillAmt.Size = new System.Drawing.Size(307, 36);
            this.txtBoxAvgBillAmt.TabIndex = 9;
            this.txtBoxAvgBillAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTotalNumOfKwhUsed
            // 
            this.txtBoxTotalNumOfKwhUsed.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalNumOfKwhUsed.Location = new System.Drawing.Point(815, 246);
            this.txtBoxTotalNumOfKwhUsed.Name = "txtBoxTotalNumOfKwhUsed";
            this.txtBoxTotalNumOfKwhUsed.ReadOnly = true;
            this.txtBoxTotalNumOfKwhUsed.Size = new System.Drawing.Size(307, 36);
            this.txtBoxTotalNumOfKwhUsed.TabIndex = 8;
            this.txtBoxTotalNumOfKwhUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(768, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Number of Customers processed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(810, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Number of KWh Used";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(846, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Average Bill Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter KwH\'s Used";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter First Name";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(450, 346);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(245, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Clear";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(853, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(243, 46);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(792, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(353, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "Our Company Statistics";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(355, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "Enter Information Below";
            // 
            // ElectricalBillGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1210, 602);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxTotalNumOfKwhUsed);
            this.Controls.Add(this.txtBoxAvgBillAmt);
            this.Controls.Add(this.listboxCustomerDataDisplay);
            this.Controls.Add(this.txtBoxNumOfCustomersProcessed);
            this.Controls.Add(this.txtBoxKwhUsed);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.button1);
            this.Name = "ElectricalBillGUI";
            this.Text = "ElectricalBillGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxKwhUsed;
        private System.Windows.Forms.TextBox txtBoxNumOfCustomersProcessed;
        private System.Windows.Forms.ListBox listboxCustomerDataDisplay;
        private System.Windows.Forms.TextBox txtBoxAvgBillAmt;
        private System.Windows.Forms.TextBox txtBoxTotalNumOfKwhUsed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

