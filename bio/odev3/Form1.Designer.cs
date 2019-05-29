namespace odev3
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.match = new System.Windows.Forms.TextBox();
			this.mismatch = new System.Windows.Forms.TextBox();
			this.gap = new System.Windows.Forms.TextBox();
			this.checkbox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(26, 35);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(158, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(26, 72);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(158, 20);
			this.textBox2.TabIndex = 1;
			// 
			// match
			// 
			this.match.Location = new System.Drawing.Point(231, 57);
			this.match.Name = "match";
			this.match.Size = new System.Drawing.Size(53, 20);
			this.match.TabIndex = 2;
			// 
			// mismatch
			// 
			this.mismatch.Location = new System.Drawing.Point(311, 57);
			this.mismatch.Name = "mismatch";
			this.mismatch.Size = new System.Drawing.Size(53, 20);
			this.mismatch.TabIndex = 3;
			// 
			// gap
			// 
			this.gap.Location = new System.Drawing.Point(392, 57);
			this.gap.Name = "gap";
			this.gap.Size = new System.Drawing.Size(53, 20);
			this.gap.TabIndex = 4;
			// 
			// checkbox1
			// 
			this.checkbox1.AutoSize = true;
			this.checkbox1.Location = new System.Drawing.Point(231, 101);
			this.checkbox1.Name = "checkbox1";
			this.checkbox1.Size = new System.Drawing.Size(45, 17);
			this.checkbox1.TabIndex = 5;
			this.checkbox1.Text = "NW";
			this.checkbox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(320, 101);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(44, 17);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "SW";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(228, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Match";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(308, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Mismatch";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(389, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "GAP";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(479, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 57);
			this.button1.TabIndex = 10;
			this.button1.Text = "Gonder";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(45, 140);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(685, 365);
			this.panel1.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(647, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 13);
			this.label5.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(584, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Score : ";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(587, 57);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(105, 20);
			this.textBox3.TabIndex = 16;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(587, 83);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(105, 20);
			this.textBox4.TabIndex = 17;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 517);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkbox1);
			this.Controls.Add(this.gap);
			this.Controls.Add(this.mismatch);
			this.Controls.Add(this.match);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox match;
		private System.Windows.Forms.TextBox mismatch;
		private System.Windows.Forms.TextBox gap;
		private System.Windows.Forms.CheckBox checkbox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
	}
}

