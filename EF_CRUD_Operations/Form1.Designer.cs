namespace EF_CRUD_Operations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstBilgiGoruntule = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lstCompanyName = new ListView();
            lstEmployeeName = new ListView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnGetOrderList = new Button();
            SuspendLayout();
            // 
            // lstBilgiGoruntule
            // 
            lstBilgiGoruntule.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lstBilgiGoruntule.FullRowSelect = true;
            lstBilgiGoruntule.GridLines = true;
            lstBilgiGoruntule.Location = new Point(169, 62);
            lstBilgiGoruntule.Name = "lstBilgiGoruntule";
            lstBilgiGoruntule.Size = new Size(540, 349);
            lstBilgiGoruntule.TabIndex = 13;
            lstBilgiGoruntule.UseCompatibleStateImageBehavior = false;
            lstBilgiGoruntule.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Order ID";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Order Date";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ship City";
            columnHeader3.Width = 180;
            // 
            // lstCompanyName
            // 
            lstCompanyName.Location = new Point(12, 314);
            lstCompanyName.Name = "lstCompanyName";
            lstCompanyName.Size = new Size(121, 97);
            lstCompanyName.TabIndex = 12;
            lstCompanyName.UseCompatibleStateImageBehavior = false;
            lstCompanyName.View = View.List;
            // 
            // lstEmployeeName
            // 
            lstEmployeeName.Location = new Point(12, 62);
            lstEmployeeName.Name = "lstEmployeeName";
            lstEmployeeName.Size = new Size(121, 220);
            lstEmployeeName.TabIndex = 11;
            lstEmployeeName.UseCompatibleStateImageBehavior = false;
            lstEmployeeName.View = View.List;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(577, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 37);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(369, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 37);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(169, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 37);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGetOrderList
            // 
            btnGetOrderList.Location = new Point(12, 12);
            btnGetOrderList.Name = "btnGetOrderList";
            btnGetOrderList.Size = new Size(121, 37);
            btnGetOrderList.TabIndex = 7;
            btnGetOrderList.Text = "Get Order List";
            btnGetOrderList.UseVisualStyleBackColor = true;
            btnGetOrderList.Click += btnGetOrderList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 433);
            Controls.Add(lstBilgiGoruntule);
            Controls.Add(lstCompanyName);
            Controls.Add(lstEmployeeName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnGetOrderList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        public ListView lstBilgiGoruntule;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lstCompanyName;
        private ListView lstEmployeeName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnGetOrderList;
    }
}