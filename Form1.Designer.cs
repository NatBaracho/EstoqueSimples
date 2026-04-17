namespace EstoqueSimples
{
    partial class dvgEstoque
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
            lblNome = new Label();
            lblQtd = new Label();
            Nometxt = new TextBox();
            numQuantidade = new NumericUpDown();
            btnAdicionar = new Button();
            dgvEstoque = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(15, 157);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(162, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do Produto:";
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(37, 215);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(109, 25);
            lblQtd.TabIndex = 1;
            lblQtd.Text = "Quantidade:";
            // 
            // Nometxt
            // 
            Nometxt.Location = new Point(215, 157);
            Nometxt.Name = "Nometxt";
            Nometxt.Size = new Size(542, 31);
            Nometxt.TabIndex = 2;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(318, 209);
            numQuantidade.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(75, 31);
            numQuantidade.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(517, 206);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(158, 43);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "ADICONAR ";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dgvEstoque
            // 
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Location = new Point(37, 275);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersWidth = 62;
            dgvEstoque.Size = new Size(720, 418);
            dgvEstoque.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 21);
            label1.Name = "label1";
            label1.Size = new Size(303, 39);
            label1.TabIndex = 7;
            label1.Text = "Controle de Estoque";
            // 
            // dvgEstoque
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 701);
            Controls.Add(label1);
            Controls.Add(dgvEstoque);
            Controls.Add(btnAdicionar);
            Controls.Add(numQuantidade);
            Controls.Add(Nometxt);
            Controls.Add(lblQtd);
            Controls.Add(lblNome);
            MaximizeBox = false;
            Name = "dvgEstoque";
            Text = "Controle de Estoque Simples";
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblQtd;
        private TextBox Nometxt;
        private NumericUpDown numQuantidade;
        private Button btnAdicionar;
        private DataGridView dgvEstoque;
        private Label label1;
    }
}
