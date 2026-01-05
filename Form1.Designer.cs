namespace CadastroProdutosCervantes
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
            TxtCodigo = new TextBox();
            TxtNome = new TextBox();
            BtnExcluir = new Button();
            label1 = new Label();
            label2 = new Label();
            DgvProdutos = new DataGridView();
            groupBox1 = new GroupBox();
            PanelGrid = new Panel();
            PanelTop = new Panel();
            btn_Novo = new Button();
            btn_Salvar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DgvProdutos).BeginInit();
            groupBox1.SuspendLayout();
            PanelGrid.SuspendLayout();
            PanelTop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(20, 49);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(81, 27);
            TxtCodigo.TabIndex = 0;
            TxtCodigo.KeyPress += TxtCodigo_KeyPress;
            // 
            // TxtNome
            // 
            TxtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtNome.Location = new Point(145, 49);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(391, 27);
            TxtNome.TabIndex = 1;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnExcluir.BackColor = Color.Coral;
            BtnExcluir.ForeColor = SystemColors.ControlLightLight;
            BtnExcluir.Location = new Point(453, 18);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(94, 29);
            BtnExcluir.TabIndex = 4;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 26);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 6;
            label1.Text = "ID Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 26);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 7;
            label2.Text = "Nome Produto";
            // 
            // DgvProdutos
            // 
            DgvProdutos.AllowUserToAddRows = false;
            DgvProdutos.AllowUserToDeleteRows = false;
            DgvProdutos.AllowUserToResizeColumns = false;
            DgvProdutos.AllowUserToResizeRows = false;
            DgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProdutos.Dock = DockStyle.Fill;
            DgvProdutos.Location = new Point(0, 0);
            DgvProdutos.MultiSelect = false;
            DgvProdutos.Name = "DgvProdutos";
            DgvProdutos.ReadOnly = true;
            DgvProdutos.RowHeadersWidth = 51;
            DgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProdutos.Size = new Size(610, 221);
            DgvProdutos.TabIndex = 8;
            DgvProdutos.CellClick += DgvProdutos_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(TxtCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(40, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 110);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // PanelGrid
            // 
            PanelGrid.Controls.Add(DgvProdutos);
            PanelGrid.Dock = DockStyle.Top;
            PanelGrid.Location = new Point(0, 80);
            PanelGrid.Name = "PanelGrid";
            PanelGrid.Size = new Size(610, 221);
            PanelGrid.TabIndex = 12;
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(btn_Novo);
            PanelTop.Controls.Add(btn_Salvar);
            PanelTop.Location = new Point(3, 22);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(610, 52);
            PanelTop.TabIndex = 9;
            // 
            // btn_Novo
            // 
            btn_Novo.BackColor = Color.SkyBlue;
            btn_Novo.Location = new Point(8, 13);
            btn_Novo.Name = "btn_Novo";
            btn_Novo.Size = new Size(94, 29);
            btn_Novo.TabIndex = 9;
            btn_Novo.Text = "Novo";
            btn_Novo.UseVisualStyleBackColor = false;
            btn_Novo.Click += btn_Novo_Click;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Salvar.BackColor = Color.LightSeaGreen;
            btn_Salvar.Location = new Point(447, 13);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(94, 29);
            btn_Salvar.TabIndex = 10;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnExcluir);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 301);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 198);
            panel1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 615);
            Controls.Add(panel1);
            Controls.Add(PanelTop);
            Controls.Add(PanelGrid);
            Name = "Form1";
            Padding = new Padding(0, 80, 0, 0);
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvProdutos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            PanelGrid.ResumeLayout(false);
            PanelTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private Button BtnExcluir;
        private Label label1;
        private Label label2;
        private DataGridView DgvProdutos;
        private GroupBox groupBox1;
        private Panel PanelGrid;
        private Panel PanelTop;
        private Button btn_Novo;
        private Button btn_Salvar;
        private Panel panel1;
    }
}
