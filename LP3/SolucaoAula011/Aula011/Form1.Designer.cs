namespace Aula011
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
            this.filhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaFilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatório1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatório2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatório3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filhoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuAplicacao";
            // 
            // filhoToolStripMenuItem
            // 
            this.filhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.janelaFilhaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.filhoToolStripMenuItem.Name = "filhoToolStripMenuItem";
            this.filhoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.filhoToolStripMenuItem.Text = "Cadastro";
            this.filhoToolStripMenuItem.Click += new System.EventHandler(this.filhoToolStripMenuItem_Click);
            // 
            // janelaFilhaToolStripMenuItem
            // 
            this.janelaFilhaToolStripMenuItem.Name = "janelaFilhaToolStripMenuItem";
            this.janelaFilhaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.janelaFilhaToolStripMenuItem.Text = "janela filha";
            this.janelaFilhaToolStripMenuItem.Click += new System.EventHandler(this.janelaFilhaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sairToolStripMenuItem.Text = "sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatório1ToolStripMenuItem,
            this.relatório2ToolStripMenuItem,
            this.relatório3ToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatório1ToolStripMenuItem
            // 
            this.relatório1ToolStripMenuItem.Name = "relatório1ToolStripMenuItem";
            this.relatório1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatório1ToolStripMenuItem.Text = "relatório 1";
            this.relatório1ToolStripMenuItem.Click += new System.EventHandler(this.relatório1ToolStripMenuItem_Click);
            // 
            // relatório2ToolStripMenuItem
            // 
            this.relatório2ToolStripMenuItem.Name = "relatório2ToolStripMenuItem";
            this.relatório2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatório2ToolStripMenuItem.Text = "relatório 2";
            this.relatório2ToolStripMenuItem.Click += new System.EventHandler(this.relatório2ToolStripMenuItem_Click);
            // 
            // relatório3ToolStripMenuItem
            // 
            this.relatório3ToolStripMenuItem.Name = "relatório3ToolStripMenuItem";
            this.relatório3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatório3ToolStripMenuItem.Text = "relatório 3";
            this.relatório3ToolStripMenuItem.Click += new System.EventHandler(this.relatório3ToolStripMenuItem_Click);
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
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem filhoToolStripMenuItem;
        private ToolStripMenuItem janelaFilhaToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem relatório1ToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem relatório2ToolStripMenuItem;
        private ToolStripMenuItem relatório3ToolStripMenuItem;
    }
}