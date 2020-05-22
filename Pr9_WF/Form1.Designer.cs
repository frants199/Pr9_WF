namespace Pr9_WF
{
	partial class Pr9
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
			this.tasts = new System.Windows.Forms.TabControl();
			this.task1_page = new System.Windows.Forms.TabPage();
			this.execute1_button = new System.Windows.Forms.Button();
			this.result1_box = new System.Windows.Forms.RichTextBox();
			this.result1_label = new System.Windows.Forms.Label();
			this.text1_box = new System.Windows.Forms.RichTextBox();
			this.text1_label = new System.Windows.Forms.Label();
			this.task2_page = new System.Windows.Forms.TabPage();
			this.execute2_button = new System.Windows.Forms.Button();
			this.result2_box = new System.Windows.Forms.RichTextBox();
			this.result2_label = new System.Windows.Forms.Label();
			this.letter_label = new System.Windows.Forms.Label();
			this.letter_position_box = new System.Windows.Forms.NumericUpDown();
			this.tasts.SuspendLayout();
			this.task1_page.SuspendLayout();
			this.task2_page.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.letter_position_box)).BeginInit();
			this.SuspendLayout();
			// 
			// tasts
			// 
			this.tasts.Controls.Add(this.task1_page);
			this.tasts.Controls.Add(this.task2_page);
			this.tasts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tasts.Location = new System.Drawing.Point(0, 0);
			this.tasts.Name = "tasts";
			this.tasts.SelectedIndex = 0;
			this.tasts.Size = new System.Drawing.Size(313, 224);
			this.tasts.TabIndex = 0;
			// 
			// task1_page
			// 
			this.task1_page.Controls.Add(this.execute1_button);
			this.task1_page.Controls.Add(this.result1_box);
			this.task1_page.Controls.Add(this.result1_label);
			this.task1_page.Controls.Add(this.text1_box);
			this.task1_page.Controls.Add(this.text1_label);
			this.task1_page.Location = new System.Drawing.Point(4, 25);
			this.task1_page.Name = "task1_page";
			this.task1_page.Padding = new System.Windows.Forms.Padding(3);
			this.task1_page.Size = new System.Drawing.Size(305, 195);
			this.task1_page.TabIndex = 0;
			this.task1_page.Text = "Задание 1";
			this.task1_page.UseVisualStyleBackColor = true;
			// 
			// execute1_button
			// 
			this.execute1_button.Location = new System.Drawing.Point(8, 160);
			this.execute1_button.Name = "execute1_button";
			this.execute1_button.Size = new System.Drawing.Size(289, 27);
			this.execute1_button.TabIndex = 4;
			this.execute1_button.Text = "Выполнить";
			this.execute1_button.UseVisualStyleBackColor = true;
			this.execute1_button.Click += new System.EventHandler(this.execute1_button_Click);
			// 
			// result1_box
			// 
			this.result1_box.Enabled = false;
			this.result1_box.Location = new System.Drawing.Point(94, 85);
			this.result1_box.Name = "result1_box";
			this.result1_box.ReadOnly = true;
			this.result1_box.Size = new System.Drawing.Size(203, 74);
			this.result1_box.TabIndex = 3;
			this.result1_box.Text = "";
			// 
			// result1_label
			// 
			this.result1_label.AutoSize = true;
			this.result1_label.Location = new System.Drawing.Point(8, 85);
			this.result1_label.Name = "result1_label";
			this.result1_label.Size = new System.Drawing.Size(80, 17);
			this.result1_label.TabIndex = 2;
			this.result1_label.Text = "Результат:";
			// 
			// text1_box
			// 
			this.text1_box.Location = new System.Drawing.Point(75, 6);
			this.text1_box.Name = "text1_box";
			this.text1_box.Size = new System.Drawing.Size(222, 73);
			this.text1_box.TabIndex = 1;
			this.text1_box.Text = "";
			// 
			// text1_label
			// 
			this.text1_label.AutoSize = true;
			this.text1_label.Location = new System.Drawing.Point(8, 14);
			this.text1_label.Name = "text1_label";
			this.text1_label.Size = new System.Drawing.Size(50, 17);
			this.text1_label.TabIndex = 0;
			this.text1_label.Text = "Текст:";
			// 
			// task2_page
			// 
			this.task2_page.Controls.Add(this.letter_position_box);
			this.task2_page.Controls.Add(this.letter_label);
			this.task2_page.Controls.Add(this.execute2_button);
			this.task2_page.Controls.Add(this.result2_box);
			this.task2_page.Controls.Add(this.result2_label);
			this.task2_page.Location = new System.Drawing.Point(4, 25);
			this.task2_page.Name = "task2_page";
			this.task2_page.Padding = new System.Windows.Forms.Padding(3);
			this.task2_page.Size = new System.Drawing.Size(305, 195);
			this.task2_page.TabIndex = 1;
			this.task2_page.Text = "Задание 2";
			this.task2_page.UseVisualStyleBackColor = true;
			// 
			// execute2_button
			// 
			this.execute2_button.Location = new System.Drawing.Point(8, 146);
			this.execute2_button.Name = "execute2_button";
			this.execute2_button.Size = new System.Drawing.Size(289, 27);
			this.execute2_button.TabIndex = 7;
			this.execute2_button.Text = "Выполнить";
			this.execute2_button.UseVisualStyleBackColor = true;
			this.execute2_button.Click += new System.EventHandler(this.execute2_button_Click);
			// 
			// result2_box
			// 
			this.result2_box.Enabled = false;
			this.result2_box.Location = new System.Drawing.Point(94, 44);
			this.result2_box.Name = "result2_box";
			this.result2_box.ReadOnly = true;
			this.result2_box.Size = new System.Drawing.Size(203, 74);
			this.result2_box.TabIndex = 6;
			this.result2_box.Text = "";
			// 
			// result2_label
			// 
			this.result2_label.AutoSize = true;
			this.result2_label.Location = new System.Drawing.Point(8, 44);
			this.result2_label.Name = "result2_label";
			this.result2_label.Size = new System.Drawing.Size(80, 17);
			this.result2_label.TabIndex = 5;
			this.result2_label.Text = "Результат:";
			// 
			// letter_label
			// 
			this.letter_label.AutoSize = true;
			this.letter_label.Location = new System.Drawing.Point(8, 15);
			this.letter_label.Name = "letter_label";
			this.letter_label.Size = new System.Drawing.Size(112, 17);
			this.letter_label.TabIndex = 8;
			this.letter_label.Text = "Позиция буквы:";
			// 
			// letter_position_box
			// 
			this.letter_position_box.Location = new System.Drawing.Point(126, 15);
			this.letter_position_box.Name = "letter_position_box";
			this.letter_position_box.Size = new System.Drawing.Size(45, 22);
			this.letter_position_box.TabIndex = 9;
			// 
			// Pr9
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 224);
			this.Controls.Add(this.tasts);
			this.Name = "Pr9";
			this.Text = "Практика 9";
			this.tasts.ResumeLayout(false);
			this.task1_page.ResumeLayout(false);
			this.task1_page.PerformLayout();
			this.task2_page.ResumeLayout(false);
			this.task2_page.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.letter_position_box)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tasts;
		private System.Windows.Forms.TabPage task1_page;
		private System.Windows.Forms.TabPage task2_page;
		private System.Windows.Forms.RichTextBox result1_box;
		private System.Windows.Forms.Label result1_label;
		private System.Windows.Forms.RichTextBox text1_box;
		private System.Windows.Forms.Label text1_label;
		private System.Windows.Forms.Button execute1_button;
		private System.Windows.Forms.Button execute2_button;
		private System.Windows.Forms.RichTextBox result2_box;
		private System.Windows.Forms.Label result2_label;
		private System.Windows.Forms.NumericUpDown letter_position_box;
		private System.Windows.Forms.Label letter_label;
	}
}

