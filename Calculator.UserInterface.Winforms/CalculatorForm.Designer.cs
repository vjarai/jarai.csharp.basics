namespace Jarai.Calculator.UserInterface.WinForms
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
         System.Windows.Forms.Label operand1Label;
         System.Windows.Forms.Label operand2Label;
         System.Windows.Forms.Label ergebnisLabel;
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.operand1TextBox = new System.Windows.Forms.TextBox();
         this.operand2TextBox = new System.Windows.Forms.TextBox();
         this.ergebnisTextBox = new System.Windows.Forms.TextBox();
         this.button5 = new System.Windows.Forms.Button();
         operand1Label = new System.Windows.Forms.Label();
         operand2Label = new System.Windows.Forms.Label();
         ergebnisLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // operand1Label
         // 
         operand1Label.AutoSize = true;
         operand1Label.Location = new System.Drawing.Point(11, 31);
         operand1Label.Name = "operand1Label";
         operand1Label.Size = new System.Drawing.Size(57, 13);
         operand1Label.TabIndex = 5;
         operand1Label.Text = "Operand1:";
         // 
         // operand2Label
         // 
         operand2Label.AutoSize = true;
         operand2Label.Location = new System.Drawing.Point(11, 59);
         operand2Label.Name = "operand2Label";
         operand2Label.Size = new System.Drawing.Size(57, 13);
         operand2Label.TabIndex = 7;
         operand2Label.Text = "Operand2:";
         // 
         // ergebnisLabel
         // 
         ergebnisLabel.AutoSize = true;
         ergebnisLabel.Location = new System.Drawing.Point(17, 88);
         ergebnisLabel.Name = "ergebnisLabel";
         ergebnisLabel.Size = new System.Drawing.Size(51, 13);
         ergebnisLabel.TabIndex = 9;
         ergebnisLabel.Text = "Ergebnis:";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(205, 24);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 0;
         this.button1.Text = "+";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(205, 53);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 1;
         this.button2.Text = "-";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(205, 82);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 2;
         this.button3.Text = "*";
         this.button3.UseVisualStyleBackColor = true;
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(205, 111);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(75, 23);
         this.button4.TabIndex = 3;
         this.button4.Text = "/";
         this.button4.UseVisualStyleBackColor = true;
         // 
         // operand1TextBox
         // 
         this.operand1TextBox.Location = new System.Drawing.Point(74, 28);
         this.operand1TextBox.Name = "operand1TextBox";
         this.operand1TextBox.Size = new System.Drawing.Size(100, 20);
         this.operand1TextBox.TabIndex = 6;
         // 
         // operand2TextBox
         // 
         this.operand2TextBox.Location = new System.Drawing.Point(74, 56);
         this.operand2TextBox.Name = "operand2TextBox";
         this.operand2TextBox.Size = new System.Drawing.Size(100, 20);
         this.operand2TextBox.TabIndex = 8;
         // 
         // ergebnisTextBox
         // 
         this.ergebnisTextBox.Location = new System.Drawing.Point(74, 85);
         this.ergebnisTextBox.Name = "ergebnisTextBox";
         this.ergebnisTextBox.Size = new System.Drawing.Size(100, 20);
         this.ergebnisTextBox.TabIndex = 10;
         // 
         // button5
         // 
         this.button5.Location = new System.Drawing.Point(205, 140);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(75, 23);
         this.button5.TabIndex = 11;
         this.button5.Text = "Async";
         this.button5.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(300, 165);
         this.Controls.Add(this.button5);
         this.Controls.Add(ergebnisLabel);
         this.Controls.Add(this.ergebnisTextBox);
         this.Controls.Add(operand2Label);
         this.Controls.Add(this.operand2TextBox);
         this.Controls.Add(operand1Label);
         this.Controls.Add(this.operand1TextBox);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Name = "Form1";
         this.Text = "CalculationService";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.TextBox operand1TextBox;
      private System.Windows.Forms.TextBox operand2TextBox;
      private System.Windows.Forms.TextBox ergebnisTextBox;
      private System.Windows.Forms.Button button5;
   }
}

