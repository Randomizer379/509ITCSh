namespace New
{
    partial class Create_contact
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contactTable = new System.Windows.Forms.DataGridView();
            this.createBut = new System.Windows.Forms.Button();
            this.updateBut = new System.Windows.Forms.Button();
            this.deleteBut = new System.Windows.Forms.Button();
            this.conFName = new System.Windows.Forms.TextBox();
            this.conLName = new System.Windows.Forms.TextBox();
            this.conTelNum = new System.Windows.Forms.TextBox();
            this.conAddr = new System.Windows.Forms.TextBox();
            this.conEmail = new System.Windows.Forms.TextBox();
            this.conCity = new System.Windows.Forms.TextBox();
            this.conType = new System.Windows.Forms.ComboBox();
            this.conPostCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.busSearch = new System.Windows.Forms.RadioButton();
            this.perSearch = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.allSearch = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.conID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contactTable)).BeginInit();
            this.SuspendLayout();
            // 
            // contactTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contactTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contactTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contactTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.contactTable.Location = new System.Drawing.Point(12, 39);
            this.contactTable.MultiSelect = false;
            this.contactTable.Name = "contactTable";
            this.contactTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contactTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.contactTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactTable.Size = new System.Drawing.Size(776, 266);
            this.contactTable.TabIndex = 0;
            this.contactTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContactTable_CellContentClick);
            // 
            // createBut
            // 
            this.createBut.Location = new System.Drawing.Point(707, 324);
            this.createBut.Name = "createBut";
            this.createBut.Size = new System.Drawing.Size(81, 30);
            this.createBut.TabIndex = 1;
            this.createBut.Text = "Create";
            this.createBut.UseVisualStyleBackColor = true;
            this.createBut.Click += new System.EventHandler(this.CreateBut_Click);
            // 
            // updateBut
            // 
            this.updateBut.Location = new System.Drawing.Point(707, 360);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(81, 30);
            this.updateBut.TabIndex = 2;
            this.updateBut.Text = "Update";
            this.updateBut.UseVisualStyleBackColor = true;
            this.updateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // deleteBut
            // 
            this.deleteBut.Location = new System.Drawing.Point(707, 396);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.Size = new System.Drawing.Size(81, 30);
            this.deleteBut.TabIndex = 3;
            this.deleteBut.Text = "Delete";
            this.deleteBut.UseVisualStyleBackColor = true;
            this.deleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // conFName
            // 
            this.conFName.Location = new System.Drawing.Point(161, 327);
            this.conFName.Name = "conFName";
            this.conFName.Size = new System.Drawing.Size(161, 20);
            this.conFName.TabIndex = 4;
            // 
            // conLName
            // 
            this.conLName.Location = new System.Drawing.Point(353, 327);
            this.conLName.Name = "conLName";
            this.conLName.Size = new System.Drawing.Size(161, 20);
            this.conLName.TabIndex = 5;
            // 
            // conTelNum
            // 
            this.conTelNum.Location = new System.Drawing.Point(526, 385);
            this.conTelNum.Name = "conTelNum";
            this.conTelNum.Size = new System.Drawing.Size(161, 20);
            this.conTelNum.TabIndex = 6;
            // 
            // conAddr
            // 
            this.conAddr.Location = new System.Drawing.Point(161, 436);
            this.conAddr.Name = "conAddr";
            this.conAddr.Size = new System.Drawing.Size(161, 20);
            this.conAddr.TabIndex = 7;
            // 
            // conEmail
            // 
            this.conEmail.Location = new System.Drawing.Point(161, 385);
            this.conEmail.Name = "conEmail";
            this.conEmail.Size = new System.Drawing.Size(245, 20);
            this.conEmail.TabIndex = 9;
            // 
            // conCity
            // 
            this.conCity.Location = new System.Drawing.Point(391, 436);
            this.conCity.Name = "conCity";
            this.conCity.Size = new System.Drawing.Size(161, 20);
            this.conCity.TabIndex = 10;
            // 
            // conType
            // 
            this.conType.AutoCompleteCustomSource.AddRange(new string[] {
            "Business",
            "Personal"});
            this.conType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.conType.FormattingEnabled = true;
            this.conType.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.conType.Location = new System.Drawing.Point(633, 503);
            this.conType.Name = "conType";
            this.conType.Size = new System.Drawing.Size(155, 21);
            this.conType.TabIndex = 11;
            this.conType.SelectedIndexChanged += new System.EventHandler(this.ContactType_SelectedIndexChanged);
            // 
            // conPostCode
            // 
            this.conPostCode.Location = new System.Drawing.Point(391, 492);
            this.conPostCode.Name = "conPostCode";
            this.conPostCode.Size = new System.Drawing.Size(161, 20);
            this.conPostCode.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telephone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Postcode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Contact type";
            // 
            // busSearch
            // 
            this.busSearch.AutoSize = true;
            this.busSearch.Location = new System.Drawing.Point(679, 15);
            this.busSearch.Name = "busSearch";
            this.busSearch.Size = new System.Drawing.Size(67, 17);
            this.busSearch.TabIndex = 20;
            this.busSearch.TabStop = true;
            this.busSearch.Text = "Business";
            this.busSearch.UseVisualStyleBackColor = true;
            this.busSearch.CheckedChanged += new System.EventHandler(this.BusSearch_CheckedChanged);
            // 
            // perSearch
            // 
            this.perSearch.AutoSize = true;
            this.perSearch.Location = new System.Drawing.Point(607, 15);
            this.perSearch.Name = "perSearch";
            this.perSearch.Size = new System.Drawing.Size(66, 17);
            this.perSearch.TabIndex = 21;
            this.perSearch.TabStop = true;
            this.perSearch.Text = "Personal";
            this.perSearch.UseVisualStyleBackColor = true;
            this.perSearch.CheckedChanged += new System.EventHandler(this.PerSearch_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(558, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Filter: ";
            // 
            // allSearch
            // 
            this.allSearch.AutoSize = true;
            this.allSearch.Location = new System.Drawing.Point(752, 15);
            this.allSearch.Name = "allSearch";
            this.allSearch.Size = new System.Drawing.Size(36, 17);
            this.allSearch.TabIndex = 23;
            this.allSearch.TabStop = true;
            this.allSearch.Text = "All";
            this.allSearch.UseVisualStyleBackColor = true;
            this.allSearch.CheckedChanged += new System.EventHandler(this.AllSearch_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Contact ID";
            // 
            // conID
            // 
            this.conID.Location = new System.Drawing.Point(12, 503);
            this.conID.Name = "conID";
            this.conID.ReadOnly = true;
            this.conID.Size = new System.Drawing.Size(310, 20);
            this.conID.TabIndex = 25;
            // 
            // Create_contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.conID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.allSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.perSearch);
            this.Controls.Add(this.busSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conType);
            this.Controls.Add(this.conCity);
            this.Controls.Add(this.conEmail);
            this.Controls.Add(this.conPostCode);
            this.Controls.Add(this.conAddr);
            this.Controls.Add(this.conTelNum);
            this.Controls.Add(this.conLName);
            this.Controls.Add(this.conFName);
            this.Controls.Add(this.deleteBut);
            this.Controls.Add(this.updateBut);
            this.Controls.Add(this.createBut);
            this.Controls.Add(this.contactTable);
            this.Name = "Create_contact";
            this.Text = "6-";
            this.Load += new System.EventHandler(this.Create_contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView contactTable;
        private System.Windows.Forms.Button createBut;
        private System.Windows.Forms.Button updateBut;
        private System.Windows.Forms.Button deleteBut;
        private System.Windows.Forms.TextBox conFName;
        private System.Windows.Forms.TextBox conLName;
        private System.Windows.Forms.TextBox conTelNum;
        private System.Windows.Forms.TextBox conAddr;
        private System.Windows.Forms.TextBox conEmail;
        private System.Windows.Forms.TextBox conCity;
        private System.Windows.Forms.ComboBox conType;
        private System.Windows.Forms.TextBox conPostCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton busSearch;
        private System.Windows.Forms.RadioButton perSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton allSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox conID;
    }
}