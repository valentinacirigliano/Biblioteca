namespace Biblioteca.Windows
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label2 = new System.Windows.Forms.Label();
            this.UsuariosButton = new System.Windows.Forms.Button();
            this.PrestamosButton = new System.Windows.Forms.Button();
            this.LibrosButton = new System.Windows.Forms.Button();
            this.IdiomasButton = new System.Windows.Forms.Button();
            this.GenerosButton = new System.Windows.Forms.Button();
            this.EditorialesButton = new System.Windows.Forms.Button();
            this.AutoresButton = new System.Windows.Forms.Button();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Biblioteca";
            // 
            // UsuariosButton
            // 
            this.UsuariosButton.Location = new System.Drawing.Point(339, 227);
            this.UsuariosButton.Name = "UsuariosButton";
            this.UsuariosButton.Size = new System.Drawing.Size(143, 67);
            this.UsuariosButton.TabIndex = 27;
            this.UsuariosButton.Text = "Usuarios";
            this.UsuariosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UsuariosButton.UseVisualStyleBackColor = true;
            // 
            // PrestamosButton
            // 
            this.PrestamosButton.Location = new System.Drawing.Point(190, 227);
            this.PrestamosButton.Name = "PrestamosButton";
            this.PrestamosButton.Size = new System.Drawing.Size(143, 67);
            this.PrestamosButton.TabIndex = 28;
            this.PrestamosButton.Text = "Préstamos";
            this.PrestamosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrestamosButton.UseVisualStyleBackColor = true;
            // 
            // LibrosButton
            // 
            this.LibrosButton.Location = new System.Drawing.Point(41, 227);
            this.LibrosButton.Name = "LibrosButton";
            this.LibrosButton.Size = new System.Drawing.Size(143, 67);
            this.LibrosButton.TabIndex = 29;
            this.LibrosButton.Text = "Libros";
            this.LibrosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LibrosButton.UseVisualStyleBackColor = true;
            // 
            // IdiomasButton
            // 
            this.IdiomasButton.Location = new System.Drawing.Point(488, 121);
            this.IdiomasButton.Name = "IdiomasButton";
            this.IdiomasButton.Size = new System.Drawing.Size(143, 67);
            this.IdiomasButton.TabIndex = 30;
            this.IdiomasButton.Text = "Idiomas";
            this.IdiomasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IdiomasButton.UseVisualStyleBackColor = true;
            // 
            // GenerosButton
            // 
            this.GenerosButton.Location = new System.Drawing.Point(339, 121);
            this.GenerosButton.Name = "GenerosButton";
            this.GenerosButton.Size = new System.Drawing.Size(143, 67);
            this.GenerosButton.TabIndex = 31;
            this.GenerosButton.Text = "Géneros literarios";
            this.GenerosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GenerosButton.UseVisualStyleBackColor = true;
            // 
            // EditorialesButton
            // 
            this.EditorialesButton.Location = new System.Drawing.Point(190, 121);
            this.EditorialesButton.Name = "EditorialesButton";
            this.EditorialesButton.Size = new System.Drawing.Size(143, 67);
            this.EditorialesButton.TabIndex = 32;
            this.EditorialesButton.Text = "Editoriales";
            this.EditorialesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditorialesButton.UseVisualStyleBackColor = true;
            this.EditorialesButton.Click += new System.EventHandler(this.EditorialesButton_Click);
            // 
            // AutoresButton
            // 
            this.AutoresButton.Location = new System.Drawing.Point(41, 121);
            this.AutoresButton.Name = "AutoresButton";
            this.AutoresButton.Size = new System.Drawing.Size(143, 67);
            this.AutoresButton.TabIndex = 33;
            this.AutoresButton.Text = "Autores";
            this.AutoresButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AutoresButton.UseVisualStyleBackColor = true;
            this.AutoresButton.Click += new System.EventHandler(this.AutoresButton_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Image = ((System.Drawing.Image)(resources.GetObject("CerrarButton.Image")));
            this.CerrarButton.Location = new System.Drawing.Point(684, 354);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 59);
            this.CerrarButton.TabIndex = 26;
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsuariosButton);
            this.Controls.Add(this.PrestamosButton);
            this.Controls.Add(this.LibrosButton);
            this.Controls.Add(this.IdiomasButton);
            this.Controls.Add(this.GenerosButton);
            this.Controls.Add(this.EditorialesButton);
            this.Controls.Add(this.AutoresButton);
            this.Controls.Add(this.CerrarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UsuariosButton;
        private System.Windows.Forms.Button PrestamosButton;
        private System.Windows.Forms.Button LibrosButton;
        private System.Windows.Forms.Button IdiomasButton;
        private System.Windows.Forms.Button GenerosButton;
        private System.Windows.Forms.Button EditorialesButton;
        private System.Windows.Forms.Button AutoresButton;
        private System.Windows.Forms.Button CerrarButton;
    }
}