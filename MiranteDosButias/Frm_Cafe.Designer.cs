namespace MiranteDosButias
{
    partial class Frm_Cafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cafe));
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.Tbx_Brutocafe = new System.Windows.Forms.TextBox();
            this.Tbx_Data = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_CafeBruto = new System.Windows.Forms.Label();
            this.Lbl_CafeGasto = new System.Windows.Forms.Label();
            this.Tbx_GastoCafe = new System.Windows.Forms.TextBox();
            this.Btn_CalculaGastoCafe = new System.Windows.Forms.Button();
            this.Lbl_Totalcafe = new System.Windows.Forms.Label();
            this.Tbx_TotalLivreCafe = new System.Windows.Forms.TextBox();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Tbx_Id = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsb_Novo = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Abrir = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.excluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AlterarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(7, 74);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(30, 13);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Data";
            // 
            // Tbx_Brutocafe
            // 
            this.Tbx_Brutocafe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tbx_Brutocafe.Location = new System.Drawing.Point(78, 190);
            this.Tbx_Brutocafe.Name = "Tbx_Brutocafe";
            this.Tbx_Brutocafe.Size = new System.Drawing.Size(100, 20);
            this.Tbx_Brutocafe.TabIndex = 1;
            // 
            // Tbx_Data
            // 
            this.Tbx_Data.Location = new System.Drawing.Point(78, 71);
            this.Tbx_Data.Mask = "00/00/0000";
            this.Tbx_Data.Name = "Tbx_Data";
            this.Tbx_Data.Size = new System.Drawing.Size(65, 20);
            this.Tbx_Data.TabIndex = 2;
            this.Tbx_Data.ValidatingType = typeof(System.DateTime);
            // 
            // Lbl_CafeBruto
            // 
            this.Lbl_CafeBruto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lbl_CafeBruto.AutoSize = true;
            this.Lbl_CafeBruto.Location = new System.Drawing.Point(4, 190);
            this.Lbl_CafeBruto.Name = "Lbl_CafeBruto";
            this.Lbl_CafeBruto.Size = new System.Drawing.Size(59, 13);
            this.Lbl_CafeBruto.TabIndex = 4;
            this.Lbl_CafeBruto.Text = "Total Bruto";
            // 
            // Lbl_CafeGasto
            // 
            this.Lbl_CafeGasto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lbl_CafeGasto.AutoSize = true;
            this.Lbl_CafeGasto.Location = new System.Drawing.Point(7, 256);
            this.Lbl_CafeGasto.Name = "Lbl_CafeGasto";
            this.Lbl_CafeGasto.Size = new System.Drawing.Size(40, 13);
            this.Lbl_CafeGasto.TabIndex = 5;
            this.Lbl_CafeGasto.Text = "Gastos";
            // 
            // Tbx_GastoCafe
            // 
            this.Tbx_GastoCafe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tbx_GastoCafe.Location = new System.Drawing.Point(78, 248);
            this.Tbx_GastoCafe.Name = "Tbx_GastoCafe";
            this.Tbx_GastoCafe.Size = new System.Drawing.Size(100, 20);
            this.Tbx_GastoCafe.TabIndex = 6;
            // 
            // Btn_CalculaGastoCafe
            // 
            this.Btn_CalculaGastoCafe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_CalculaGastoCafe.Location = new System.Drawing.Point(184, 321);
            this.Btn_CalculaGastoCafe.Name = "Btn_CalculaGastoCafe";
            this.Btn_CalculaGastoCafe.Size = new System.Drawing.Size(75, 23);
            this.Btn_CalculaGastoCafe.TabIndex = 7;
            this.Btn_CalculaGastoCafe.Text = "Calcular";
            this.Btn_CalculaGastoCafe.UseVisualStyleBackColor = true;
            this.Btn_CalculaGastoCafe.Click += new System.EventHandler(this.Btn_CalculaGastoCafe_Click);
            // 
            // Lbl_Totalcafe
            // 
            this.Lbl_Totalcafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Totalcafe.AutoSize = true;
            this.Lbl_Totalcafe.Location = new System.Drawing.Point(4, 326);
            this.Lbl_Totalcafe.Name = "Lbl_Totalcafe";
            this.Lbl_Totalcafe.Size = new System.Drawing.Size(57, 13);
            this.Lbl_Totalcafe.TabIndex = 8;
            this.Lbl_Totalcafe.Text = "Total Livre";
            // 
            // Tbx_TotalLivreCafe
            // 
            this.Tbx_TotalLivreCafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Tbx_TotalLivreCafe.Location = new System.Drawing.Point(78, 323);
            this.Tbx_TotalLivreCafe.Name = "Tbx_TotalLivreCafe";
            this.Tbx_TotalLivreCafe.Size = new System.Drawing.Size(100, 20);
            this.Tbx_TotalLivreCafe.TabIndex = 9;
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(4, 112);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(65, 13);
            this.Lbl_Id.TabIndex = 10;
            this.Lbl_Id.Text = "Identificador";
            // 
            // Tbx_Id
            // 
            this.Tbx_Id.Location = new System.Drawing.Point(78, 109);
            this.Tbx_Id.Name = "Tbx_Id";
            this.Tbx_Id.Size = new System.Drawing.Size(100, 20);
            this.Tbx_Id.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsb_Novo,
            this.Tsb_Abrir,
            this.Tsb_Salvar,
            this.toolStripSeparator,
            this.excluirToolStripButton,
            this.AlterarToolStripButton,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tsb_Novo
            // 
            this.Tsb_Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Novo.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Novo.Image")));
            this.Tsb_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Novo.Name = "Tsb_Novo";
            this.Tsb_Novo.Size = new System.Drawing.Size(23, 22);
            this.Tsb_Novo.Text = "&Novo";
            this.Tsb_Novo.Click += new System.EventHandler(this.novoToolStripButton_Click);
            // 
            // Tsb_Abrir
            // 
            this.Tsb_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Abrir.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Abrir.Image")));
            this.Tsb_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Abrir.Name = "Tsb_Abrir";
            this.Tsb_Abrir.Size = new System.Drawing.Size(23, 22);
            this.Tsb_Abrir.Text = "&Abrir";
            this.Tsb_Abrir.Click += new System.EventHandler(this.Tsb_Abrir_Click);
            // 
            // Tsb_Salvar
            // 
            this.Tsb_Salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Salvar.Image")));
            this.Tsb_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Salvar.Name = "Tsb_Salvar";
            this.Tsb_Salvar.Size = new System.Drawing.Size(23, 22);
            this.Tsb_Salvar.Text = "&Salvar";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // excluirToolStripButton
            // 
            this.excluirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.excluirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripButton.Image")));
            this.excluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluirToolStripButton.Name = "excluirToolStripButton";
            this.excluirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.excluirToolStripButton.Text = "&Excluir";
            this.excluirToolStripButton.Click += new System.EventHandler(this.excluirToolStripButton_Click);
            // 
            // AlterarToolStripButton
            // 
            this.AlterarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlterarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AlterarToolStripButton.Image")));
            this.AlterarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlterarToolStripButton.Name = "AlterarToolStripButton";
            this.AlterarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AlterarToolStripButton.Text = "&Alterar";
            this.AlterarToolStripButton.Click += new System.EventHandler(this.AlterarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Frm_Cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 466);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Tbx_Id);
            this.Controls.Add(this.Lbl_Id);
            this.Controls.Add(this.Tbx_TotalLivreCafe);
            this.Controls.Add(this.Lbl_Totalcafe);
            this.Controls.Add(this.Btn_CalculaGastoCafe);
            this.Controls.Add(this.Tbx_GastoCafe);
            this.Controls.Add(this.Lbl_CafeGasto);
            this.Controls.Add(this.Lbl_CafeBruto);
            this.Controls.Add(this.Tbx_Data);
            this.Controls.Add(this.Tbx_Brutocafe);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "Frm_Cafe";
            this.Text = "Café";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox Tbx_Brutocafe;
        private System.Windows.Forms.MaskedTextBox Tbx_Data;
        private System.Windows.Forms.Label Lbl_CafeBruto;
        private System.Windows.Forms.Label Lbl_CafeGasto;
        private System.Windows.Forms.TextBox Tbx_GastoCafe;
        private System.Windows.Forms.Button Btn_CalculaGastoCafe;
        private System.Windows.Forms.Label Lbl_Totalcafe;
        private System.Windows.Forms.TextBox Tbx_TotalLivreCafe;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.TextBox Tbx_Id;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tsb_Novo;
        private System.Windows.Forms.ToolStripButton Tsb_Abrir;
        private System.Windows.Forms.ToolStripButton Tsb_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton excluirToolStripButton;
        private System.Windows.Forms.ToolStripButton AlterarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}