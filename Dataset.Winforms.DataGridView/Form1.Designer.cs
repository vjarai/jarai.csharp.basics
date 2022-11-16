using Microsoft.Data.SqlClient;

public partial class Form1 : Form
{
    private DataGridView dataGridView1 = new DataGridView();
    private BindingSource bindingSource1 = new BindingSource();
    private SqlDataAdapter dataAdapter = new SqlDataAdapter();
    private Button reloadButton = new Button();
    private Button submitButton = new Button();

    private System.ComponentModel.IContainer components = null;

    private void InitializeComponent()
    {
        this.SuspendLayout();
        // 
        // Form1
        // 
        this.components = new System.ComponentModel.Container();
        this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Name = "Form1";
        this.Text = "Form1";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.ResumeLayout(false);

    }
    private void InitializeComponent2()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form2";
    }
}
