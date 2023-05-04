namespace EF_CRUD_Operations
{
    partial class Form2
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
            btnAdd = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtShipCity = new TextBox();
            cmbShipper = new ComboBox();
            cmbEmployee = new ComboBox();
            dtpOrderDate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(80, 184);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 32);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 141);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 16;
            label4.Text = "Shipper";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 102);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 15;
            label3.Text = "Ship City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 14;
            label2.Text = "Order Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 13;
            label1.Text = "Employee";
            // 
            // txtShipCity
            // 
            txtShipCity.Location = new Point(80, 99);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(195, 23);
            txtShipCity.TabIndex = 12;
            // 
            // cmbShipper
            // 
            cmbShipper.FormattingEnabled = true;
            cmbShipper.Location = new Point(80, 138);
            cmbShipper.Name = "cmbShipper";
            cmbShipper.Size = new Size(195, 23);
            cmbShipper.TabIndex = 11;
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(80, 16);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(195, 23);
            cmbEmployee.TabIndex = 9;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(77, 56);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(200, 23);
            dtpOrderDate.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 236);
            Controls.Add(dtpOrderDate);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtShipCity);
            Controls.Add(cmbShipper);
            Controls.Add(cmbEmployee);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtShipCity;
        private ComboBox cmbShipper;
        private ComboBox cmbEmployee;
        private DateTimePicker dtpOrderDate;
    }
}