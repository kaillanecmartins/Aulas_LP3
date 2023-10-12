namespace ProjetoCondominioJupiter
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
            this.menuFuncoes = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porApartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFuncoes
            // 
            this.menuFuncoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuFuncoes.Location = new System.Drawing.Point(0, 0);
            this.menuFuncoes.Name = "menuFuncoes";
            this.menuFuncoes.Size = new System.Drawing.Size(1029, 24);
            this.menuFuncoes.TabIndex = 1;
            this.menuFuncoes.Text = "menuFuncoes";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartamentoToolStripMenuItem,
            this.petToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // apartamentoToolStripMenuItem
            // 
            this.apartamentoToolStripMenuItem.Name = "apartamentoToolStripMenuItem";
            this.apartamentoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.apartamentoToolStripMenuItem.Text = "Apartamento";
            // 
            // petToolStripMenuItem
            // 
            this.petToolStripMenuItem.Name = "petToolStripMenuItem";
            this.petToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.petToolStripMenuItem.Text = "Pet";
            this.petToolStripMenuItem.Click += new System.EventHandler(this.petToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porPetToolStripMenuItem,
            this.porApartamentoToolStripMenuItem});
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // porPetToolStripMenuItem
            // 
            this.porPetToolStripMenuItem.Name = "porPetToolStripMenuItem";
            this.porPetToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.porPetToolStripMenuItem.Text = "Por Pet";
            // 
            // porApartamentoToolStripMenuItem
            // 
            this.porApartamentoToolStripMenuItem.Name = "porApartamentoToolStripMenuItem";
            this.porApartamentoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.porApartamentoToolStripMenuItem.Text = "Por Apartamento";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sairToolStripMenuItem.Text = "Ajuda";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 540);
            this.Controls.Add(this.menuFuncoes);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuFuncoes;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sistema de Cadastro de Pets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuFuncoes.ResumeLayout(false);
            this.menuFuncoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuFuncoes;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem apartamentoToolStripMenuItem;
        private ToolStripMenuItem petToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem porPetToolStripMenuItem;
        private ToolStripMenuItem porApartamentoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
    }
}