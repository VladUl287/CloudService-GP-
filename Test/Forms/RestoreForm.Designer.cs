
namespace Test
{
    partial class RestoreForm
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
            this.btnRestore = new System.Windows.Forms.Button();
            this.lbRestore = new System.Windows.Forms.Label();
            this.tbRestore = new System.Windows.Forms.TextBox();
            this.panelRestore = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(389, 337);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(177, 33);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "Восстановить";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // lbRestore
            // 
            this.lbRestore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbRestore.AutoSize = true;
            this.lbRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRestore.ForeColor = System.Drawing.Color.White;
            this.lbRestore.Location = new System.Drawing.Point(12, 146);
            this.lbRestore.Name = "lbRestore";
            this.lbRestore.Size = new System.Drawing.Size(102, 20);
            this.lbRestore.TabIndex = 37;
            this.lbRestore.Text = "Email/Логин:";
            // 
            // tbRestore
            // 
            this.tbRestore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.tbRestore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRestore.ForeColor = System.Drawing.Color.White;
            this.tbRestore.Location = new System.Drawing.Point(120, 146);
            this.tbRestore.MaxLength = 150;
            this.tbRestore.Multiline = true;
            this.tbRestore.Name = "tbRestore";
            this.tbRestore.Size = new System.Drawing.Size(446, 20);
            this.tbRestore.TabIndex = 36;
            // 
            // panelRestore
            // 
            this.panelRestore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.panelRestore.ForeColor = System.Drawing.Color.White;
            this.panelRestore.Location = new System.Drawing.Point(120, 168);
            this.panelRestore.Name = "panelRestore";
            this.panelRestore.Size = new System.Drawing.Size(446, 1);
            this.panelRestore.TabIndex = 35;
            // 
            // RestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(578, 382);
            this.Controls.Add(this.lbRestore);
            this.Controls.Add(this.tbRestore);
            this.Controls.Add(this.panelRestore);
            this.Controls.Add(this.btnRestore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestoreForm";
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lbRestore;
        private System.Windows.Forms.TextBox tbRestore;
        private System.Windows.Forms.Panel panelRestore;
    }
}