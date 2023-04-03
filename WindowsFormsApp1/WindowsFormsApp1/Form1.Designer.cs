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
            this.LB_GameName = new System.Windows.Forms.Label();
            this.TB_GridSize = new System.Windows.Forms.TextBox();
            this.BTN_EnterGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_GameName
            // 
            this.LB_GameName.AutoSize = true;
            this.LB_GameName.Location = new System.Drawing.Point(157, 48);
            this.LB_GameName.Name = "LB_GameName";
            this.LB_GameName.Size = new System.Drawing.Size(83, 13);
            this.LB_GameName.TabIndex = 0;
            this.LB_GameName.Text = "PUZZLE GAME";
            // 
            // TB_GridSize
            // 
            this.TB_GridSize.Location = new System.Drawing.Point(149, 79);
            this.TB_GridSize.Name = "TB_GridSize";
            this.TB_GridSize.Size = new System.Drawing.Size(100, 20);
            this.TB_GridSize.TabIndex = 1;
            // 
            // BTN_EnterGame
            // 
            this.BTN_EnterGame.Location = new System.Drawing.Point(160, 122);
            this.BTN_EnterGame.Name = "BTN_EnterGame";
            this.BTN_EnterGame.Size = new System.Drawing.Size(75, 23);
            this.BTN_EnterGame.TabIndex = 2;
            this.BTN_EnterGame.Text = "PLAY |>";
            this.BTN_EnterGame.UseVisualStyleBackColor = true;
            this.BTN_EnterGame.Click += new System.EventHandler(this.BTN_EnterGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 239);
            this.Controls.Add(this.BTN_EnterGame);
            this.Controls.Add(this.TB_GridSize);
            this.Controls.Add(this.LB_GameName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_GameName;
        private System.Windows.Forms.TextBox TB_GridSize;
        private System.Windows.Forms.Button BTN_EnterGame;
    }
}

