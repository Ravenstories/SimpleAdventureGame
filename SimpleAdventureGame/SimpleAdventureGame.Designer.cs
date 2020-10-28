namespace SimpleAdventureGame
{
	partial class SimpleAdventureGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxWeapons = new System.Windows.Forms.ComboBox();
            this.btnPotion = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.comboBoxPotions = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxLocation = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMessages = new System.Windows.Forms.RichTextBox();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.dataGridViewQuests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level:";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Experience:";
            this.label4.UseWaitCursor = true;
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(102, 13);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(0, 17);
            this.lblHitPoints.TabIndex = 4;
            this.lblHitPoints.UseWaitCursor = true;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(102, 32);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 17);
            this.lblGold.TabIndex = 5;
            this.lblGold.UseWaitCursor = true;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(102, 70);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(0, 17);
            this.lblExperience.TabIndex = 6;
            this.lblExperience.UseWaitCursor = true;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(102, 51);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 17);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.UseWaitCursor = true;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(592, 390);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 8;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.UseWaitCursor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(673, 422);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 9;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.UseWaitCursor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(592, 454);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 10;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.UseWaitCursor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(511, 422);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 11;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.UseWaitCursor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Weapons";
            this.label5.UseWaitCursor = true;
            // 
            // comboBoxWeapons
            // 
            this.comboBoxWeapons.FormattingEnabled = true;
            this.comboBoxWeapons.Location = new System.Drawing.Point(480, 499);
            this.comboBoxWeapons.Name = "comboBoxWeapons";
            this.comboBoxWeapons.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWeapons.TabIndex = 13;
            this.comboBoxWeapons.UseWaitCursor = true;
            // 
            // btnPotion
            // 
            this.btnPotion.Location = new System.Drawing.Point(673, 390);
            this.btnPotion.Name = "btnPotion";
            this.btnPotion.Size = new System.Drawing.Size(86, 23);
            this.btnPotion.TabIndex = 14;
            this.btnPotion.Text = "Use Potion";
            this.btnPotion.UseVisualStyleBackColor = true;
            this.btnPotion.UseWaitCursor = true;
            this.btnPotion.Click += new System.EventHandler(this.btnPotion_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(501, 390);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(85, 23);
            this.btnAttack.TabIndex = 15;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.UseWaitCursor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // comboBoxPotions
            // 
            this.comboBoxPotions.FormattingEnabled = true;
            this.comboBoxPotions.Location = new System.Drawing.Point(667, 499);
            this.comboBoxPotions.Name = "comboBoxPotions";
            this.comboBoxPotions.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPotions.TabIndex = 16;
            this.comboBoxPotions.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(733, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Potions";
            this.label6.UseWaitCursor = true;
            // 
            // richTextBoxLocation
            // 
            this.richTextBoxLocation.Location = new System.Drawing.Point(408, 13);
            this.richTextBoxLocation.Name = "richTextBoxLocation";
            this.richTextBoxLocation.ReadOnly = true;
            this.richTextBoxLocation.Size = new System.Drawing.Size(380, 96);
            this.richTextBoxLocation.TabIndex = 18;
            this.richTextBoxLocation.Text = "";
            this.richTextBoxLocation.UseWaitCursor = true;
            // 
            // richTextBoxMessages
            // 
            this.richTextBoxMessages.Location = new System.Drawing.Point(408, 116);
            this.richTextBoxMessages.Name = "richTextBoxMessages";
            this.richTextBoxMessages.ReadOnly = true;
            this.richTextBoxMessages.Size = new System.Drawing.Size(380, 268);
            this.richTextBoxMessages.TabIndex = 19;
            this.richTextBoxMessages.Text = "";
            this.richTextBoxMessages.UseWaitCursor = true;
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.AllowUserToResizeColumns = false;
            this.dataGridViewInventory.AllowUserToResizeRows = false;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Enabled = false;
            this.dataGridViewInventory.Location = new System.Drawing.Point(16, 116);
            this.dataGridViewInventory.MultiSelect = false;
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.RowTemplate.Height = 24;
            this.dataGridViewInventory.Size = new System.Drawing.Size(386, 268);
            this.dataGridViewInventory.TabIndex = 20;
            this.dataGridViewInventory.UseWaitCursor = true;
            // 
            // dataGridViewQuests
            // 
            this.dataGridViewQuests.AllowUserToAddRows = false;
            this.dataGridViewQuests.AllowUserToDeleteRows = false;
            this.dataGridViewQuests.AllowUserToResizeColumns = false;
            this.dataGridViewQuests.AllowUserToResizeRows = false;
            this.dataGridViewQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuests.Enabled = false;
            this.dataGridViewQuests.Location = new System.Drawing.Point(16, 390);
            this.dataGridViewQuests.MultiSelect = false;
            this.dataGridViewQuests.Name = "dataGridViewQuests";
            this.dataGridViewQuests.ReadOnly = true;
            this.dataGridViewQuests.RowHeadersWidth = 51;
            this.dataGridViewQuests.RowTemplate.Height = 24;
            this.dataGridViewQuests.Size = new System.Drawing.Size(386, 133);
            this.dataGridViewQuests.TabIndex = 21;
            this.dataGridViewQuests.UseWaitCursor = true;
            // 
            // SimpleAdventureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.dataGridViewQuests);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.richTextBoxMessages);
            this.Controls.Add(this.richTextBoxLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxPotions);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnPotion);
            this.Controls.Add(this.comboBoxWeapons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimpleAdventureGame";
            this.Text = "SimpleAdventureGame";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblHitPoints;
		private System.Windows.Forms.Label lblGold;
		private System.Windows.Forms.Label lblExperience;
		private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxWeapons;
        private System.Windows.Forms.Button btnPotion;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.ComboBox comboBoxPotions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxLocation;
        private System.Windows.Forms.RichTextBox richTextBoxMessages;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.DataGridView dataGridViewQuests;
    }
}

