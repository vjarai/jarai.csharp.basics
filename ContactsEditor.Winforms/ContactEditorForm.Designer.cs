namespace Jarai.CSharp.EntityFrameworkCore.CodeFirst
{
    partial class ContactEditorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(607, 407);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 370);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(93, 370);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(497, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ContactEditorForm
            // 
            ClientSize = new Size(631, 468);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "ContactEditorForm";
            Text = "Contact Editor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}
