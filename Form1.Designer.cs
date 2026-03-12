namespace CatchButton
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
            btnCatch = new Button();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // btnCatch
            // 
            btnCatch.BackColor = Color.RosyBrown;
            btnCatch.Font = new Font("맑은 고딕", 23F);
            btnCatch.Location = new Point(729, 547);
            btnCatch.Margin = new Padding(7, 8, 7, 8);
            btnCatch.Name = "btnCatch";
            btnCatch.Size = new Size(418, 223);
            btnCatch.TabIndex = 0;
            btnCatch.Text = "Catch Me";
            btnCatch.UseVisualStyleBackColor = false;
            btnCatch.Click += btnCatch_Click;
            btnCatch.MouseEnter += btnCatch_MouseEnter;
            // 
            // btnRestart
            // 
            btnRestart.Anchor = AnchorStyles.Bottom;
            btnRestart.Location = new Point(826, 1093);
            btnRestart.Margin = new Padding(7, 8, 7, 8);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(291, 96);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "다시 시작";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1943, 1230);
            Controls.Add(btnCatch);
            Controls.Add(btnRestart);
            Cursor = Cursors.Hand;
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "숨바꼭질 버튼";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCatch;
        private System.Windows.Forms.Button btnRestart;
    }
}
