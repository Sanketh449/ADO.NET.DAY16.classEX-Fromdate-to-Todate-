namespace ADO.NET.DAY16.classEX
{
    partial class Form1
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
            this.DtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.GridEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpFromDate
            // 
            this.DtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFromDate.Location = new System.Drawing.Point(36, 35);
            this.DtpFromDate.Name = "DtpFromDate";
            this.DtpFromDate.Size = new System.Drawing.Size(200, 20);
            this.DtpFromDate.TabIndex = 0;
            // 
            // DtpToDate
            // 
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpToDate.Location = new System.Drawing.Point(276, 35);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(200, 20);
            this.DtpToDate.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(579, 36);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // GridEmployee
            // 
            this.GridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployee.Location = new System.Drawing.Point(27, 118);
            this.GridEmployee.Name = "GridEmployee";
            this.GridEmployee.Size = new System.Drawing.Size(679, 182);
            this.GridEmployee.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridEmployee);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DtpToDate);
            this.Controls.Add(this.DtpFromDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpFromDate;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView GridEmployee;
    }
}

