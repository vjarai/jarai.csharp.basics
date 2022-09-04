namespace Jarai.CSharp.Calculator.UserInterface.WinForms
{
   partial class CalculatorForm
   {
      /// <summary>
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label zahl1Label;
            System.Windows.Forms.Label zahl2Label;
            System.Windows.Forms.Label ergebnisLabel;
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.zahl1TextBox = new System.Windows.Forms.TextBox();
            this.zahl2TextBox = new System.Windows.Forms.TextBox();
            this.ergebnisLabel1 = new System.Windows.Forms.Label();
            this.calculatorViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            zahl1Label = new System.Windows.Forms.Label();
            zahl2Label = new System.Windows.Forms.Label();
            ergebnisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(308, 37);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(308, 82);
            this.subtractButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(112, 35);
            this.subtractButton.TabIndex = 1;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(308, 126);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(112, 35);
            this.multiplyButton.TabIndex = 2;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(308, 171);
            this.divideButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(112, 35);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // zahl1Label
            // 
            zahl1Label.AutoSize = true;
            zahl1Label.Location = new System.Drawing.Point(38, 49);
            zahl1Label.Name = "zahl1Label";
            zahl1Label.Size = new System.Drawing.Size(53, 20);
            zahl1Label.TabIndex = 5;
            zahl1Label.Text = "Zahl1:";
            // 
            // zahl1TextBox
            // 
            this.zahl1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calculatorViewModelBindingSource, "Zahl1", true));
            this.zahl1TextBox.Location = new System.Drawing.Point(97, 46);
            this.zahl1TextBox.Name = "zahl1TextBox";
            this.zahl1TextBox.Size = new System.Drawing.Size(100, 26);
            this.zahl1TextBox.TabIndex = 6;
            // 
            // zahl2Label
            // 
            zahl2Label.AutoSize = true;
            zahl2Label.Location = new System.Drawing.Point(38, 94);
            zahl2Label.Name = "zahl2Label";
            zahl2Label.Size = new System.Drawing.Size(53, 20);
            zahl2Label.TabIndex = 7;
            zahl2Label.Text = "Zahl2:";
            // 
            // zahl2TextBox
            // 
            this.zahl2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calculatorViewModelBindingSource, "Zahl2", true));
            this.zahl2TextBox.Location = new System.Drawing.Point(97, 91);
            this.zahl2TextBox.Name = "zahl2TextBox";
            this.zahl2TextBox.Size = new System.Drawing.Size(100, 26);
            this.zahl2TextBox.TabIndex = 8;
            // 
            // ergebnisLabel
            // 
            ergebnisLabel.AutoSize = true;
            ergebnisLabel.Location = new System.Drawing.Point(15, 183);
            ergebnisLabel.Name = "ergebnisLabel";
            ergebnisLabel.Size = new System.Drawing.Size(76, 20);
            ergebnisLabel.TabIndex = 9;
            ergebnisLabel.Text = "Ergebnis:";
            // 
            // ergebnisLabel1
            // 
            this.ergebnisLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calculatorViewModelBindingSource, "Ergebnis", true));
            this.ergebnisLabel1.Location = new System.Drawing.Point(97, 183);
            this.ergebnisLabel1.Name = "ergebnisLabel1";
            this.ergebnisLabel1.Size = new System.Drawing.Size(100, 23);
            this.ergebnisLabel1.TabIndex = 10;
            this.ergebnisLabel1.Text = "label1";
            // 
            // calculatorViewModelBindingSource
            // 
            this.calculatorViewModelBindingSource.DataSource = typeof(Jarai.CSharp.Calculator.UserInterface.WinForms.CalculatorViewModel);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 262);
            this.Controls.Add(ergebnisLabel);
            this.Controls.Add(this.ergebnisLabel1);
            this.Controls.Add(zahl2Label);
            this.Controls.Add(this.zahl2TextBox);
            this.Controls.Add(zahl1Label);
            this.Controls.Add(this.zahl1TextBox);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalculatorForm";
            this.Text = "CalculationService";
            ((System.ComponentModel.ISupportInitialize)(this.calculatorViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button addButton;
      private System.Windows.Forms.Button subtractButton;
      private System.Windows.Forms.Button multiplyButton;
      private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.BindingSource calculatorViewModelBindingSource;
        private System.Windows.Forms.TextBox zahl1TextBox;
        private System.Windows.Forms.TextBox zahl2TextBox;
        private System.Windows.Forms.Label ergebnisLabel1;
    }
}

