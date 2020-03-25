namespace SQLAccess
{
    partial class FormUI
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
            this.lstPeople = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreatePeople = new System.Windows.Forms.Button();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbEmaillAddress = new System.Windows.Forms.TextBox();
            this.txbLastName2 = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLasTName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPeople
            // 
            this.lstPeople.FormattingEnabled = true;
            this.lstPeople.Location = new System.Drawing.Point(12, 12);
            this.lstPeople.Name = "lstPeople";
            this.lstPeople.Size = new System.Drawing.Size(220, 329);
            this.lstPeople.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 403);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(219, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreatePeople);
            this.groupBox1.Controls.Add(this.txbPhoneNumber);
            this.groupBox1.Controls.Add(this.txbEmaillAddress);
            this.groupBox1.Controls.Add(this.txbLastName2);
            this.groupBox1.Controls.Add(this.txbFirstName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(254, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCreatePeople
            // 
            this.btnCreatePeople.Location = new System.Drawing.Point(125, 114);
            this.btnCreatePeople.Name = "btnCreatePeople";
            this.btnCreatePeople.Size = new System.Drawing.Size(165, 23);
            this.btnCreatePeople.TabIndex = 8;
            this.btnCreatePeople.Text = "Create people";
            this.btnCreatePeople.UseVisualStyleBackColor = true;
            this.btnCreatePeople.Click += new System.EventHandler(this.btnCreatePeople_Click);
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(125, 87);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(165, 20);
            this.txbPhoneNumber.TabIndex = 7;
            // 
            // txbEmaillAddress
            // 
            this.txbEmaillAddress.Location = new System.Drawing.Point(125, 64);
            this.txbEmaillAddress.Name = "txbEmaillAddress";
            this.txbEmaillAddress.Size = new System.Drawing.Size(165, 20);
            this.txbEmaillAddress.TabIndex = 6;
            // 
            // txbLastName2
            // 
            this.txbLastName2.Location = new System.Drawing.Point(125, 39);
            this.txbLastName2.Name = "txbLastName2";
            this.txbLastName2.Size = new System.Drawing.Size(165, 20);
            this.txbLastName2.TabIndex = 5;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(125, 13);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(165, 20);
            this.txbFirstName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "email address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // txbLasTName
            // 
            this.txbLasTName.Location = new System.Drawing.Point(13, 373);
            this.txbLasTName.Name = "txbLasTName";
            this.txbLasTName.Size = new System.Drawing.Size(219, 20);
            this.txbLasTName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search by last name";
            // 
            // FormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbLasTName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lstPeople);
            this.Name = "FormUI";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPeople;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreatePeople;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.TextBox txbEmaillAddress;
        private System.Windows.Forms.TextBox txbLastName2;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLasTName;
        private System.Windows.Forms.Label label5;
    }
}

