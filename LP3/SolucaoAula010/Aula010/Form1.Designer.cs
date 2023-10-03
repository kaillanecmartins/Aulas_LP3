namespace Aula010
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.rdbFemea = new System.Windows.Forms.RadioButton();
            this.rdbMacho = new System.Windows.Forms.RadioButton();
            this.gpbComplemento = new System.Windows.Forms.GroupBox();
            this.chkCastrado = new System.Windows.Forms.CheckBox();
            this.chkVacinado = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbGenero.SuspendLayout();
            this.gpbComplemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(334, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 321);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Raça:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Espécie:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Items.AddRange(new object[] {
            "Cão",
            "Gato",
            "Passaro",
            "Roedor"});
            this.cmbEspecie.Location = new System.Drawing.Point(114, 89);
            this.cmbEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(224, 26);
            this.cmbEspecie.TabIndex = 6;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(114, 146);
            this.txtRaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(224, 26);
            this.txtRaca.TabIndex = 7;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(114, 313);
            this.txtCor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(224, 26);
            this.txtCor.TabIndex = 8;
            this.txtCor.TextChanged += new System.EventHandler(this.txtCor_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 29);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 26);
            this.txtNome.TabIndex = 9;
            // 
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.rdbFemea);
            this.gpbGenero.Controls.Add(this.rdbMacho);
            this.gpbGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbGenero.Location = new System.Drawing.Point(37, 204);
            this.gpbGenero.Margin = new System.Windows.Forms.Padding(4);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Padding = new System.Windows.Forms.Padding(4);
            this.gpbGenero.Size = new System.Drawing.Size(342, 82);
            this.gpbGenero.TabIndex = 10;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Gênero";
            // 
            // rdbFemea
            // 
            this.rdbFemea.AutoSize = true;
            this.rdbFemea.Location = new System.Drawing.Point(186, 38);
            this.rdbFemea.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFemea.Name = "rdbFemea";
            this.rdbFemea.Size = new System.Drawing.Size(70, 22);
            this.rdbFemea.TabIndex = 1;
            this.rdbFemea.Text = "fêmea";
            this.rdbFemea.UseVisualStyleBackColor = true;
            // 
            // rdbMacho
            // 
            this.rdbMacho.AutoSize = true;
            this.rdbMacho.Checked = true;
            this.rdbMacho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbMacho.Location = new System.Drawing.Point(22, 38);
            this.rdbMacho.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMacho.Name = "rdbMacho";
            this.rdbMacho.Size = new System.Drawing.Size(73, 22);
            this.rdbMacho.TabIndex = 0;
            this.rdbMacho.TabStop = true;
            this.rdbMacho.Text = "macho";
            this.rdbMacho.UseVisualStyleBackColor = true;
            // 
            // gpbComplemento
            // 
            this.gpbComplemento.Controls.Add(this.chkCastrado);
            this.gpbComplemento.Controls.Add(this.chkVacinado);
            this.gpbComplemento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbComplemento.Location = new System.Drawing.Point(37, 380);
            this.gpbComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.gpbComplemento.Name = "gpbComplemento";
            this.gpbComplemento.Padding = new System.Windows.Forms.Padding(4);
            this.gpbComplemento.Size = new System.Drawing.Size(342, 101);
            this.gpbComplemento.TabIndex = 11;
            this.gpbComplemento.TabStop = false;
            this.gpbComplemento.Text = "Observações";
            // 
            // chkCastrado
            // 
            this.chkCastrado.AutoSize = true;
            this.chkCastrado.Location = new System.Drawing.Point(186, 48);
            this.chkCastrado.Margin = new System.Windows.Forms.Padding(4);
            this.chkCastrado.Name = "chkCastrado";
            this.chkCastrado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCastrado.Size = new System.Drawing.Size(92, 22);
            this.chkCastrado.TabIndex = 1;
            this.chkCastrado.Text = "Castrado";
            this.chkCastrado.UseVisualStyleBackColor = true;
            // 
            // chkVacinado
            // 
            this.chkVacinado.AutoSize = true;
            this.chkVacinado.Location = new System.Drawing.Point(24, 48);
            this.chkVacinado.Margin = new System.Windows.Forms.Padding(4);
            this.chkVacinado.Name = "chkVacinado";
            this.chkVacinado.Size = new System.Drawing.Size(93, 22);
            this.chkVacinado.TabIndex = 0;
            this.chkVacinado.Text = "Vacinado";
            this.chkVacinado.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(28, 533);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 37);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(334, 533);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(125, 37);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 602);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gpbComplemento);
            this.Controls.Add(this.gpbGenero);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Cadastro de Pet";
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            this.gpbComplemento.ResumeLayout(false);
            this.gpbComplemento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private ComboBox cmbEspecie;
        private TextBox txtRaca;
        private TextBox txtCor;
        private TextBox txtNome;
        private GroupBox gpbGenero;
        private RadioButton rdbFemea;
        private RadioButton rdbMacho;
        private GroupBox gpbComplemento;
        private CheckBox chkCastrado;
        private CheckBox chkVacinado;
        private Button btnLimpar;
        private Button btnSalvar;
    }
}