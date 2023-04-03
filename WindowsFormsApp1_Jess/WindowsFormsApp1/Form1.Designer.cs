namespace WindowsFormsApp1
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
            this.button_PindahForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_PindahForm
            // 
            this.button_PindahForm.Location = new System.Drawing.Point(150, 126);
            this.button_PindahForm.Name = "button_PindahForm";
            this.button_PindahForm.Size = new System.Drawing.Size(75, 23);
            this.button_PindahForm.TabIndex = 0;
            this.button_PindahForm.Text = "Next";
            this.button_PindahForm.UseVisualStyleBackColor = true;
            this.button_PindahForm.Click += new System.EventHandler(this.button_PindahForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input number of N";
            // 
            // textBox_N
            // 
            this.textBox_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_N.Location = new System.Drawing.Point(150, 80);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(75, 31);
            this.textBox_N.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 202);
            this.Controls.Add(this.textBox_N);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_PindahForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_PindahForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_N;
    }
}

