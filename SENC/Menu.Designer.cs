namespace SENC
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panelCabecalho = new Panel();
            label1 = new Label();
            btnMin = new Button();
            btnMax = new Button();
            btnFechar = new Button();
            panelMenu = new Panel();
            btnCnab = new Button();
            panelConteudo = new Panel();
            panelCabecalho.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = SystemColors.HotTrack;
            panelCabecalho.Controls.Add(label1);
            panelCabecalho.Controls.Add(btnMin);
            panelCabecalho.Controls.Add(btnMax);
            panelCabecalho.Controls.Add(btnFechar);
            panelCabecalho.Dock = DockStyle.Top;
            panelCabecalho.Location = new Point(0, 0);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(1265, 39);
            panelCabecalho.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fira Code Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(0, 1);
            label1.Name = "label1";
            label1.Size = new Size(302, 38);
            label1.TabIndex = 3;
            label1.Text = "Escola Nova Ciência";
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.FlatAppearance.BorderColor = Color.White;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnMin.FlatAppearance.MouseOverBackColor = Color.White;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("FiraCode Nerd Font", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnMin.ForeColor = Color.Black;
            btnMin.Location = new Point(1133, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(40, 39);
            btnMin.TabIndex = 2;
            btnMin.Text = "";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.FlatAppearance.BorderColor = Color.White;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnMax.FlatAppearance.MouseOverBackColor = Color.White;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Font = new Font("FiraCode Nerd Font", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnMax.ForeColor = Color.Black;
            btnMax.Location = new Point(1179, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(40, 39);
            btnMax.TabIndex = 1;
            btnMax.Text = "";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.FlatAppearance.BorderColor = Color.White;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("FiraCode Nerd Font", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(1225, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(40, 39);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(btnCnab);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 39);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 638);
            panelMenu.TabIndex = 1;
            // 
            // btnCnab
            // 
            btnCnab.FlatAppearance.BorderSize = 0;
            btnCnab.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnCnab.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnCnab.FlatStyle = FlatStyle.Flat;
            btnCnab.Font = new Font("FiraCode Nerd Font", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnCnab.ForeColor = Color.White;
            btnCnab.Location = new Point(0, 16);
            btnCnab.Name = "btnCnab";
            btnCnab.Size = new Size(200, 60);
            btnCnab.TabIndex = 2;
            btnCnab.Text = " CNAB";
            btnCnab.UseVisualStyleBackColor = true;
            btnCnab.Click += btnCnab_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(200, 39);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(1065, 638);
            panelConteudo.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 677);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            Controls.Add(panelCabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCabecalho;
        private Button btnFechar;
        private Button btnMax;
        private Button btnMin;
        private Label label1;
        private Panel panel1;
        private Button btnCnab;
        private Panel panel2;
        private Panel panelConteudo;
        private Panel panelMenu;
    }
}