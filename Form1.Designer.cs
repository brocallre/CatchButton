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
            this.btnCatch = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // btnCatch - 잡아야 할 버튼
            //
            this.btnCatch.Location = new System.Drawing.Point(300, 200);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(120, 40);
            this.btnCatch.TabIndex = 0;
            this.btnCatch.Text = "나를 잡아봐";
            this.btnCatch.UseVisualStyleBackColor = true;
            this.btnCatch.MouseEnter += new System.EventHandler(this.btnCatch_MouseEnter);
            this.btnCatch.Click += new System.EventHandler(this.btnCatch_Click);
            //
            // btnRestart - 다시 시작 버튼
            //
            this.btnRestart.Location = new System.Drawing.Point(340, 400);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(120, 35);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "다시 시작";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            //
            // Form1 - 메인 폼
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCatch);
            this.Controls.Add(this.btnRestart);
            this.Name = "Form1";
            this.Text = "숨바꼭질 버튼";
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCatch;
        private System.Windows.Forms.Button btnRestart;
    }
}
