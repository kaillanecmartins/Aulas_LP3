namespace Aula007
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEngorda = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEmagrace = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(31, 18);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(261, 22);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo do Animal de Estimação:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(31, 101);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(275, 22);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Animal de Estimação:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.Location = new System.Drawing.Point(31, 192);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(269, 22);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso do Animal de Estimação:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.Location = new System.Drawing.Point(32, 292);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(132, 43);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEngorda
            // 
            this.btnEngorda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEngorda.Location = new System.Drawing.Point(32, 351);
            this.btnEngorda.Name = "btnEngorda";
            this.btnEngorda.Size = new System.Drawing.Size(132, 41);
            this.btnEngorda.TabIndex = 4;
            this.btnEngorda.Text = "ENGORDA";
            this.btnEngorda.UseVisualStyleBackColor = true;
            this.btnEngorda.Click += new System.EventHandler(this.btnEngorda_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(245, 292);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(132, 43);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEmagrace
            // 
            this.btnEmagrace.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmagrace.Location = new System.Drawing.Point(245, 351);
            this.btnEmagrace.Name = "btnEmagrace";
            this.btnEmagrace.Size = new System.Drawing.Size(132, 41);
            this.btnEmagrace.TabIndex = 6;
            this.btnEmagrace.Text = "EMAGRECE";
            this.btnEmagrace.UseVisualStyleBackColor = true;
            this.btnEmagrace.Click += new System.EventHandler(this.btnEmagrace_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipo.Location = new System.Drawing.Point(31, 54);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(215, 26);
            this.txtTipo.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(31, 144);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 26);
            this.txtNome.TabIndex = 8;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPeso.Location = new System.Drawing.Point(31, 229);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(215, 26);
            this.txtPeso.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 420);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnEmagrace);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEngorda);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTipo);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Animais de Estimação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTipo;
        private Label lblNome;
        private Label lblPeso;
        private Button btnMostrar;
        private Button btnEngorda;
        private Button btnLimpar;
        private Button btnEmagrace;
        private TextBox txtTipo;
        private TextBox txtNome;
        private TextBox txtPeso;
    }
}