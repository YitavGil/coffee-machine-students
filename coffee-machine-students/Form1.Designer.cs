namespace coffee_machine_students
{
	partial class Form1
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
			this.txtDrinkName = new System.Windows.Forms.TextBox();
			this.cmbxSugar = new System.Windows.Forms.ComboBox();
			this.cmbMilk = new System.Windows.Forms.ComboBox();
			this.cmbCocoa = new System.Windows.Forms.ComboBox();
			this.cmbCoffee = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnIncrement = new System.Windows.Forms.Button();
			this.btnDecrement = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgvDrinks = new System.Windows.Forms.DataGridView();
			this.sugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cocoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.milk = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(645, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "סוג שתייה חדש";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(312, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 39);
			this.label2.TabIndex = 1;
			this.label2.Text = "מכונת קפה";
			// 
			// txtDrinkName
			// 
			this.txtDrinkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDrinkName.Location = new System.Drawing.Point(449, 87);
			this.txtDrinkName.Name = "txtDrinkName";
			this.txtDrinkName.Size = new System.Drawing.Size(175, 22);
			this.txtDrinkName.TabIndex = 2;
			// 
			// cmbxSugar
			// 
			this.cmbxSugar.FormattingEnabled = true;
			this.cmbxSugar.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2"});
			this.cmbxSugar.Location = new System.Drawing.Point(617, 146);
			this.cmbxSugar.Name = "cmbxSugar";
			this.cmbxSugar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbxSugar.Size = new System.Drawing.Size(121, 24);
			this.cmbxSugar.TabIndex = 3;
			// 
			// cmbMilk
			// 
			this.cmbMilk.FormattingEnabled = true;
			this.cmbMilk.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2"});
			this.cmbMilk.Location = new System.Drawing.Point(170, 146);
			this.cmbMilk.Name = "cmbMilk";
			this.cmbMilk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbMilk.Size = new System.Drawing.Size(121, 24);
			this.cmbMilk.TabIndex = 4;
			// 
			// cmbCocoa
			// 
			this.cmbCocoa.FormattingEnabled = true;
			this.cmbCocoa.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2"});
			this.cmbCocoa.Location = new System.Drawing.Point(319, 146);
			this.cmbCocoa.Name = "cmbCocoa";
			this.cmbCocoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbCocoa.Size = new System.Drawing.Size(121, 24);
			this.cmbCocoa.TabIndex = 5;
			// 
			// cmbCoffee
			// 
			this.cmbCoffee.FormattingEnabled = true;
			this.cmbCoffee.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2"});
			this.cmbCoffee.Location = new System.Drawing.Point(470, 146);
			this.cmbCoffee.Name = "cmbCoffee";
			this.cmbCoffee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbCoffee.Size = new System.Drawing.Size(121, 24);
			this.cmbCoffee.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(704, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "סוכר";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(257, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "חלב";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(406, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "קקאו";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(557, 127);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "קפה";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(93, 148);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(61, 22);
			this.txtPrice.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(120, 129);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 16);
			this.label7.TabIndex = 14;
			this.label7.Text = "מחיר";
			// 
			// btnIncrement
			// 
			this.btnIncrement.Location = new System.Drawing.Point(52, 148);
			this.btnIncrement.Name = "btnIncrement";
			this.btnIncrement.Size = new System.Drawing.Size(35, 23);
			this.btnIncrement.TabIndex = 15;
			this.btnIncrement.Text = "+";
			this.btnIncrement.UseVisualStyleBackColor = true;
			// 
			// btnDecrement
			// 
			this.btnDecrement.Location = new System.Drawing.Point(12, 148);
			this.btnDecrement.Name = "btnDecrement";
			this.btnDecrement.Size = new System.Drawing.Size(35, 23);
			this.btnDecrement.TabIndex = 16;
			this.btnDecrement.Text = "-";
			this.btnDecrement.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(12, 397);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(121, 46);
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "שמירה";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(12, 338);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(121, 46);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "מחק";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(12, 276);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(121, 46);
			this.btnUpdate.TabIndex = 19;
			this.btnUpdate.Text = "עדכן";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 214);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(121, 46);
			this.btnAdd.TabIndex = 20;
			this.btnAdd.Text = "הוסף סוג שתייה";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgvDrinks
			// 
			this.dgvDrinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDrinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sugar,
            this.coffee,
            this.cocoa,
            this.milk,
            this.price});
			this.dgvDrinks.Location = new System.Drawing.Point(170, 226);
			this.dgvDrinks.Name = "dgvDrinks";
			this.dgvDrinks.RowHeadersWidth = 51;
			this.dgvDrinks.RowTemplate.Height = 24;
			this.dgvDrinks.Size = new System.Drawing.Size(556, 212);
			this.dgvDrinks.TabIndex = 21;
			// 
			// sugar
			// 
			this.sugar.HeaderText = "סוכר";
			this.sugar.MinimumWidth = 6;
			this.sugar.Name = "sugar";
			// 
			// coffee
			// 
			this.coffee.HeaderText = "קפה";
			this.coffee.MinimumWidth = 6;
			this.coffee.Name = "coffee";
			// 
			// cocoa
			// 
			this.cocoa.HeaderText = "קקאו";
			this.cocoa.MinimumWidth = 6;
			this.cocoa.Name = "cocoa";
			// 
			// milk
			// 
			this.milk.HeaderText = "חלב";
			this.milk.MinimumWidth = 6;
			this.milk.Name = "milk";
			// 
			// price
			// 
			this.price.HeaderText = "מחיר";
			this.price.MinimumWidth = 6;
			this.price.Name = "price";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvDrinks);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDecrement);
			this.Controls.Add(this.btnIncrement);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbCoffee);
			this.Controls.Add(this.cmbCocoa);
			this.Controls.Add(this.cmbMilk);
			this.Controls.Add(this.cmbxSugar);
			this.Controls.Add(this.txtDrinkName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDrinkName;
		private System.Windows.Forms.ComboBox cmbxSugar;
		private System.Windows.Forms.ComboBox cmbMilk;
		private System.Windows.Forms.ComboBox cmbCocoa;
		private System.Windows.Forms.ComboBox cmbCoffee;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnIncrement;
		private System.Windows.Forms.Button btnDecrement;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView dgvDrinks;
		private System.Windows.Forms.DataGridViewTextBoxColumn sugar;
		private System.Windows.Forms.DataGridViewTextBoxColumn coffee;
		private System.Windows.Forms.DataGridViewTextBoxColumn cocoa;
		private System.Windows.Forms.DataGridViewTextBoxColumn milk;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
	}
}

