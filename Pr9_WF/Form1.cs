using System;
using System.IO;
using System.Windows.Forms;

namespace Pr9_WF
{
	public partial class Pr9 : Form
	{
		public Pr9()
		{
			InitializeComponent();
		}
		

		private void execute1_button_Click(object sender, EventArgs e)
		{
			try
			{
				string str = text1_box.Text;
				if (str == "") result1_box.Text = "Пустая строка";
				else
				{
					for (int i = 0; i < str.Length; i++)
					{
						if (char.IsPunctuation(str[i])) str = str.Replace(str[i], ' ');
					}
					FileStream file = new FileStream(@"C:\Users\User\Desktop\file.dat", FileMode.Open);
					BinaryWriter file_write = new BinaryWriter(file);
					file_write.Write(str);
					file_write.Close();
					file = new FileStream(@"C:\Users\User\Desktop\file.dat", FileMode.Open);
					BinaryReader file_read = new BinaryReader(file);
					str = file_read.ReadString();
					file_read.Close();
					file.Close();
					result1_box.Text = str;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void execute2_button_Click(object sender, EventArgs e)
		{
			StreamReader file=null;
			try
			{
				file = new StreamReader(@"C:\Users\User\Desktop\input.txt");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
			if (file.ReadToEnd() != "")
			{
				file.Close();
				file = new StreamReader(@"C:\Users\User\Desktop\input.txt");
				char[] splitters = { ' ', ',', '.', '!', '?', ':', ';' };
				string[] str = file.ReadToEnd().Split(splitters);
				file.Close();
				string word = "";
				int k = 0;
				try
				{
					k = Convert.ToInt32(letter_position_box.Value);
				}
				catch (ArgumentException)
				{
					MessageBox.Show("Недопустимое значение");
				}
				foreach (string var in str)
				{
					try
					{
						word += var[k];
					}
					catch (IndexOutOfRangeException)
					{
						MessageBox.Show("Выход за пределы диапазона");
					}
				}
				result2_box.Text = word;
				System.Diagnostics.Process.Start(@"C:\Users\User\Desktop\input.txt");
			}
			else MessageBox.Show("Файл пуст");
		}
	}
}
