namespace CommanderHandbook
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
            dgvSoldiers = new DataGridView();
            btnAll = new Button();
            btnOfficers = new Button();
            btnConscripts = new Button();
            btnSort = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSoldiers).BeginInit();
            SuspendLayout();
            // 
            // dgvSoldiers
            // 
            dgvSoldiers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSoldiers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSoldiers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSoldiers.Location = new Point(296, 149);
            dgvSoldiers.Name = "dgvSoldiers";
            dgvSoldiers.RowHeadersWidth = 51;
            dgvSoldiers.Size = new Size(300, 188);
            dgvSoldiers.TabIndex = 0;
            // 
            // btnAll
            // 
            btnAll.BackColor = SystemColors.ActiveCaptionText;
            btnAll.ForeColor = SystemColors.ControlLightLight;
            btnAll.Location = new Point(32, 336);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(94, 29);
            btnAll.TabIndex = 1;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // btnOfficers
            // 
            btnOfficers.BackColor = SystemColors.ActiveCaptionText;
            btnOfficers.ForeColor = SystemColors.ControlLightLight;
            btnOfficers.Location = new Point(32, 219);
            btnOfficers.Name = "btnOfficers";
            btnOfficers.Size = new Size(94, 29);
            btnOfficers.TabIndex = 2;
            btnOfficers.Text = "Officers";
            btnOfficers.UseVisualStyleBackColor = false;
            btnOfficers.Click += btnOfficers_Click;
            // 
            // btnConscripts
            // 
            btnConscripts.BackColor = SystemColors.ActiveCaptionText;
            btnConscripts.ForeColor = SystemColors.ControlLightLight;
            btnConscripts.Location = new Point(32, 275);
            btnConscripts.Name = "btnConscripts";
            btnConscripts.Size = new Size(94, 29);
            btnConscripts.TabIndex = 3;
            btnConscripts.Text = "Conscripts";
            btnConscripts.UseVisualStyleBackColor = false;
            btnConscripts.Click += btnConscripts_Click;
            // 
            // btnSort
            // 
            btnSort.BackColor = SystemColors.ActiveCaptionText;
            btnSort.ForeColor = SystemColors.ControlLightLight;
            btnSort.Location = new Point(32, 395);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(94, 29);
            btnSort.TabIndex = 4;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaptionText;
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(109, 61);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Coral;
            btnDelete.Location = new Point(502, 61);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaptionText;
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Location = new Point(296, 61);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(32, 149);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 126);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 9;
            label1.Text = "Пошук за прізвищем";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSort);
            Controls.Add(btnConscripts);
            Controls.Add(btnOfficers);
            Controls.Add(btnAll);
            Controls.Add(dgvSoldiers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSoldiers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSoldiers;
        private Button btnAll;
        private Button btnOfficers;
        private Button btnConscripts;
        private Button btnSort;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtSearch;
        private Label label1;
    }
}
