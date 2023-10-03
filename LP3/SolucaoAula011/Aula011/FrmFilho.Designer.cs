namespace Aula011
{
    partial class FrmFilho
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
            this.btnAqui = new System.Windows.Forms.Button();
            this.btnNwjns = new System.Windows.Forms.Button();
            this.btnSserafinas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAqui
            // 
            this.btnAqui.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAqui.ForeColor = System.Drawing.Color.Red;
            this.btnAqui.Location = new System.Drawing.Point(152, 78);
            this.btnAqui.Name = "btnAqui";
            this.btnAqui.Size = new System.Drawing.Size(143, 76);
            this.btnAqui.TabIndex = 0;
            this.btnAqui.Text = "IVE";
            this.btnAqui.UseVisualStyleBackColor = true;
            this.btnAqui.Click += new System.EventHandler(this.btnAqui_Click);
            // 
            // btnNwjns
            // 
            this.btnNwjns.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNwjns.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNwjns.Location = new System.Drawing.Point(152, 184);
            this.btnNwjns.Name = "btnNwjns";
            this.btnNwjns.Size = new System.Drawing.Size(143, 76);
            this.btnNwjns.TabIndex = 1;
            this.btnNwjns.Text = "NewJeans";
            this.btnNwjns.UseVisualStyleBackColor = true;
            this.btnNwjns.Click += new System.EventHandler(this.btnNwjns_Click);
            // 
            // btnSserafinas
            // 
            this.btnSserafinas.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSserafinas.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnSserafinas.Location = new System.Drawing.Point(152, 291);
            this.btnSserafinas.Name = "btnSserafinas";
            this.btnSserafinas.Size = new System.Drawing.Size(143, 76);
            this.btnSserafinas.TabIndex = 2;
            this.btnSserafinas.Text = "le sserafim";
            this.btnSserafinas.UseVisualStyleBackColor = true;
            this.btnSserafinas.Click += new System.EventHandler(this.btnSserafinas_Click);
            // 
            // FrmFilho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.btnSserafinas);
            this.Controls.Add(this.btnNwjns);
            this.Controls.Add(this.btnAqui);
            this.Name = "FrmFilho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janela";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAqui;
        private Button btnNwjns;
        private Button btnSserafinas;
    }
}