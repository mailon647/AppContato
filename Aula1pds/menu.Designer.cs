namespace Aula1pds
{
    partial class menu
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
            this.edMenu = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edMenu
            // 
            this.edMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.edMenu.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Bold);
            this.edMenu.Location = new System.Drawing.Point(-12, -1);
            this.edMenu.Name = "edMenu";
            this.edMenu.Size = new System.Drawing.Size(826, 49);
            this.edMenu.TabIndex = 0;
            this.edMenu.Text = "MENU";
            this.edMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btCadastrar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(302, 201);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCadastrar.Size = new System.Drawing.Size(204, 47);
            this.btCadastrar.TabIndex = 1;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.edMenu);
            this.Name = "menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label edMenu;
        private System.Windows.Forms.Button btCadastrar;
    }
}

