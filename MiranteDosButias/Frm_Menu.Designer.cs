namespace MiranteDosButias
{
    partial class Frm_Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mnu_Principal = new System.Windows.Forms.MenuStrip();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caféToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaMiranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_Principal
            // 
            this.Mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.Mnu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Principal.Name = "Mnu_Principal";
            this.Mnu_Principal.Size = new System.Drawing.Size(800, 24);
            this.Mnu_Principal.TabIndex = 0;
            this.Mnu_Principal.Text = "menuStrip1";
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caféToolStripMenuItem,
            this.portariaToolStripMenuItem,
            this.caixaMiranteToolStripMenuItem});
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.contasToolStripMenuItem.Text = "Contas";
            // 
            // caféToolStripMenuItem
            // 
            this.caféToolStripMenuItem.Name = "caféToolStripMenuItem";
            this.caféToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caféToolStripMenuItem.Text = "Café";
            this.caféToolStripMenuItem.Click += new System.EventHandler(this.caféToolStripMenuItem_Click);
            // 
            // portariaToolStripMenuItem
            // 
            this.portariaToolStripMenuItem.Name = "portariaToolStripMenuItem";
            this.portariaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.portariaToolStripMenuItem.Text = "Portaria";
            this.portariaToolStripMenuItem.Click += new System.EventHandler(this.portariaToolStripMenuItem_Click);
            // 
            // caixaMiranteToolStripMenuItem
            // 
            this.caixaMiranteToolStripMenuItem.Name = "caixaMiranteToolStripMenuItem";
            this.caixaMiranteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caixaMiranteToolStripMenuItem.Text = "Caixa Mirante";
            this.caixaMiranteToolStripMenuItem.Click += new System.EventHandler(this.caixaMiranteToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mnu_Principal);
            this.MainMenuStrip = this.Mnu_Principal;
            this.Name = "Frm_Menu";
            this.Text = "Mirante dos Butiás";
            this.Mnu_Principal.ResumeLayout(false);
            this.Mnu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Principal;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caféToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaMiranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
    }
}

