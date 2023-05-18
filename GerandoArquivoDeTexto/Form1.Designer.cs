
namespace GerandoArquivoDeTexto
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroFuncionarios = new System.Windows.Forms.TextBox();
            this.btnCriarLinhas = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.sfdGravarArquivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. de Funcionários:";
            // 
            // txtNumeroFuncionarios
            // 
            this.txtNumeroFuncionarios.Location = new System.Drawing.Point(154, 9);
            this.txtNumeroFuncionarios.Name = "txtNumeroFuncionarios";
            this.txtNumeroFuncionarios.Size = new System.Drawing.Size(82, 22);
            this.txtNumeroFuncionarios.TabIndex = 1;
            // 
            // btnCriarLinhas
            // 
            this.btnCriarLinhas.Location = new System.Drawing.Point(242, 8);
            this.btnCriarLinhas.Name = "btnCriarLinhas";
            this.btnCriarLinhas.Size = new System.Drawing.Size(210, 23);
            this.btnCriarLinhas.TabIndex = 2;
            this.btnCriarLinhas.Text = "Criar linhas para registro";
            this.btnCriarLinhas.UseVisualStyleBackColor = true;
            this.btnCriarLinhas.Click += new System.EventHandler(this.btnCriarLinhas_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(12, 37);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.RowHeadersWidth = 51;
            this.dgvFuncionarios.RowTemplate.Height = 24;
            this.dgvFuncionarios.Size = new System.Drawing.Size(440, 294);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Enabled = false;
            this.btnCriarArquivo.Location = new System.Drawing.Point(12, 337);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(296, 23);
            this.btnCriarArquivo.TabIndex = 4;
            this.btnCriarArquivo.Text = "Criar arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(314, 337);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(138, 23);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // sfdGravarArquivo
            // 
            this.sfdGravarArquivo.DefaultExt = "*.txt";
            this.sfdGravarArquivo.Filter = "Arquivos textos|*.txt";
            this.sfdGravarArquivo.Title = "Dados para geração de arquivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 372);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnCriarLinhas);
            this.Controls.Add(this.txtNumeroFuncionarios);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dados para geração de arquivo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroFuncionarios;
        private System.Windows.Forms.Button btnCriarLinhas;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.SaveFileDialog sfdGravarArquivo;
    }
}

