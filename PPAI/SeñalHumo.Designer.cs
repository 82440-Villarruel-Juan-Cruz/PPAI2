namespace PPAI
{
    partial class SeñalHumo
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
            this.gifHumo = new System.Windows.Forms.PictureBox();
            this.btnSeñalesHumo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gifHumo)).BeginInit();
            this.SuspendLayout();
            // 
            // gifHumo
            // 
            this.gifHumo.Location = new System.Drawing.Point(12, 12);
            this.gifHumo.Name = "gifHumo";
            this.gifHumo.Size = new System.Drawing.Size(316, 330);
            this.gifHumo.TabIndex = 20;
            this.gifHumo.TabStop = false;
            // 
            // btnSeñalesHumo
            // 
            this.btnSeñalesHumo.FlatAppearance.BorderSize = 0;
            this.btnSeñalesHumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeñalesHumo.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeñalesHumo.Location = new System.Drawing.Point(91, 348);
            this.btnSeñalesHumo.Name = "btnSeñalesHumo";
            this.btnSeñalesHumo.Size = new System.Drawing.Size(154, 53);
            this.btnSeñalesHumo.TabIndex = 21;
            this.btnSeñalesHumo.Text = "Fin de Señales";
            this.btnSeñalesHumo.UseVisualStyleBackColor = true;
            this.btnSeñalesHumo.Click += new System.EventHandler(this.btnSeñalesHumo_Click);
            // 
            // SeñalHumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(340, 413);
            this.Controls.Add(this.btnSeñalesHumo);
            this.Controls.Add(this.gifHumo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeñalHumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeñalHumo";
            this.Load += new System.EventHandler(this.SeñalHumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gifHumo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gifHumo;
        private System.Windows.Forms.Button btnSeñalesHumo;
    }
}