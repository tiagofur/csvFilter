namespace csvFilter
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
            this.btnExport = new System.Windows.Forms.Button();
            this.textBoxFileCSV = new System.Windows.Forms.TextBox();
            this.dataGridViewDadosCSV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTeste = new System.Windows.Forms.Label();
            this.comboBoxSeparador = new System.Windows.Forms.ComboBox();
            this.comboBoxColum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadosCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(819, 9);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Exportar";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // textBoxFileCSV
            // 
            this.textBoxFileCSV.Location = new System.Drawing.Point(62, 12);
            this.textBoxFileCSV.Name = "textBoxFileCSV";
            this.textBoxFileCSV.Size = new System.Drawing.Size(426, 20);
            this.textBoxFileCSV.TabIndex = 1;
            // 
            // dataGridViewDadosCSV
            // 
            this.dataGridViewDadosCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDadosCSV.Location = new System.Drawing.Point(13, 38);
            this.dataGridViewDadosCSV.Name = "dataGridViewDadosCSV";
            this.dataGridViewDadosCSV.Size = new System.Drawing.Size(881, 371);
            this.dataGridViewDadosCSV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Archivo:";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(494, 10);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(28, 23);
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columna:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Separador:";
            // 
            // labelTeste
            // 
            this.labelTeste.AutoSize = true;
            this.labelTeste.Location = new System.Drawing.Point(13, 416);
            this.labelTeste.Name = "labelTeste";
            this.labelTeste.Size = new System.Drawing.Size(56, 13);
            this.labelTeste.TabIndex = 9;
            this.labelTeste.Text = "labelTeste";
            // 
            // comboBoxSeparador
            // 
            this.comboBoxSeparador.FormattingEnabled = true;
            this.comboBoxSeparador.Location = new System.Drawing.Point(593, 11);
            this.comboBoxSeparador.Name = "comboBoxSeparador";
            this.comboBoxSeparador.Size = new System.Drawing.Size(43, 21);
            this.comboBoxSeparador.TabIndex = 10;
            this.comboBoxSeparador.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeparador_SelectedIndexChanged);
            // 
            // comboBoxColum
            // 
            this.comboBoxColum.FormattingEnabled = true;
            this.comboBoxColum.Location = new System.Drawing.Point(692, 10);
            this.comboBoxColum.Name = "comboBoxColum";
            this.comboBoxColum.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColum.TabIndex = 11;
            this.comboBoxColum.SelectedIndexChanged += new System.EventHandler(this.comboBoxColum_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 454);
            this.Controls.Add(this.comboBoxColum);
            this.Controls.Add(this.comboBoxSeparador);
            this.Controls.Add(this.labelTeste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDadosCSV);
            this.Controls.Add(this.textBoxFileCSV);
            this.Controls.Add(this.btnExport);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CSV Filter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadosCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox textBoxFileCSV;
        private System.Windows.Forms.DataGridView dataGridViewDadosCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTeste;
        private System.Windows.Forms.ComboBox comboBoxSeparador;
        private System.Windows.Forms.ComboBox comboBoxColum;
    }
}

