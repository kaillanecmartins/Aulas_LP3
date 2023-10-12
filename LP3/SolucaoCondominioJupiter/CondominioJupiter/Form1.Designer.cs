namespace CondominioJupiter
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condominioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porApartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porApartamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.pesquisaToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.condominioToolStripMenuItem,
            this.torresToolStripMenuItem,
            this.apartamentoToolStripMenuItem,
            this.especieToolStripMenuItem,
            this.petToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // condominioToolStripMenuItem
            // 
            this.condominioToolStripMenuItem.Name = "condominioToolStripMenuItem";
            this.condominioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.condominioToolStripMenuItem.Text = "Condominio";
            this.condominioToolStripMenuItem.Click += new System.EventHandler(this.condominioToolStripMenuItem_Click);
            // 
            // torresToolStripMenuItem
            // 
            this.torresToolStripMenuItem.Name = "torresToolStripMenuItem";
            this.torresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.torresToolStripMenuItem.Text = "Torre";
            // 
            // apartamentoToolStripMenuItem
            // 
            this.apartamentoToolStripMenuItem.Name = "apartamentoToolStripMenuItem";
            this.apartamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apartamentoToolStripMenuItem.Text = "Apartamento";
            // 
            // especieToolStripMenuItem
            // 
            this.especieToolStripMenuItem.Name = "especieToolStripMenuItem";
            this.especieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.especieToolStripMenuItem.Text = "Especie";
            // 
            // petToolStripMenuItem
            // 
            this.petToolStripMenuItem.Name = "petToolStripMenuItem";
            this.petToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.petToolStripMenuItem.Text = "Pet";
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porPetToolStripMenuItem,
            this.porApartamentoToolStripMenuItem});
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
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
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porPetToolStripMenuItem1,
            this.porApartamentoToolStripMenuItem1});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // porPetToolStripMenuItem1
            // 
            this.porPetToolStripMenuItem1.Name = "porPetToolStripMenuItem1";
            this.porPetToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.porPetToolStripMenuItem1.Text = "Por Pet";
            // 
            // porApartamentoToolStripMenuItem1
            // 
            this.porApartamentoToolStripMenuItem1.Name = "porApartamentoToolStripMenuItem1";
            this.porApartamentoToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.porApartamentoToolStripMenuItem1.Text = "Por Apartamento";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema Senso Pet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem condominioToolStripMenuItem;
        private ToolStripMenuItem torresToolStripMenuItem;
        private ToolStripMenuItem apartamentoToolStripMenuItem;
        private ToolStripMenuItem especieToolStripMenuItem;
        private ToolStripMenuItem petToolStripMenuItem;
        private ToolStripMenuItem pesquisaToolStripMenuItem;
        private ToolStripMenuItem porPetToolStripMenuItem;
        private ToolStripMenuItem porApartamentoToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem porPetToolStripMenuItem1;
        private ToolStripMenuItem porApartamentoToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}