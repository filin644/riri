using System;
using System.Windows.Forms;
using ClassLibraryForArray;

namespace Lab_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		IntArray ArrayFromTable(DataGridView dgv) // Метод для получения массива из таблицы.
		{
			IntArray arr = new IntArray(dgv.RowCount); // Длина массива = кол-во строк таблицы.
			try
			{
				for (int i = 0; i < arr.Length; i++)
				{
					arr[i] = Convert.ToInt32(dgv.Rows[i].Cells[0].Value); // Получение целого числа из ячейки.
				}
				return arr;
			}
			catch
			{
				MessageBox.Show("Неправильный формат ввода числа", "Ошибка");
				return null;
			}
		}

		void FillTable(DataGridView dgv) // Метод для заполнения таблицы.
		{
			if (random_radioButton.Checked) // Если выбрано случайное заполнение.
			{
				IntArray arr = IntArray.RandomIntArray(dgv.RowCount, -100, 100); // Метод из библиотеки, случайные числа от -100 до 100 включительно.
				for (int i = 0; i < dgv.RowCount; i++)
				{
					dgv.Rows[i].Cells[0].Value = arr[i]; // Вывод массива.
				}
			}

			if (manual_radioButton.Checked) // Если выбрано заполнение вручную.
			{
				foreach (DataGridViewRow row in dgv.Rows)
				{
					row.Cells[0].Value = ""; // Очистить ячейки.
				}
			}

			if (file_radioButton.Checked) // Если выбрано заполнение из файла.
			{
				if (openFileDialog1.ShowDialog() == DialogResult.OK) // Открыть диалоговое окно выбора файла, изменения будут внесены при нажатии ОК.
				{
					IntArray arr = IntArray.ArrayFromTextFile(openFileDialog1.FileName); // Метод из библиотеки.
					if (arr != null)
					{
						dgv.RowCount = arr.Length; // Кол-во строк таблицы = длина массива.
						for (int i = 0; i < dgv.RowCount; i++)
						{
							dgv.Rows[i].Cells[0].Value = arr[i]; // Вывод массива.
						}
					}
					else
					{
						MessageBox.Show("Неправильный формат ввода массива", "Ошибка");
					}
				}
			}
		}

		private void button1_Click(object sender, EventArgs e) // Событие при выборе способа заполнения таблицы 1.
		{
			FillTable(dataGridView1);
			textBox1.Text = dataGridView1.RowCount.ToString(); // Обновление размера в текстовом поле.
		}

		private void button2_Click(object sender, EventArgs e) // Событие при выборе способа заполнения таблицы 2.
		{
			FillTable(dataGridView2);
			textBox2.Text = dataGridView2.RowCount.ToString(); // Обновление размера в текстовом поле.
		}

		private void textBox1_Leave(object sender, EventArgs e) // Событие при потере фокуса (= редактирование завершено) текстового поля Размер таблицы 1.
		{
			if (int.TryParse(textBox1.Text, out int length) && length > 0) // Попробовать получить целое положительное число.
			{
				dataGridView1.RowCount = length; // Изменить размер таблицы.
			}
			else
			{
				MessageBox.Show("Неправильный формат ввода длины", "Ошибка");
			}
		}

		private void textBox2_Leave(object sender, EventArgs e) // Событие при потере фокуса (= редактирование завершено) текстового поля Размер таблицы 2.
		{
			if (int.TryParse(textBox2.Text, out int length) && length > 0) // Попробовать получить целое положительное число.
			{
				dataGridView2.RowCount = length; // Изменить размер таблицы.
			}
			else
			{
				MessageBox.Show("Неправильный формат ввода длины", "Ошибка");
			}
		}

		private void sum1_ToolStripMenuItem_Click(object sender, EventArgs e) // Событие при выборе меню "Сумма элементов - Таблица 1".
		{
			IntArray arr = ArrayFromTable(dataGridView1); // Получить массив из таблицы.
			if (arr != null)
			{
				int sum = IntArray.SumArray(arr); // Метод из библиотеки.
				MessageBox.Show("Сумма элементов таблицы 1:\n" + sum, "Результат");
			}
		}

		private void sum2_ToolStripMenuItem_Click(object sender, EventArgs e) // Событие при выборе меню "Сумма элементов - Таблица 2".
		{
			IntArray arr = ArrayFromTable(dataGridView2); // Получить массив из таблицы.
			if (arr != null)
			{
				int sum = IntArray.SumArray(arr); // Метод из библиотеки.
				MessageBox.Show("Сумма элементов таблицы 2:\n" + sum, "Результат");
			}
		}

		int MultiplesOf(IntArray arr, int num) // Метод для подсчёта элементов, кратных num.
		{
			int count = 0; // Счётчик.
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % num == 0) // Если число делится на num без остатка.
				{
					count++;
				}
			}
			return count;
		}

		private void multiples1_ToolStripMenuItem_Click(object sender, EventArgs e) // Событие при выборе меню "Количество кратных - Таблица 1".
		{
			Multiples dialog = new Multiples(); // Создать диалоговое окно для ввода числа, для которого искать кратные.
			if (dialog.ShowDialog() == DialogResult.OK) // Открыть диалог.
			{
				IntArray arr = ArrayFromTable(dataGridView1); // Получить массив из таблицы.
				if (arr != null)
				{
					int num = dialog.num; // Число, введённое в диалоге.
					int count = MultiplesOf(arr, num); // Подсчёт кратных.
					MessageBox.Show($"Количество элементов таблицы 1, кратных {num}:\n{count}", "Результат");
				}
			}
		}

		private void multiples2_ToolStripMenuItem_Click(object sender, EventArgs e) // Событие при выборе меню "Количество кратных - Таблица 2".
		{
			Multiples dialog = new Multiples(); // Создать диалоговое окно для ввода числа, для которого искать кратные.
			if (dialog.ShowDialog() == DialogResult.OK) // Открыть диалог.
			{
				IntArray arr = ArrayFromTable(dataGridView2); // Получить массив из таблицы.
				if (arr != null)
				{
					int num = dialog.num; // Число, введённое в диалоге.
					int count = MultiplesOf(arr, num); // Подсчёт кратных.
					MessageBox.Show($"Количество элементов таблицы 2, кратных {num}:\n{count}", "Результат");
				}
			}
		}

		private void сложениеМассивовToolStripMenuItem_Click(object sender, EventArgs e) // Событие при выборе меню "Сложение массивов".
		{
			// Получить массивы из обеих таблиц.
			IntArray arr1 = ArrayFromTable(dataGridView1);
			IntArray arr2 = ArrayFromTable(dataGridView2);

			if (arr1 != null && arr2 != null)
			{
				IntArray sum = arr1 + arr2; // Перегруженный оператор +(IntArray x, IntArray y) из библиотеки.

				Table3 form = new Table3(sum, "Сложение массивов:"); // Создать форму для отображения таблицы с результатом.
				form.ShowDialog(); // Открыть таблицу.
			}
		}

		private void вычитаниеМассивовToolStripMenuItem_Click(object sender, EventArgs e) // Событие при выборе меню "Вычитание массивов".
		{
			// Получить массивы из обеих таблиц.
			IntArray arr1 = ArrayFromTable(dataGridView1);
			IntArray arr2 = ArrayFromTable(dataGridView2);

			if (arr1 != null && arr2 != null)
			{
				IntArray diff = arr1 - arr2; // Перегруженный оператор -(IntArray x, IntArray y) из библиотеки.

				Table3 form = new Table3(diff, "Вычитание массивов:"); // Создать форму для отображения таблицы с результатом.
				form.ShowDialog(); // Открыть таблицу.
			}
		}

		// Метод для сортировки положительных элементов вещественного массива по возрастанию, остальные элементы оставить на своих местах.
		double[] SortPositives(DataGridView dgv)
		{
			double[] arr = new double[dgv.RowCount]; // Длина массива = кол-во строк таблицы.
			try
			{
				for (int i = 0; i < arr.Length; i++)
				{
					arr[i] = Convert.ToDouble(dgv.Rows[i].Cells[0].Value); // Получение вещественного числа из ячейки.
				}
			}
			catch
			{
				MessageBox.Show("Неправильный формат ввода числа", "Ошибка");
				return null;
			}

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > 0) // Если элемент arr[i] положительный.
				{
					for (int j = i + 1; j < arr.Length; j++) // Перебираем все элементы впереди arr[i].
					{
						if (arr[j] > 0 && arr[j] < arr[i]) // Если попавшийся элемент тоже положительный и больше arr[i].
						{
							double temp = arr[i]; // Меняем местами больший и меньший элемент.
							arr[i] = arr[j];
							arr[j] = temp;
						}
					}
				}
			}
			return arr;
		}

		private void sort1_ToolStripMenuItem_Click(object sender, EventArgs e) // Событие при выборе меню "Вариант 1 - Таблица 1".
		{
			double[] arr = SortPositives(dataGridView1); // Сортировка.
			if (arr != null)
			{
				Table3 form = new Table3(arr, "Сортировка положительных элементов таблицы 1:"); // Создать форму для отображения таблицы с результатом.
				form.ShowDialog(); // Открыть таблицу.
			}
		}

		private void sort2_ToolStripMenuItem_Click(object sender, EventArgs e) // Событие при выборе меню "Вариант 1 - Таблица 2".
		{
			double[] arr = SortPositives(dataGridView2); // Сортировка.
			if (arr != null)
			{
				Table3 form = new Table3(arr, "Сортировка положительных элементов таблицы 2:"); // Создать форму для отображения таблицы с результатом.
				form.ShowDialog(); // Открыть таблицу.
			}
		}

		private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) // Событие при редактировании ячейки.
		{
			var textBox = (DataGridViewTextBoxEditingControl)e.Control; // Текстовое поле из ячейки.
			textBox.KeyPress += new KeyPressEventHandler(dataGridView_KeyPress); // Проверять значение ячейки на допустимость.
		}

		private void dataGridView_KeyPress(object sender, KeyPressEventArgs e) // Событие при нажатии клавиатуры в таблице.
		{
			if (char.IsNumber(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back) // Допустимые символы: цифры, минус, десятичная запятая, Backspace.
			{
				return;
			}
			else
			{
				e.Handled = true; // Запретить символ.
			}
		}

		private void textBox_KeyPress(object sender, KeyPressEventArgs e) // Событие при нажатии клавиатуры в текстовом поле Размер.
		{
			if (e.KeyChar == (char)Keys.Enter) // При нажатии Enter обновить размер.
			{
				if ((TextBox)sender == textBox1)
				{
					textBox1_Leave(sender, e);
				}
				if ((TextBox)sender == textBox2)
				{
					textBox2_Leave(sender, e);
				}
			}
			if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) // Допустимые символы: цифры, Backspace.
			{
				return;
			}
			else
			{
				e.Handled = true; // Запретить символ.
			}
		}

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}