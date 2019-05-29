using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox3.Clear();
			textBox4.Clear();

			int match1 = Convert.ToInt32(match.Text);
			int mismatch1 = Convert.ToInt32(mismatch.Text);
			int gap1 = Convert.ToInt32(gap.Text);

			if (checkbox1.Checked)
			{
				textBox3.Clear();
				textBox4.Clear();
				panel1.Controls.Clear();
				string dizi1 = textBox1.Text;
				string dizi2 = textBox2.Text;
				int dizi1_length = dizi1.Length;
				int dizi2_length = dizi2.Length;

				char[] d_dizi1 = new char[dizi1_length + 2];
				char[] d_dizi2 = new char[dizi2_length + 2];

				d_dizi1 = dizi1.ToCharArray();
				d_dizi2 = dizi2.ToCharArray();

				string[,] noktaTablosu = new string[dizi2_length + 2, dizi1_length + 2];

				for (int i = 0; i < dizi2_length; i++)
				{
					noktaTablosu[1, 1] = gap1.ToString();

					noktaTablosu[i + 2, 0] = d_dizi2[i].ToString();
					noktaTablosu[i + 2, 1] = gap1.ToString();
					for (int j = 0; j < dizi1_length; j++)
					{
						noktaTablosu[0, j + 2] = d_dizi1[j].ToString();
						noktaTablosu[1, j + 2] = gap1.ToString();
					}
				}
				/////////////////////////////////SAYILARI DİZDİM

				for (int j = 0; j < dizi2_length; j++)
				{
					for (int i = 0; i < dizi1_length; i++)
					{
						if (noktaTablosu[j + 2, 0] == noktaTablosu[0, i + 2])
						{

							int v = Convert.ToInt32(noktaTablosu[j + 1, i + 2]);
							int m = Convert.ToInt32(noktaTablosu[j + 2, i + 1]);
							int n = Convert.ToInt32(noktaTablosu[j + 1, i + 1]);

							int a = Math.Max(v + gap1, m + gap1);
							int b = Math.Max(a, n + match1);
							noktaTablosu[j + 2, i + 2] = b.ToString();
						}
						else
						{
							int v = Convert.ToInt32(noktaTablosu[j + 1, i + 2]);
							int m = Convert.ToInt32(noktaTablosu[j + 2, i + 1]);
							int n = Convert.ToInt32(noktaTablosu[j + 1, i + 1]);

							int a = Math.Max(v + gap1, m + gap1);
							int b = Math.Max(a, n + mismatch1);
							noktaTablosu[j + 2, i + 2] = b.ToString();
						}

					}
				}

				///////////////PANELİ OLUŞTURDUM
				for (int i = 0; i <= dizi2_length + 1; i++)
				{
					for (int j = 0; j <= dizi1_length + 1; j++)
					{
						Label lbl = new Label();
						lbl.BorderStyle = BorderStyle.Fixed3D;
						lbl.BackColor = Color.White;
						lbl.Text = Convert.ToString(noktaTablosu[i, j]);
						lbl.Size = new Size(25, 25);
						lbl.Location = new Point(25 * j, 25 * i);
						panel1.Controls.Add(lbl);

					}
				}
				/////////////////////////EN BÜYÜK SAYIYI BULDUM
				int u;
				int max = Convert.ToInt32(noktaTablosu[dizi2_length + 1, 1]);
				for (u = 2; u < dizi1_length + 1; u++)
				{

					if (Convert.ToInt32(noktaTablosu[dizi2_length + 1, u]) > max)
					{
						max = Convert.ToInt32(noktaTablosu[dizi2_length + 1, u]);
						//z = u;
					}
					else continue;
				}

				int max2 = 1;
				int x = dizi2_length + 1;
				int y = u;
				int sayac1 = 0;
				int sayac2 = 0;
				int sayac3 = 0;
				int sayac4 = 0;
				int sayac5 = 0;
				int sayac6 = 0;
				int sayac7 = 0;
				int sayac8 = 0;

				if (noktaTablosu[2, 0] == noktaTablosu[0, 2])
					sayac7++;
				if (noktaTablosu[x, 0] == noktaTablosu[0, y])
				{
					sayac8++;
					textBox3.SelectedText = noktaTablosu[x , 0];
					textBox4.SelectedText = noktaTablosu[0, y];

				}

				while (max2 != 0)
				{


					if ((Convert.ToInt32(noktaTablosu[x, y - 1]) > Convert.ToInt32(noktaTablosu[x - 1, y])) && (Convert.ToInt32(noktaTablosu[x, y - 1]) > Convert.ToInt32(noktaTablosu[x - 1, y - 1])))
					{
						max2 = 0;
						max2 = Convert.ToInt32(noktaTablosu[x, y - 1]);
						if (noktaTablosu[x, 0] == noktaTablosu[0, y - 1])
						{
							sayac4++;
							
							textBox3.SelectedText = noktaTablosu[x, 0];
							textBox4.SelectedText = noktaTablosu[0, y - 1];
						}
						x = x;
						y = y - 1;
						sayac1 += max2;

					}
					if ((Convert.ToInt32(noktaTablosu[x - 1, y]) > Convert.ToInt32(noktaTablosu[x, y - 1])) && (Convert.ToInt32(noktaTablosu[x - 1, y]) > Convert.ToInt32(noktaTablosu[x - 1, y - 1])))
					{
						max2 = 0;
						max2 = Convert.ToInt32(noktaTablosu[x - 1, y]);
						if (noktaTablosu[x - 1, 0] == noktaTablosu[0, y])
						{
							sayac5++;

							textBox3.SelectedText = noktaTablosu[x - 1, 0];
							textBox4.SelectedText = noktaTablosu[0, y];
							
						}
						x = x - 1;
						y = y;
						sayac2 += max2;

					}
					if ((Convert.ToInt32(noktaTablosu[x - 1, y - 1]) >= Convert.ToInt32(noktaTablosu[x, y - 1])) && (Convert.ToInt32(noktaTablosu[x - 1, y - 1]) >= Convert.ToInt32(noktaTablosu[x - 1, y])))
					{
						max2 = 0;
						max2 = Convert.ToInt32(noktaTablosu[x - 1, y - 1]);
						if (noktaTablosu[x - 1, 0] == noktaTablosu[0, y - 1])
							sayac6++;
						//if (noktaTablosu[2, 0] == noktaTablosu[0, 2])
						//	sayac8++;
						x = x - 1;
						y = y - 1;
						sayac3 += max2;


					}
				}

				string kelime = textBox3.Text;
				string terskelime = "";
				foreach (char harf in kelime)
				{
					terskelime = harf.ToString() + terskelime;
				}
				textBox3.Text = terskelime;

				string kelime2 = textBox4.Text;
				string terskelime2 = "";
				foreach (char harf in kelime2)
				{
					terskelime2 = harf.ToString() + terskelime2;
				}
				textBox4.Text = terskelime2;

				//label4.Text = (sayac1 + sayac2 + sayac3).ToString();

				label5.Text = (sayac6 + sayac7 + sayac8).ToString();

			}




			//////////////////////

			if (checkBox2.Checked)
			{
				textBox3.Clear();
				textBox4.Clear();

				panel1.Controls.Clear();
				string dizi1 = textBox1.Text;
				string dizi2 = textBox2.Text;
				int dizi1_length = dizi1.Length;
				int dizi2_length = dizi2.Length;

				char[] d_dizi1 = new char[dizi1_length + 2];
				char[] d_dizi2 = new char[dizi2_length + 2];

				d_dizi1 = dizi1.ToCharArray();
				d_dizi2 = dizi2.ToCharArray();

				string[,] noktaTablosu = new string[dizi2_length + 2, dizi1_length + 2];

				for (int i = 0; i < dizi2_length; i++)
				{
					if (gap1 <= 0)
					{
						noktaTablosu[1, 1] = 0.ToString();
						noktaTablosu[i + 2, 1] = 0.ToString();
					}
					else
					{
						noktaTablosu[1, 1] = gap1.ToString();
						noktaTablosu[i + 2, 1] = gap1.ToString();
					}
					noktaTablosu[i + 2, 0] = d_dizi2[i].ToString();

					for (int j = 0; j < dizi1_length; j++)
					{
						noktaTablosu[0, j + 2] = d_dizi1[j].ToString();
						if (gap1 <= 0)
							noktaTablosu[1, j + 2] = 0.ToString();
						else
							noktaTablosu[1, j + 2] = gap1.ToString();

					}
				}
				/////////////////////////////////SAYILARI DİZDİM

				for (int j = 0; j < dizi2_length; j++)
				{
					for (int i = 0; i < dizi1_length; i++)
					{
						if (noktaTablosu[j + 2, 0] == noktaTablosu[0, i + 2])
						{

							int v = Convert.ToInt32(noktaTablosu[j + 1, i + 2]);
							int m = Convert.ToInt32(noktaTablosu[j + 2, i + 1]);
							int n = Convert.ToInt32(noktaTablosu[j + 1, i + 1]);

							int a = Math.Max(v + gap1, m + gap1);
							int b = Math.Max(a, n + match1);
							if (b < 0)
								noktaTablosu[j + 2, i + 2] = 0.ToString();
							else
								noktaTablosu[j + 2, i + 2] = b.ToString();
						}
						else
						{
							int v = Convert.ToInt32(noktaTablosu[j + 1, i + 2]);
							int m = Convert.ToInt32(noktaTablosu[j + 2, i + 1]);
							int n = Convert.ToInt32(noktaTablosu[j + 1, i + 1]);

							int a = Math.Max(v + gap1, m + gap1);
							int b = Math.Max(a, n + mismatch1);
							if (b < 0)
								noktaTablosu[j + 2, i + 2] = 0.ToString();
							else
								noktaTablosu[j + 2, i + 2] = b.ToString();
						}

					}
				}

				///////////////PANELİ OLUŞTURDUM
				for (int i = 0; i <= dizi2_length + 1; i++)
				{
					for (int j = 0; j <= dizi1_length + 1; j++)
					{
						Label lbl = new Label();
						lbl.BorderStyle = BorderStyle.Fixed3D;
						lbl.BackColor = Color.White;
						lbl.Text = Convert.ToString(noktaTablosu[i, j]);
						lbl.Size = new Size(25, 25);
						lbl.Location = new Point(25 * j, 25 * i);
						panel1.Controls.Add(lbl);

					}
				}

				int z;

				int max3 = Convert.ToInt32(noktaTablosu[2, 2]);
				
				for (z = 3; z <= dizi2_length + 1; z++)
				{
					
					for (int r = 3; r < dizi1_length + 1; r++)
					{
						if (Convert.ToInt32(noktaTablosu[z, r]) > max3)
						{
							max3 = Convert.ToInt32(noktaTablosu[z, r]);
							gonder(r);
						}
						else
							continue;
					}
					
				}
			//	MessageBox.Show(max3.ToString());
				
				 void gonder(int r)
				{
					textBox3.Clear();
					textBox4.Clear();
					int x = z;
					int y = r;
					int max2 = 1;
					int sayac1 = 0;
					int sayac2 = 0;
					int sayac3 = 0;
					int sayac4 = 0;
					int sayac5 = 0;
					int sayac6 = 0;
					int sayac8 = 0;


					if (noktaTablosu[x, 0] == noktaTablosu[0, y])
					{
						sayac8++;
						textBox3.SelectedText = noktaTablosu[x, 0];
						textBox4.SelectedText = noktaTablosu[0, y];
					}

					while (max2 != 0)
					{


						if ((Convert.ToInt32(noktaTablosu[x, y - 1]) > Convert.ToInt32(noktaTablosu[x - 1, y])) && (Convert.ToInt32(noktaTablosu[x, y - 1]) > Convert.ToInt32(noktaTablosu[x - 1, y - 1])))
						{
							max2 = 0;
							max2 = Convert.ToInt32(noktaTablosu[x, y - 1]);
							if (noktaTablosu[x, 0] == noktaTablosu[0, y - 1])
							{
								sayac4++;
								textBox3.SelectedText = noktaTablosu[x, 0];
								textBox4.SelectedText = noktaTablosu[0,y-1];
							}
							else continue;
							x = x;
							y = y - 1;
							sayac1 += max2;


						}
						if ((Convert.ToInt32(noktaTablosu[x - 1, y]) > Convert.ToInt32(noktaTablosu[x, y - 1])) && (Convert.ToInt32(noktaTablosu[x - 1, y]) > Convert.ToInt32(noktaTablosu[x - 1, y - 1])))
						{
							max2 = 0;
							max2 = Convert.ToInt32(noktaTablosu[x - 1, y]);
							if (noktaTablosu[x - 1, 0] == noktaTablosu[0, y])
							{
								sayac5++;
								textBox3.SelectedText = noktaTablosu[x - 1, 0];
								textBox4.SelectedText = noktaTablosu[0, y];
							}
							else continue;
							x = x - 1;
							y = y;
							sayac2 += max2;

						}
						if ((Convert.ToInt32(noktaTablosu[x - 1, y - 1]) >= Convert.ToInt32(noktaTablosu[x, y - 1])) && (Convert.ToInt32(noktaTablosu[x - 1, y - 1]) >= Convert.ToInt32(noktaTablosu[x - 1, y])))
						{
							max2 = 0;
							max2 = Convert.ToInt32(noktaTablosu[x - 1, y - 1]);

							if (noktaTablosu[x - 1, 0] == noktaTablosu[0, y - 1] && noktaTablosu[0, y - 1] != noktaTablosu[0, y - 2])
							{
								sayac6++;
								textBox3.SelectedText = noktaTablosu[x - 1, 0];
								textBox4.SelectedText = noktaTablosu[0, y - 1];
							}
							else if (max2 == 0) continue;
							else if (noktaTablosu[0, y - 1] == noktaTablosu[0, y - 2])
							{
								textBox3.SelectedText = noktaTablosu[x - 1, 0];
								textBox4.SelectedText = "-";
							}

							x = x - 1;
							y = y - 1;
							sayac3 += max2;

						}
					}

					string kelime = textBox3.Text;
					string terskelime = "";
					foreach (char harf in kelime)
					{
						terskelime = harf.ToString() + terskelime;
					}
					textBox3.Text = terskelime;

					string kelime2 = textBox4.Text;
					string terskelime2 = "";
					foreach (char harf in kelime2)
					{
						terskelime2 = harf.ToString() + terskelime2;
					}
					textBox4.Text = terskelime2;

				//	label4.Text = (sayac1 + sayac2 + sayac3).ToString();

					label5.Text = (sayac6 + sayac8+sayac4+sayac5).ToString();

				
			}

			}

			}


	}
}
