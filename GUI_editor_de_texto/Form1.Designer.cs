namespace GUI_editor_de_texto
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
            this.tlp_salva_texto = new System.Windows.Forms.TableLayoutPanel();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_abri = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.rtxtB_texto = new System.Windows.Forms.RichTextBox();
            this.tlp_salva_texto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_salva_texto
            // 
            this.tlp_salva_texto.ColumnCount = 3;
            this.tlp_salva_texto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_salva_texto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_salva_texto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_salva_texto.Controls.Add(this.btn_salvar, 0, 1);
            this.tlp_salva_texto.Controls.Add(this.btn_abri, 1, 1);
            this.tlp_salva_texto.Controls.Add(this.btn_fechar, 2, 1);
            this.tlp_salva_texto.Controls.Add(this.rtxtB_texto, 0, 0);
            this.tlp_salva_texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_salva_texto.Location = new System.Drawing.Point(0, 0);
            this.tlp_salva_texto.Name = "tlp_salva_texto";
            this.tlp_salva_texto.RowCount = 2;
            this.tlp_salva_texto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_salva_texto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_salva_texto.Size = new System.Drawing.Size(800, 450);
            this.tlp_salva_texto.TabIndex = 0;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(84, 415);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(97, 29);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_abri
            // 
            this.btn_abri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_abri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abri.Location = new System.Drawing.Point(361, 414);
            this.btn_abri.Name = "btn_abri";
            this.btn_abri.Size = new System.Drawing.Size(75, 32);
            this.btn_abri.TabIndex = 1;
            this.btn_abri.Text = "Abrir";
            this.btn_abri.UseVisualStyleBackColor = true;
            this.btn_abri.Click += new System.EventHandler(this.btn_abri_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(622, 414);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(87, 32);
            this.btn_fechar.TabIndex = 2;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // rtxtB_texto
            // 
            this.tlp_salva_texto.SetColumnSpan(this.rtxtB_texto, 3);
            this.rtxtB_texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtB_texto.Location = new System.Drawing.Point(10, 10);
            this.rtxtB_texto.Margin = new System.Windows.Forms.Padding(10);
            this.rtxtB_texto.Name = "rtxtB_texto";
            this.rtxtB_texto.Size = new System.Drawing.Size(780, 390);
            this.rtxtB_texto.TabIndex = 3;
            this.rtxtB_texto.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp_salva_texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tlp_salva_texto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_salva_texto;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_abri;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.RichTextBox rtxtB_texto;
    }
}

