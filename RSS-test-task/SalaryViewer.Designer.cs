namespace RSS_test_task
{
    partial class SalaryViewer
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
            this.comboBoxSalary = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxInactive = new System.Windows.Forms.CheckBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCombo = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.dataGridViewFinal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSalary
            // 
            this.comboBoxSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSalary.FormattingEnabled = true;
            this.comboBoxSalary.Items.AddRange(new object[] {
            "Average",
            "Maximum"});
            this.comboBoxSalary.Location = new System.Drawing.Point(214, 38);
            this.comboBoxSalary.Name = "comboBoxSalary";
            this.comboBoxSalary.Size = new System.Drawing.Size(71, 22);
            this.comboBoxSalary.TabIndex = 0;
            this.comboBoxSalary.SelectedIndexChanged += new System.EventHandler(this.comboBoxSalary_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(110, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // checkBoxInactive
            // 
            this.checkBoxInactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxInactive.AutoSize = true;
            this.checkBoxInactive.Location = new System.Drawing.Point(179, 66);
            this.checkBoxInactive.Name = "checkBoxInactive";
            this.checkBoxInactive.Size = new System.Drawing.Size(106, 18);
            this.checkBoxInactive.TabIndex = 2;
            this.checkBoxInactive.Text = "Show dismissed";
            this.checkBoxInactive.UseVisualStyleBackColor = true;
            this.checkBoxInactive.CheckedChanged += new System.EventHandler(this.checkBoxInactive_CheckedChanged);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(12, 62);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 25);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 14);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Search by name:";
            // 
            // labelCombo
            // 
            this.labelCombo.AutoSize = true;
            this.labelCombo.Location = new System.Drawing.Point(12, 41);
            this.labelCombo.Name = "labelCombo";
            this.labelCombo.Size = new System.Drawing.Size(127, 14);
            this.labelCombo.TabIndex = 8;
            this.labelCombo.Text = "Employee payment view:";
            // 
            // labelC
            // 
            this.labelC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(9, 445);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(167, 14);
            this.labelC.TabIndex = 9;
            this.labelC.Text = "Made by Dmitrii Bragin for RSS.ru";
            // 
            // labelCC
            // 
            this.labelCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(211, 445);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(77, 14);
            this.labelCC.TabIndex = 10;
            this.labelCC.Text = " CC BY NC 4.0";
            this.labelCC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewFinal
            // 
            this.dataGridViewFinal.AllowUserToAddRows = false;
            this.dataGridViewFinal.AllowUserToDeleteRows = false;
            this.dataGridViewFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinal.Location = new System.Drawing.Point(12, 93);
            this.dataGridViewFinal.Name = "dataGridViewFinal";
            this.dataGridViewFinal.ReadOnly = true;
            this.dataGridViewFinal.Size = new System.Drawing.Size(273, 349);
            this.dataGridViewFinal.TabIndex = 12;
            // 
            // SalaryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 468);
            this.Controls.Add(this.dataGridViewFinal);
            this.Controls.Add(this.labelCC);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelCombo);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.checkBoxInactive);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxSalary);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SalaryViewer";
            this.Text = "Salary Viewer";
            this.Load += new System.EventHandler(this.SalaryViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSalary;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxInactive;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCombo;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.DataGridView dataGridViewFinal;
    }
}

