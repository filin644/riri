using System;
using System.Windows.Forms;
using ClassLibraryForArray;

namespace Lab_2
{
	public partial class Table3 : Form // Форма для отображения таблицы с результатом.
	{
		IntArray arr;
		double[] doubleArr;
		string description; // Описание результата.

		public Table3(IntArray arr, string description) // Конструктор 1, принимающий целочисленный массив.
		{
			InitializeComponent();
			this.arr = arr;
			this.description = description;
		}

		public Table3(double[] doubleArr, string description) // Конструктор 2, принимающий вещественный массив.
		{
			InitializeComponent();
			this.doubleArr = doubleArr;
			this.description = description;
		}

		private void Table3_Load(object sender, EventArgs e) // Событие при загрузке формы.
		{
			label1.Text = description;
			if (arr != null) // Если нужно отобразить целочисленный массив.
			{
				dataGridView3.RowCount = arr.Length; // Кол-во строк таблицы = длина массива.
				for (int i = 0; i < dataGridView3.RowCount; i++)
				{
					dataGridView3.Rows[i].Cells[0].Value = arr[i]; // Вывод массива.
				}
			}
			if (doubleArr != null) // Если нужно отобразить вещественный массив.
			{
				dataGridView3.RowCount = doubleArr.Length; // Кол-во строк таблицы = длина массива.
				for (int i = 0; i < dataGridView3.RowCount; i++)
				{
					dataGridView3.Rows[i].Cells[0].Value = doubleArr[i]; // Вывод массива.
				}
			}
		}
	}
}