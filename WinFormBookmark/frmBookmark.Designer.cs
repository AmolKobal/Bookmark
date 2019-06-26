namespace WinFormBookmark
{
    partial class frmBookmark
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddBookmark = new System.Windows.Forms.Button();
            this.txtBookmarkName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBookmark = new System.Windows.Forms.GroupBox();
            this.btnUpdateBookmark = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.numericMax = new System.Windows.Forms.NumericUpDown();
            this.numericMin = new System.Windows.Forms.NumericUpDown();
            this.txtType = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridTasks = new System.Windows.Forms.DataGridView();
            this.grpBookmark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBookmark
            // 
            this.btnAddBookmark.Enabled = false;
            this.btnAddBookmark.Location = new System.Drawing.Point(926, 115);
            this.btnAddBookmark.Name = "btnAddBookmark";
            this.btnAddBookmark.Size = new System.Drawing.Size(120, 39);
            this.btnAddBookmark.TabIndex = 0;
            this.btnAddBookmark.Text = "Add";
            this.btnAddBookmark.UseVisualStyleBackColor = true;
            this.btnAddBookmark.Click += new System.EventHandler(this.btnAddBookmark_Click);
            // 
            // txtBookmarkName
            // 
            this.txtBookmarkName.Location = new System.Drawing.Point(114, 29);
            this.txtBookmarkName.Name = "txtBookmarkName";
            this.txtBookmarkName.Size = new System.Drawing.Size(768, 24);
            this.txtBookmarkName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // grpBookmark
            // 
            this.grpBookmark.Controls.Add(this.btnUpdateBookmark);
            this.grpBookmark.Controls.Add(this.btnNew);
            this.grpBookmark.Controls.Add(this.txtPercentage);
            this.grpBookmark.Controls.Add(this.txtCurrent);
            this.grpBookmark.Controls.Add(this.numericMax);
            this.grpBookmark.Controls.Add(this.numericMin);
            this.grpBookmark.Controls.Add(this.txtType);
            this.grpBookmark.Controls.Add(this.cboStatus);
            this.grpBookmark.Controls.Add(this.btnClear);
            this.grpBookmark.Controls.Add(this.label6);
            this.grpBookmark.Controls.Add(this.lblCurrent);
            this.grpBookmark.Controls.Add(this.label5);
            this.grpBookmark.Controls.Add(this.btnAddBookmark);
            this.grpBookmark.Controls.Add(this.label4);
            this.grpBookmark.Controls.Add(this.label3);
            this.grpBookmark.Controls.Add(this.label2);
            this.grpBookmark.Controls.Add(this.label1);
            this.grpBookmark.Controls.Add(this.lblName);
            this.grpBookmark.Controls.Add(this.txtInfo);
            this.grpBookmark.Controls.Add(this.txtBookmarkName);
            this.grpBookmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookmark.Location = new System.Drawing.Point(28, 12);
            this.grpBookmark.Name = "grpBookmark";
            this.grpBookmark.Size = new System.Drawing.Size(1090, 255);
            this.grpBookmark.TabIndex = 3;
            this.grpBookmark.TabStop = false;
            this.grpBookmark.Text = "New";
            // 
            // btnUpdateBookmark
            // 
            this.btnUpdateBookmark.Location = new System.Drawing.Point(926, 115);
            this.btnUpdateBookmark.Name = "btnUpdateBookmark";
            this.btnUpdateBookmark.Size = new System.Drawing.Size(120, 39);
            this.btnUpdateBookmark.TabIndex = 7;
            this.btnUpdateBookmark.Text = "Update";
            this.btnUpdateBookmark.UseVisualStyleBackColor = true;
            this.btnUpdateBookmark.Visible = false;
            this.btnUpdateBookmark.Click += new System.EventHandler(this.btnUpdateBookmark_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(926, 52);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 39);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPercentage
            // 
            this.txtPercentage.Enabled = false;
            this.txtPercentage.Location = new System.Drawing.Point(786, 111);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(88, 24);
            this.txtPercentage.TabIndex = 5;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Enabled = false;
            this.txtCurrent.Location = new System.Drawing.Point(559, 111);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(103, 24);
            this.txtCurrent.TabIndex = 5;
            // 
            // numericMax
            // 
            this.numericMax.Location = new System.Drawing.Point(372, 111);
            this.numericMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericMax.Name = "numericMax";
            this.numericMax.Size = new System.Drawing.Size(103, 24);
            this.numericMax.TabIndex = 4;
            // 
            // numericMin
            // 
            this.numericMin.Location = new System.Drawing.Point(114, 111);
            this.numericMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericMin.Name = "numericMin";
            this.numericMin.Size = new System.Drawing.Size(103, 24);
            this.numericMin.TabIndex = 4;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(114, 70);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(361, 24);
            this.txtType.TabIndex = 1;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Pending",
            "Complete",
            "In Progress"});
            this.cboStatus.Location = new System.Drawing.Point(559, 69);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(321, 26);
            this.cboStatus.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(926, 178);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 39);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(688, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "% Complete";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(497, 116);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(57, 18);
            this.lblCurrent.TabIndex = 2;
            this.lblCurrent.Text = "Current";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Maximum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Minimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "Additional Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(114, 151);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(768, 81);
            this.txtInfo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridTasks);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1090, 434);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Existing";
            // 
            // gridTasks
            // 
            this.gridTasks.AllowUserToAddRows = false;
            this.gridTasks.AllowUserToDeleteRows = false;
            this.gridTasks.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.gridTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTasks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTasks.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridTasks.GridColor = System.Drawing.Color.WhiteSmoke;
            this.gridTasks.Location = new System.Drawing.Point(18, 24);
            this.gridTasks.MultiSelect = false;
            this.gridTasks.Name = "gridTasks";
            this.gridTasks.ReadOnly = true;
            this.gridTasks.RowHeadersVisible = false;
            this.gridTasks.RowHeadersWidth = 51;
            this.gridTasks.RowTemplate.Height = 24;
            this.gridTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTasks.Size = new System.Drawing.Size(1052, 392);
            this.gridTasks.TabIndex = 0;
            this.gridTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBookmark_CellClick);
            this.gridTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBookmark_CellContentClick);
            this.gridTasks.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTasks_CellEnter);
            // 
            // frmBookmark
            // 
            this.AcceptButton = this.btnAddBookmark;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1151, 719);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBookmark);
            this.Name = "frmBookmark";
            this.Text = "Bookmark";
            this.Load += new System.EventHandler(this.frmBookmark_Load);
            this.grpBookmark.ResumeLayout(false);
            this.grpBookmark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBookmark;
        private System.Windows.Forms.TextBox txtBookmarkName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpBookmark;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.NumericUpDown numericMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.DataGridView gridTasks;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdateBookmark;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label label6;
    }
}