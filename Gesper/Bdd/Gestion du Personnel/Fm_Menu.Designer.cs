namespace GestionduPersonnel
{
    partial class Fm_Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnServices = new System.Windows.Forms.Button();
            this.btnDiplômes = new System.Windows.Forms.Button();
            this.btnEmployés = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(99, 46);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(75, 23);
            this.btnServices.TabIndex = 0;
            this.btnServices.Text = "Services";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnDiplômes
            // 
            this.btnDiplômes.Location = new System.Drawing.Point(99, 103);
            this.btnDiplômes.Name = "btnDiplômes";
            this.btnDiplômes.Size = new System.Drawing.Size(75, 23);
            this.btnDiplômes.TabIndex = 1;
            this.btnDiplômes.Text = "Diplômes";
            this.btnDiplômes.UseVisualStyleBackColor = true;
            this.btnDiplômes.Click += new System.EventHandler(this.btnDiplômes_Click);
            // 
            // btnEmployés
            // 
            this.btnEmployés.Location = new System.Drawing.Point(99, 158);
            this.btnEmployés.Name = "btnEmployés";
            this.btnEmployés.Size = new System.Drawing.Size(75, 23);
            this.btnEmployés.TabIndex = 2;
            this.btnEmployés.Text = "Employés";
            this.btnEmployés.UseVisualStyleBackColor = true;
            this.btnEmployés.Click += new System.EventHandler(this.btnEmployés_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(180, 103);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(92, 23);
            this.btnSauvegarder.TabIndex = 3;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // Fm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.btnEmployés);
            this.Controls.Add(this.btnDiplômes);
            this.Controls.Add(this.btnServices);
            this.Name = "Fm_Menu";
            this.Text = "Gestion du Personnel";
            this.Load += new System.EventHandler(this.Fm_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnDiplômes;
        private System.Windows.Forms.Button btnEmployés;
        private System.Windows.Forms.Button btnSauvegarder;
    }
}

