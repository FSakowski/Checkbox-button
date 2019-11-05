namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxBtn1 = new WindowsFormsApp2.CheckBoxBtn();
            this.checkBoxBtn2 = new WindowsFormsApp2.CheckBoxBtn();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Checkbox (1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Checkbox (2)";
            // 
            // checkBoxBtn1
            // 
            this.checkBoxBtn1.FlatAppearance.BorderSize = 0;
            this.checkBoxBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxBtn1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.checkBoxBtn1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxBtn1.Location = new System.Drawing.Point(245, 54);
            this.checkBoxBtn1.Name = "checkBoxBtn1";
            this.checkBoxBtn1.Size = new System.Drawing.Size(30, 30);
            this.checkBoxBtn1.TabIndex = 7;
            this.checkBoxBtn1.Text = "";
            this.checkBoxBtn1.UseVisualStyleBackColor = true;
            this.checkBoxBtn1.CheckedChanged += new System.EventHandler(this.checkBoxBtn1_CheckedChanged);
            // 
            // checkBoxBtn2
            // 
            this.checkBoxBtn2.Checked = true;
            this.checkBoxBtn2.FlatAppearance.BorderSize = 0;
            this.checkBoxBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxBtn2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.checkBoxBtn2.Location = new System.Drawing.Point(245, 167);
            this.checkBoxBtn2.Name = "checkBoxBtn2";
            this.checkBoxBtn2.Size = new System.Drawing.Size(30, 30);
            this.checkBoxBtn2.TabIndex = 8;
            this.checkBoxBtn2.Text = "";
            this.checkBoxBtn2.UseVisualStyleBackColor = true;
            this.checkBoxBtn2.CheckedChanged += new System.EventHandler(this.checkBoxBtn2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 253);
            this.Controls.Add(this.checkBoxBtn2);
            this.Controls.Add(this.checkBoxBtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sample custom checkbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CheckBoxBtn checkBoxBtn1;
        private CheckBoxBtn checkBoxBtn2;
    }
}

