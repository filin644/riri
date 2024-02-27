using System;
using System.Windows.Forms;

namespace Lab_2
{
	public partial class Multiples : Form // Диалог для ввода числа.
	{
		public int num; // Число, кратные которому будем искать. Доступно из родительской формы Form1.

		public Multiples()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) // Событие при нажатии кнопки ОК.
		{
			if (int.TryParse(textBox1.Text, out int result)) // Попробовать получить целое число.
			{
				num = result; // Число получено.
				if (num != 0)
				{
					DialogResult = DialogResult.OK; // Диалог успешен.
				}
				else MessageBox.Show("Нельзя делить на 0", "Ошибка");
			}
			else
			{
				MessageBox.Show("Неправильный формат ввода числа", "Ошибка");
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)  // Событие при нажатии клавиатуры в текстовом поле.
		{
			if (char.IsNumber(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back) // Допустимые символы: цифры, минус, Backspace.
			{
				return;
			}
			else
			{
				e.Handled = true; // Запретить символ.
			}
		}
	}
}