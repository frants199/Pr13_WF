namespace Pr13_WF
{
	partial class Pr13
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.trans_tabel = new System.Windows.Forms.DataGridView();
			this.search_label = new System.Windows.Forms.Label();
			this.capasity_box = new System.Windows.Forms.TextBox();
			this.search_button = new System.Windows.Forms.Button();
			this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Capasity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Stroller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Trailer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reset_button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trans_tabel)).BeginInit();
			this.SuspendLayout();
			// 
			// trans_tabel
			// 
			this.trans_tabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.trans_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.trans_tabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mark,
            this.Number,
            this.Capasity,
            this.Stroller,
            this.Trailer});
			this.trans_tabel.Location = new System.Drawing.Point(12, 37);
			this.trans_tabel.Name = "trans_tabel";
			this.trans_tabel.RowTemplate.Height = 24;
			this.trans_tabel.Size = new System.Drawing.Size(620, 150);
			this.trans_tabel.TabIndex = 0;
			// 
			// search_label
			// 
			this.search_label.AutoSize = true;
			this.search_label.Location = new System.Drawing.Point(12, 9);
			this.search_label.Name = "search_label";
			this.search_label.Size = new System.Drawing.Size(141, 17);
			this.search_label.TabIndex = 1;
			this.search_label.Text = "Грузоподъемность: ";
			// 
			// capasity_box
			// 
			this.capasity_box.Location = new System.Drawing.Point(159, 9);
			this.capasity_box.Name = "capasity_box";
			this.capasity_box.Size = new System.Drawing.Size(100, 22);
			this.capasity_box.TabIndex = 2;
			// 
			// search_button
			// 
			this.search_button.Location = new System.Drawing.Point(277, 8);
			this.search_button.Name = "search_button";
			this.search_button.Size = new System.Drawing.Size(75, 24);
			this.search_button.TabIndex = 3;
			this.search_button.Text = "Найти";
			this.search_button.UseVisualStyleBackColor = true;
			this.search_button.Click += new System.EventHandler(this.search_button_Click);
			// 
			// Mark
			// 
			this.Mark.HeaderText = "Марка";
			this.Mark.Name = "Mark";
			this.Mark.Width = 79;
			// 
			// Number
			// 
			this.Number.HeaderText = "Номер";
			this.Number.Name = "Number";
			this.Number.Width = 80;
			// 
			// Capasity
			// 
			this.Capasity.HeaderText = "Грузоподъемность";
			this.Capasity.Name = "Capasity";
			this.Capasity.Width = 162;
			// 
			// Stroller
			// 
			this.Stroller.HeaderText = "Коляска";
			this.Stroller.Name = "Stroller";
			this.Stroller.Width = 92;
			// 
			// Trailer
			// 
			this.Trailer.HeaderText = "Прицеп";
			this.Trailer.Name = "Trailer";
			this.Trailer.Width = 87;
			// 
			// reset_button
			// 
			this.reset_button.Location = new System.Drawing.Point(358, 8);
			this.reset_button.Name = "reset_button";
			this.reset_button.Size = new System.Drawing.Size(75, 24);
			this.reset_button.TabIndex = 4;
			this.reset_button.Text = "Сброс";
			this.reset_button.UseVisualStyleBackColor = true;
			this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
			// 
			// Pr13
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 200);
			this.Controls.Add(this.reset_button);
			this.Controls.Add(this.search_button);
			this.Controls.Add(this.capasity_box);
			this.Controls.Add(this.search_label);
			this.Controls.Add(this.trans_tabel);
			this.Name = "Pr13";
			this.Text = "Практика 13";
			((System.ComponentModel.ISupportInitialize)(this.trans_tabel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView trans_tabel;
		private System.Windows.Forms.Label search_label;
		private System.Windows.Forms.TextBox capasity_box;
		private System.Windows.Forms.Button search_button;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn Capasity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Stroller;
		private System.Windows.Forms.DataGridViewTextBoxColumn Trailer;
		private System.Windows.Forms.Button reset_button;
	}
}

