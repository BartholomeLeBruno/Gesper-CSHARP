namespace GestionduPersonnel
{
    partial class FM_Employés
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_Employés));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bnEmployes = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbSalaire = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMasculin = new System.Windows.Forms.RadioButton();
            this.rbFéminin = new System.Windows.Forms.RadioButton();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.chCadre = new System.Windows.Forms.CheckBox();
            this.lbDiplomesposseder = new System.Windows.Forms.ListBox();
            this.lbAutresDiplomes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bsemployes = new System.Windows.Forms.BindingSource(this.components);
            this.bsservice = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnEmployes)).BeginInit();
            this.bnEmployes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsemployes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsservice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diplômes possédés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prenom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Autres diplômes";
            // 
            // bnEmployes
            // 
            this.bnEmployes.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnEmployes.CountItem = this.bindingNavigatorCountItem;
            this.bnEmployes.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnEmployes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnEmployes.Location = new System.Drawing.Point(0, 0);
            this.bnEmployes.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnEmployes.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnEmployes.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnEmployes.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnEmployes.Name = "bnEmployes";
            this.bnEmployes.PositionItem = this.bindingNavigatorPositionItem;
            this.bnEmployes.Size = new System.Drawing.Size(319, 25);
            this.bnEmployes.TabIndex = 7;
            this.bnEmployes.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(129, 44);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 8;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(129, 74);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 9;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(129, 110);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 20);
            this.tbPrenom.TabIndex = 10;
            // 
            // tbSalaire
            // 
            this.tbSalaire.Location = new System.Drawing.Point(129, 163);
            this.tbSalaire.Name = "tbSalaire";
            this.tbSalaire.Size = new System.Drawing.Size(100, 20);
            this.tbSalaire.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMasculin);
            this.groupBox1.Controls.Add(this.rbFéminin);
            this.groupBox1.Location = new System.Drawing.Point(41, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 65);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexe";
            // 
            // rbMasculin
            // 
            this.rbMasculin.AutoSize = true;
            this.rbMasculin.Location = new System.Drawing.Point(97, 29);
            this.rbMasculin.Name = "rbMasculin";
            this.rbMasculin.Size = new System.Drawing.Size(67, 17);
            this.rbMasculin.TabIndex = 22;
            this.rbMasculin.TabStop = true;
            this.rbMasculin.Text = "Masculin";
            this.rbMasculin.UseVisualStyleBackColor = true;
            // 
            // rbFéminin
            // 
            this.rbFéminin.AutoSize = true;
            this.rbFéminin.Location = new System.Drawing.Point(11, 29);
            this.rbFéminin.Name = "rbFéminin";
            this.rbFéminin.Size = new System.Drawing.Size(61, 17);
            this.rbFéminin.TabIndex = 0;
            this.rbFéminin.TabStop = true;
            this.rbFéminin.Text = "Féminin";
            this.rbFéminin.UseVisualStyleBackColor = true;
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(129, 282);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(121, 21);
            this.cbService.TabIndex = 16;
            // 
            // chCadre
            // 
            this.chCadre.AutoSize = true;
            this.chCadre.Location = new System.Drawing.Point(129, 140);
            this.chCadre.Name = "chCadre";
            this.chCadre.Size = new System.Drawing.Size(54, 17);
            this.chCadre.TabIndex = 17;
            this.chCadre.Text = "Cadre";
            this.chCadre.UseVisualStyleBackColor = true;
            // 
            // lbDiplomesposseder
            // 
            this.lbDiplomesposseder.FormattingEnabled = true;
            this.lbDiplomesposseder.Location = new System.Drawing.Point(12, 355);
            this.lbDiplomesposseder.Name = "lbDiplomesposseder";
            this.lbDiplomesposseder.Size = new System.Drawing.Size(120, 95);
            this.lbDiplomesposseder.TabIndex = 18;
            // 
            // lbAutresDiplomes
            // 
            this.lbAutresDiplomes.FormattingEnabled = true;
            this.lbAutresDiplomes.Location = new System.Drawing.Point(187, 355);
            this.lbAutresDiplomes.Name = "lbAutresDiplomes";
            this.lbAutresDiplomes.Size = new System.Drawing.Size(120, 95);
            this.lbAutresDiplomes.TabIndex = 19;
            this.lbAutresDiplomes.SelectedIndexChanged += new System.EventHandler(this.lbAutresDiplomes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bsemployes
            // 
            this.bsemployes.CurrentChanged += new System.EventHandler(this.bsemployes_CurrentChanged);
            // 
            // FM_Employés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbAutresDiplomes);
            this.Controls.Add(this.lbDiplomesposseder);
            this.Controls.Add(this.chCadre);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSalaire);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.bnEmployes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FM_Employés";
            this.Text = "Les employés";
            this.Load += new System.EventHandler(this.FM_Employés_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnEmployes)).EndInit();
            this.bnEmployes.ResumeLayout(false);
            this.bnEmployes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsemployes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsservice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingNavigator bnEmployes;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbSalaire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.RadioButton rbMasculin;
        private System.Windows.Forms.RadioButton rbFéminin;
        private System.Windows.Forms.CheckBox chCadre;
        private System.Windows.Forms.ListBox lbDiplomesposseder;
        private System.Windows.Forms.ListBox lbAutresDiplomes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bsemployes;
        private System.Windows.Forms.BindingSource bsservice;
    }
}