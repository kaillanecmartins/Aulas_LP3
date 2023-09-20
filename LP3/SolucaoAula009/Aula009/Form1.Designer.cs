namespace Aula009
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
            this.cmbSalgados = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPreparo = new System.Windows.Forms.GroupBox();
            this.rdbAssado = new System.Windows.Forms.RadioButton();
            this.rdbFrito = new System.Windows.Forms.RadioButton();
            this.gbAcompanhamento = new System.Windows.Forms.GroupBox();
            this.ckbRefrigerante = new System.Windows.Forms.CheckBox();
            this.ckbSuco = new System.Windows.Forms.CheckBox();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.gbPreparo.SuspendLayout();
            this.gbAcompanhamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSalgados
            // 
            this.cmbSalgados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalgados.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSalgados.FormattingEnabled = true;
            this.cmbSalgados.Items.AddRange(new object[] {
            "Coxinha",
            "Empanado",
            "Kibe",
            "Pastel"});
            this.cmbSalgados.Location = new System.Drawing.Point(214, 41);
            this.cmbSalgados.Name = "cmbSalgados";
            this.cmbSalgados.Size = new System.Drawing.Size(239, 35);
            this.cmbSalgados.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.Location = new System.Drawing.Point(172, 383);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(142, 38);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salgados:";
            // 
            // gbPreparo
            // 
            this.gbPreparo.Controls.Add(this.rdbAssado);
            this.gbPreparo.Controls.Add(this.rdbFrito);
            this.gbPreparo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbPreparo.ForeColor = System.Drawing.Color.IndianRed;
            this.gbPreparo.Location = new System.Drawing.Point(25, 100);
            this.gbPreparo.Name = "gbPreparo";
            this.gbPreparo.Size = new System.Drawing.Size(405, 100);
            this.gbPreparo.TabIndex = 3;
            this.gbPreparo.TabStop = false;
            this.gbPreparo.Text = "Preparo";
            // 
            // rdbAssado
            // 
            this.rdbAssado.AutoSize = true;
            this.rdbAssado.Location = new System.Drawing.Point(245, 48);
            this.rdbAssado.Name = "rdbAssado";
            this.rdbAssado.Size = new System.Drawing.Size(109, 31);
            this.rdbAssado.TabIndex = 1;
            this.rdbAssado.Text = "Assado";
            this.rdbAssado.UseVisualStyleBackColor = true;
            // 
            // rdbFrito
            // 
            this.rdbFrito.AutoSize = true;
            this.rdbFrito.Checked = true;
            this.rdbFrito.Location = new System.Drawing.Point(30, 48);
            this.rdbFrito.Name = "rdbFrito";
            this.rdbFrito.Size = new System.Drawing.Size(78, 31);
            this.rdbFrito.TabIndex = 0;
            this.rdbFrito.TabStop = true;
            this.rdbFrito.Text = "Frito";
            this.rdbFrito.UseVisualStyleBackColor = true;
            // 
            // gbAcompanhamento
            // 
            this.gbAcompanhamento.Controls.Add(this.ckbChocolate);
            this.gbAcompanhamento.Controls.Add(this.ckbSuco);
            this.gbAcompanhamento.Controls.Add(this.ckbRefrigerante);
            this.gbAcompanhamento.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbAcompanhamento.ForeColor = System.Drawing.Color.IndianRed;
            this.gbAcompanhamento.Location = new System.Drawing.Point(25, 223);
            this.gbAcompanhamento.Name = "gbAcompanhamento";
            this.gbAcompanhamento.Size = new System.Drawing.Size(436, 100);
            this.gbAcompanhamento.TabIndex = 4;
            this.gbAcompanhamento.TabStop = false;
            this.gbAcompanhamento.Text = "Acompanhamentos";
            this.gbAcompanhamento.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ckbRefrigerante
            // 
            this.ckbRefrigerante.AutoSize = true;
            this.ckbRefrigerante.Location = new System.Drawing.Point(12, 53);
            this.ckbRefrigerante.Name = "ckbRefrigerante";
            this.ckbRefrigerante.Size = new System.Drawing.Size(163, 31);
            this.ckbRefrigerante.TabIndex = 0;
            this.ckbRefrigerante.Text = "Refrigerante";
            this.ckbRefrigerante.UseVisualStyleBackColor = true;
            // 
            // ckbSuco
            // 
            this.ckbSuco.AutoSize = true;
            this.ckbSuco.Location = new System.Drawing.Point(181, 53);
            this.ckbSuco.Name = "ckbSuco";
            this.ckbSuco.Size = new System.Drawing.Size(86, 31);
            this.ckbSuco.TabIndex = 1;
            this.ckbSuco.Text = "Suco";
            this.ckbSuco.UseVisualStyleBackColor = true;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(273, 53);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(139, 31);
            this.ckbChocolate.TabIndex = 2;
            this.ckbChocolate.Text = "Chocolate";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 433);
            this.Controls.Add(this.gbAcompanhamento);
            this.Controls.Add(this.gbPreparo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmbSalgados);
            this.Name = "Form1";
            this.Text = "Cadastro de Salgados";
            this.gbPreparo.ResumeLayout(false);
            this.gbPreparo.PerformLayout();
            this.gbAcompanhamento.ResumeLayout(false);
            this.gbAcompanhamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbSalgados;
        private Button btnMostrar;
        private Label label1;
        private GroupBox gbPreparo;
        private RadioButton rdbAssado;
        private RadioButton rdbFrito;
        private GroupBox gbAcompanhamento;
        private CheckBox ckbChocolate;
        private CheckBox ckbSuco;
        private CheckBox ckbRefrigerante;
    }
}