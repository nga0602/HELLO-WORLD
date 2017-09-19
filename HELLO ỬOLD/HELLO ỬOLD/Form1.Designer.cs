namespace HELLO_ỬOLD
{
    partial class FRMHELLOWORLD
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
            this.LBLHELLOWORLD = new System.Windows.Forms.Label();
            this.BTNSHOW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLHELLOWORLD
            // 
            this.LBLHELLOWORLD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBLHELLOWORLD.AutoSize = true;
            this.LBLHELLOWORLD.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHELLOWORLD.Location = new System.Drawing.Point(35, 83);
            this.LBLHELLOWORLD.Name = "LBLHELLOWORLD";
            this.LBLHELLOWORLD.Size = new System.Drawing.Size(0, 61);
            this.LBLHELLOWORLD.TabIndex = 0;
            this.LBLHELLOWORLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNSHOW
            // 
            this.BTNSHOW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNSHOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSHOW.ForeColor = System.Drawing.Color.Red;
            this.BTNSHOW.Location = new System.Drawing.Point(126, 268);
            this.BTNSHOW.Name = "BTNSHOW";
            this.BTNSHOW.Size = new System.Drawing.Size(176, 36);
            this.BTNSHOW.TabIndex = 1;
            this.BTNSHOW.Text = "SHOW HELLO WORLD";
            this.BTNSHOW.UseVisualStyleBackColor = true;
            this.BTNSHOW.Click += new System.EventHandler(this.BTNSHOW_Click);
            // 
            // FRMHELLOWORLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 316);
            this.Controls.Add(this.BTNSHOW);
            this.Controls.Add(this.LBLHELLOWORLD);
            this.MinimumSize = new System.Drawing.Size(400, 340);
            this.Name = "FRMHELLOWORLD";
            this.Text = "HELLO WORLD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLHELLOWORLD;
        private System.Windows.Forms.Button BTNSHOW;
    }
}

