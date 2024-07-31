namespace MissionDefiner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblMissionId = new System.Windows.Forms.Label();
            this.txtMissionId = new System.Windows.Forms.TextBox();
            this.lblMissionName = new System.Windows.Forms.Label();
            this.txtMissionName = new System.Windows.Forms.TextBox();
            this.chkRequireLevel = new System.Windows.Forms.CheckBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.chkRequireExp = new System.Windows.Forms.CheckBox();
            this.txtExpAmount = new System.Windows.Forms.TextBox();
            this.chkRequireMoney = new System.Windows.Forms.CheckBox();
            this.txtMoneyAmount = new System.Windows.Forms.TextBox();
            this.chkRequirePrize = new System.Windows.Forms.CheckBox();
            this.txtPrizeItemId = new System.Windows.Forms.TextBox();
            this.txtPrizeItemQuantity = new System.Windows.Forms.TextBox();
            this.txtPrizeItemQuality = new System.Windows.Forms.TextBox();
            this.txtPrizeMoneyAmount = new System.Windows.Forms.TextBox();
            this.btnSaveMission = new System.Windows.Forms.Button();
            this.lvItems = new System.Windows.Forms.ListView();
            this.columnItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtItemAmount = new System.Windows.Forms.TextBox();
            this.lblBeginDialog = new System.Windows.Forms.Label();
            this.txtBeginDialog = new System.Windows.Forms.TextBox();
            this.lblResultDialog = new System.Windows.Forms.Label();
            this.txtResultDialog = new System.Windows.Forms.TextBox();
            this.lblHelpText = new System.Windows.Forms.Label();
            this.txtHelpText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIncreaseAmount = new System.Windows.Forms.Button();
            this.btnDecreaseAmount = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMissionId
            // 
            this.lblMissionId.AutoSize = true;
            this.lblMissionId.Location = new System.Drawing.Point(12, 15);
            this.lblMissionId.Name = "lblMissionId";
            this.lblMissionId.Size = new System.Drawing.Size(66, 13);
            this.lblMissionId.TabIndex = 0;
            this.lblMissionId.Text = "ID de Misión";
            this.lblMissionId.Click += new System.EventHandler(this.lblMissionId_Click);
            // 
            // txtMissionId
            // 
            this.txtMissionId.Location = new System.Drawing.Point(150, 12);
            this.txtMissionId.Name = "txtMissionId";
            this.txtMissionId.Size = new System.Drawing.Size(100, 20);
            this.txtMissionId.TabIndex = 1;
            // 
            // lblMissionName
            // 
            this.lblMissionName.AutoSize = true;
            this.lblMissionName.Location = new System.Drawing.Point(12, 41);
            this.lblMissionName.Name = "lblMissionName";
            this.lblMissionName.Size = new System.Drawing.Size(92, 13);
            this.lblMissionName.TabIndex = 2;
            this.lblMissionName.Text = "Nombre de Misión";
            // 
            // txtMissionName
            // 
            this.txtMissionName.Location = new System.Drawing.Point(150, 38);
            this.txtMissionName.Name = "txtMissionName";
            this.txtMissionName.Size = new System.Drawing.Size(100, 20);
            this.txtMissionName.TabIndex = 3;
            // 
            // chkRequireLevel
            // 
            this.chkRequireLevel.AutoSize = true;
            this.chkRequireLevel.Location = new System.Drawing.Point(15, 64);
            this.chkRequireLevel.Name = "chkRequireLevel";
            this.chkRequireLevel.Size = new System.Drawing.Size(96, 17);
            this.chkRequireLevel.TabIndex = 4;
            this.chkRequireLevel.Text = "Requiere Nivel";
            this.chkRequireLevel.UseVisualStyleBackColor = true;
            // 
            // txtLevel
            // 
            this.txtLevel.Enabled = false;
            this.txtLevel.Location = new System.Drawing.Point(150, 62);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 5;
            // 
            // chkRequireExp
            // 
            this.chkRequireExp.AutoSize = true;
            this.chkRequireExp.Location = new System.Drawing.Point(15, 90);
            this.chkRequireExp.Name = "chkRequireExp";
            this.chkRequireExp.Size = new System.Drawing.Size(127, 17);
            this.chkRequireExp.TabIndex = 6;
            this.chkRequireExp.Text = "Requiere Experiencia";
            this.chkRequireExp.UseVisualStyleBackColor = true;
            // 
            // txtExpAmount
            // 
            this.txtExpAmount.Enabled = false;
            this.txtExpAmount.Location = new System.Drawing.Point(150, 88);
            this.txtExpAmount.Name = "txtExpAmount";
            this.txtExpAmount.Size = new System.Drawing.Size(100, 20);
            this.txtExpAmount.TabIndex = 7;
            // 
            // chkRequireMoney
            // 
            this.chkRequireMoney.AutoSize = true;
            this.chkRequireMoney.Location = new System.Drawing.Point(15, 116);
            this.chkRequireMoney.Name = "chkRequireMoney";
            this.chkRequireMoney.Size = new System.Drawing.Size(103, 17);
            this.chkRequireMoney.TabIndex = 8;
            this.chkRequireMoney.Text = "Requiere Dinero";
            this.chkRequireMoney.UseVisualStyleBackColor = true;
            // 
            // txtMoneyAmount
            // 
            this.txtMoneyAmount.Enabled = false;
            this.txtMoneyAmount.Location = new System.Drawing.Point(150, 114);
            this.txtMoneyAmount.Name = "txtMoneyAmount";
            this.txtMoneyAmount.Size = new System.Drawing.Size(100, 20);
            this.txtMoneyAmount.TabIndex = 9;
            // 
            // chkRequirePrize
            // 
            this.chkRequirePrize.AutoSize = true;
            this.chkRequirePrize.Location = new System.Drawing.Point(15, 167);
            this.chkRequirePrize.Name = "chkRequirePrize";
            this.chkRequirePrize.Size = new System.Drawing.Size(58, 17);
            this.chkRequirePrize.TabIndex = 10;
            this.chkRequirePrize.Text = "Premio";
            this.chkRequirePrize.UseVisualStyleBackColor = true;
            // 
            // txtPrizeItemId
            // 
            this.txtPrizeItemId.Enabled = false;
            this.txtPrizeItemId.Location = new System.Drawing.Point(150, 164);
            this.txtPrizeItemId.Name = "txtPrizeItemId";
            this.txtPrizeItemId.Size = new System.Drawing.Size(53, 20);
            this.txtPrizeItemId.TabIndex = 11;
            this.txtPrizeItemId.TextChanged += new System.EventHandler(this.txtPrizeItemId_TextChanged);
            // 
            // txtPrizeItemQuantity
            // 
            this.txtPrizeItemQuantity.Enabled = false;
            this.txtPrizeItemQuantity.Location = new System.Drawing.Point(209, 164);
            this.txtPrizeItemQuantity.Name = "txtPrizeItemQuantity";
            this.txtPrizeItemQuantity.Size = new System.Drawing.Size(51, 20);
            this.txtPrizeItemQuantity.TabIndex = 12;
            this.txtPrizeItemQuantity.TextChanged += new System.EventHandler(this.txtPrizeItemQuantity_TextChanged);
            // 
            // txtPrizeItemQuality
            // 
            this.txtPrizeItemQuality.Enabled = false;
            this.txtPrizeItemQuality.Location = new System.Drawing.Point(266, 164);
            this.txtPrizeItemQuality.Name = "txtPrizeItemQuality";
            this.txtPrizeItemQuality.Size = new System.Drawing.Size(39, 20);
            this.txtPrizeItemQuality.TabIndex = 13;
            this.txtPrizeItemQuality.TextChanged += new System.EventHandler(this.txtPrizeItemQuality_TextChanged);
            // 
            // txtPrizeMoneyAmount
            // 
            this.txtPrizeMoneyAmount.Enabled = false;
            this.txtPrizeMoneyAmount.Location = new System.Drawing.Point(150, 203);
            this.txtPrizeMoneyAmount.Name = "txtPrizeMoneyAmount";
            this.txtPrizeMoneyAmount.Size = new System.Drawing.Size(155, 20);
            this.txtPrizeMoneyAmount.TabIndex = 14;
            this.txtPrizeMoneyAmount.TextChanged += new System.EventHandler(this.txtPrizeMoneyAmount_TextChanged);
            // 
            // btnSaveMission
            // 
            this.btnSaveMission.Location = new System.Drawing.Point(15, 244);
            this.btnSaveMission.Name = "btnSaveMission";
            this.btnSaveMission.Size = new System.Drawing.Size(235, 23);
            this.btnSaveMission.TabIndex = 15;
            this.btnSaveMission.Text = "Guardar Misión";
            this.btnSaveMission.UseVisualStyleBackColor = true;
            // 
            // lvItems
            // 
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnItemId,
            this.columnItemAmount});
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(15, 273);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(235, 97);
            this.lvItems.TabIndex = 16;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);
            // 
            // columnItemId
            // 
            this.columnItemId.Text = "ID de Ítem";
            this.columnItemId.Width = 70;
            // 
            // columnItemAmount
            // 
            this.columnItemAmount.Text = "Cantidad";
            this.columnItemAmount.Width = 80;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(15, 376);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(235, 23);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "Añadir Ítem";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(15, 405);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(100, 20);
            this.txtItemId.TabIndex = 18;
            // 
            // txtItemAmount
            // 
            this.txtItemAmount.Location = new System.Drawing.Point(150, 405);
            this.txtItemAmount.Name = "txtItemAmount";
            this.txtItemAmount.Size = new System.Drawing.Size(100, 20);
            this.txtItemAmount.TabIndex = 19;
            // 
            // lblBeginDialog
            // 
            this.lblBeginDialog.AutoSize = true;
            this.lblBeginDialog.Location = new System.Drawing.Point(12, 428);
            this.lblBeginDialog.Name = "lblBeginDialog";
            this.lblBeginDialog.Size = new System.Drawing.Size(86, 13);
            this.lblBeginDialog.TabIndex = 20;
            this.lblBeginDialog.Text = "Diálogo de Inicio";
            // 
            // txtBeginDialog
            // 
            this.txtBeginDialog.Location = new System.Drawing.Point(15, 444);
            this.txtBeginDialog.Name = "txtBeginDialog";
            this.txtBeginDialog.Size = new System.Drawing.Size(235, 20);
            this.txtBeginDialog.TabIndex = 21;
            // 
            // lblResultDialog
            // 
            this.lblResultDialog.AutoSize = true;
            this.lblResultDialog.Location = new System.Drawing.Point(12, 467);
            this.lblResultDialog.Name = "lblResultDialog";
            this.lblResultDialog.Size = new System.Drawing.Size(109, 13);
            this.lblResultDialog.TabIndex = 22;
            this.lblResultDialog.Text = "Diálogo de Resultado";
            // 
            // txtResultDialog
            // 
            this.txtResultDialog.Location = new System.Drawing.Point(15, 483);
            this.txtResultDialog.Name = "txtResultDialog";
            this.txtResultDialog.Size = new System.Drawing.Size(235, 20);
            this.txtResultDialog.TabIndex = 23;
            // 
            // lblHelpText
            // 
            this.lblHelpText.AutoSize = true;
            this.lblHelpText.Location = new System.Drawing.Point(12, 506);
            this.lblHelpText.Name = "lblHelpText";
            this.lblHelpText.Size = new System.Drawing.Size(82, 13);
            this.lblHelpText.TabIndex = 24;
            this.lblHelpText.Text = "Texto de Ayuda";
            // 
            // txtHelpText
            // 
            this.txtHelpText.Location = new System.Drawing.Point(15, 522);
            this.txtHelpText.Name = "txtHelpText";
            this.txtHelpText.Size = new System.Drawing.Size(235, 20);
            this.txtHelpText.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID de Ítem";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cantidad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Calidad";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Dinero";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnIncreaseAmount
            // 
            this.btnIncreaseAmount.Location = new System.Drawing.Point(265, 273);
            this.btnIncreaseAmount.Name = "btnIncreaseAmount";
            this.btnIncreaseAmount.Size = new System.Drawing.Size(75, 23);
            this.btnIncreaseAmount.TabIndex = 28;
            this.btnIncreaseAmount.Text = "Aumentar";
            this.btnIncreaseAmount.UseVisualStyleBackColor = true;
            // 
            // btnDecreaseAmount
            // 
            this.btnDecreaseAmount.Location = new System.Drawing.Point(265, 302);
            this.btnDecreaseAmount.Name = "btnDecreaseAmount";
            this.btnDecreaseAmount.Size = new System.Drawing.Size(75, 23);
            this.btnDecreaseAmount.TabIndex = 29;
            this.btnDecreaseAmount.Text = "Reducir";
            this.btnDecreaseAmount.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(265, 331);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem.TabIndex = 30;
            this.btnRemoveItem.Text = "Eliminar";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(265, 360);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 31;
            this.btnMoveUp.Text = "Subir";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(265, 389);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 32;
            this.btnMoveDown.Text = "Bajar";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 561);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnDecreaseAmount);
            this.Controls.Add(this.btnIncreaseAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHelpText);
            this.Controls.Add(this.lblHelpText);
            this.Controls.Add(this.txtResultDialog);
            this.Controls.Add(this.lblResultDialog);
            this.Controls.Add(this.txtBeginDialog);
            this.Controls.Add(this.lblBeginDialog);
            this.Controls.Add(this.txtItemAmount);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.btnSaveMission);
            this.Controls.Add(this.txtPrizeMoneyAmount);
            this.Controls.Add(this.txtPrizeItemQuality);
            this.Controls.Add(this.txtPrizeItemQuantity);
            this.Controls.Add(this.txtPrizeItemId);
            this.Controls.Add(this.chkRequirePrize);
            this.Controls.Add(this.txtMoneyAmount);
            this.Controls.Add(this.chkRequireMoney);
            this.Controls.Add(this.txtExpAmount);
            this.Controls.Add(this.chkRequireExp);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.chkRequireLevel);
            this.Controls.Add(this.txtMissionName);
            this.Controls.Add(this.lblMissionName);
            this.Controls.Add(this.txtMissionId);
            this.Controls.Add(this.lblMissionId);
            this.Name = "Form1";
            this.Text = "Definidor de Misiones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMissionId;
        private System.Windows.Forms.TextBox txtMissionId;
        private System.Windows.Forms.Label lblMissionName;
        private System.Windows.Forms.TextBox txtMissionName;
        private System.Windows.Forms.CheckBox chkRequireLevel;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.CheckBox chkRequireExp;
        private System.Windows.Forms.TextBox txtExpAmount;
        private System.Windows.Forms.CheckBox chkRequireMoney;
        private System.Windows.Forms.TextBox txtMoneyAmount;
        private System.Windows.Forms.CheckBox chkRequirePrize;
        private System.Windows.Forms.TextBox txtPrizeItemId;
        private System.Windows.Forms.TextBox txtPrizeItemQuantity;
        private System.Windows.Forms.TextBox txtPrizeItemQuality;
        private System.Windows.Forms.TextBox txtPrizeMoneyAmount;
        private System.Windows.Forms.Button btnSaveMission;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader columnItemId;
        private System.Windows.Forms.ColumnHeader columnItemAmount;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtItemAmount;
        private System.Windows.Forms.Label lblBeginDialog;
        private System.Windows.Forms.TextBox txtBeginDialog;
        private System.Windows.Forms.Label lblResultDialog;
        private System.Windows.Forms.TextBox txtResultDialog;
        private System.Windows.Forms.Label lblHelpText;
        private System.Windows.Forms.TextBox txtHelpText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIncreaseAmount;
        private System.Windows.Forms.Button btnDecreaseAmount;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
    }
}