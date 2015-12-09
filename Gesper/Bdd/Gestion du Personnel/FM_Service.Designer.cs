namespace GestionduPersonnel
{
    partial class FM_Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_Service));
            this.bnServices = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bs_employes = new System.Windows.Forms.BindingSource(this.components);
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
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbDesignation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProduit = new System.Windows.Forms.Label();
            this.tbProduit = new System.Windows.Forms.TextBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.tbBudget = new System.Windows.Forms.TextBox();
            this.lblCapacité = new System.Windows.Forms.Label();
            this.tbCapacité = new System.Windows.Forms.TextBox();
            this.lbEmployés = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bsServices = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btntest = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bnServices)).BeginInit();
            this.bnServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_employes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnServices
            // 
            this.bnServices.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnServices.BindingSource = this.bsServices;
            this.bnServices.CountItem = this.bindingNavigatorCountItem;
            this.bnServices.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.toolStripSplitButton1,
            this.toolStripButton1});
            this.bnServices.Location = new System.Drawing.Point(0, 0);
            this.bnServices.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnServices.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnServices.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnServices.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnServices.Name = "bnServices";
            this.bnServices.PositionItem = this.bindingNavigatorPositionItem;
            this.bnServices.Size = new System.Drawing.Size(478, 25);
            this.bnServices.TabIndex = 0;
            this.bnServices.Text = "bindingNavigator1";
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
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(134, 56);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 2;
            // 
            // tbDesignation
            // 
            this.tbDesignation.Location = new System.Drawing.Point(134, 94);
            this.tbDesignation.Name = "tbDesignation";
            this.tbDesignation.Size = new System.Drawing.Size(100, 20);
            this.tbDesignation.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Designation";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(134, 129);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 20);
            this.tbType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Location = new System.Drawing.Point(18, 38);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(40, 13);
            this.lblProduit.TabIndex = 8;
            this.lblProduit.Text = "Produit";
            // 
            // tbProduit
            // 
            this.tbProduit.Location = new System.Drawing.Point(80, 31);
            this.tbProduit.Name = "tbProduit";
            this.tbProduit.Size = new System.Drawing.Size(100, 20);
            this.tbProduit.TabIndex = 9;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(21, 31);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(41, 13);
            this.lblBudget.TabIndex = 10;
            this.lblBudget.Text = "Budget";
            // 
            // tbBudget
            // 
            this.tbBudget.Location = new System.Drawing.Point(68, 31);
            this.tbBudget.Name = "tbBudget";
            this.tbBudget.Size = new System.Drawing.Size(100, 20);
            this.tbBudget.TabIndex = 11;
            // 
            // lblCapacité
            // 
            this.lblCapacité.AutoSize = true;
            this.lblCapacité.Location = new System.Drawing.Point(9, 66);
            this.lblCapacité.Name = "lblCapacité";
            this.lblCapacité.Size = new System.Drawing.Size(49, 13);
            this.lblCapacité.TabIndex = 12;
            this.lblCapacité.Text = "Capacité";
            this.lblCapacité.Click += new System.EventHandler(this.lblCapacité_Click);
            // 
            // tbCapacité
            // 
            this.tbCapacité.Location = new System.Drawing.Point(80, 63);
            this.tbCapacité.Name = "tbCapacité";
            this.tbCapacité.Size = new System.Drawing.Size(100, 20);
            this.tbCapacité.TabIndex = 13;
            // 
            // lbEmployés
            // 
            this.lbEmployés.DataSource = this.bs_employes;
            this.lbEmployés.FormattingEnabled = true;
            this.lbEmployés.Location = new System.Drawing.Point(0, 281);
            this.lbEmployés.Name = "lbEmployés";
            this.lbEmployés.Size = new System.Drawing.Size(478, 56);
            this.lbEmployés.TabIndex = 15;
            this.lbEmployés.SelectedIndexChanged += new System.EventHandler(this.lbEmployés_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Employés";
            // 
            // bsServices
            // 
            this.bsServices.CurrentChanged += new System.EventHandler(this.bsServices_CurrentChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProduit);
            this.groupBox1.Controls.Add(this.tbProduit);
            this.groupBox1.Controls.Add(this.tbCapacité);
            this.groupBox1.Controls.Add(this.lblCapacité);
            this.groupBox1.Location = new System.Drawing.Point(247, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productif";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbBudget);
            this.groupBox2.Controls.Add(this.lblBudget);
            this.groupBox2.Location = new System.Drawing.Point(41, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administratif";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(338, 71);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(100, 20);
            this.btntest.TabIndex = 20;
            // 
            // FM_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 333);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbEmployés);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDesignation);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnServices);
            this.Name = "FM_Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.FM_Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnServices)).EndInit();
            this.bnServices.ResumeLayout(false);
            this.bnServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_employes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnServices;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbDesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.TextBox tbProduit;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox tbBudget;
        private System.Windows.Forms.Label lblCapacité;
        private System.Windows.Forms.TextBox tbCapacité;
        private System.Windows.Forms.ListBox lbEmployés;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.BindingSource bsServices;
        private System.Windows.Forms.BindingSource bs_employes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox btntest;
    }
}