using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
namespace Pr13_WF
{
	public partial class Pr13 : Form
	{
		List<Trans> trans = new List<Trans>();
		private void fill_tabel(List<Trans> array, DataGridView tabel)
		{
			tabel.RowCount = array.Count;
			for (int i = 0; i < tabel.RowCount; ++i)
			{
				array[i].info(tabel.Rows[i]);
			}
		}
		private List<Trans> search(List<Trans> collection, double capasity)
		{
			List<Trans> rez = new List<Trans>();
			for (int i = 0; i < collection.Count; i++)
			{
				if (collection[i].get_capasity() == capasity) rez.Add(collection[i]);
			}
			return rez;
		}
		public Pr13()
		{
			InitializeComponent();
			try
			{
				string path = @"C:\Users\User\Desktop\Trans.txt";
				string[] all_lines = File.ReadAllLines(path);
				for (int i = 0; i < all_lines.Length; i++)
				{
					string[] position = all_lines[i].Split(';');
					if (position.Length == 3)
					{
						Car car = new Car(position[0], position[1], Convert.ToDouble(position[2]));
						trans.Add(car);
					}
					else
					{
						if (position.Length == 4)
						{
							if (Convert.ToDouble(position[2]) <= 0.4)
							{
								Motorcycle motorcycle = new Motorcycle(position[0], position[1], Convert.ToDouble(position[2]), Convert.ToBoolean(position[3]));
								trans.Add(motorcycle);
							}
							else
							{
								Truck truck = new Truck(position[0], position[1], Convert.ToDouble(position[2]), Convert.ToBoolean(position[3]));
								trans.Add(truck);
							}
						}

					}
				}
				fill_tabel(trans, trans_tabel);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void search_button_Click(object sender, EventArgs e)
		{
			try
			{
				List<Trans> find_position = search(trans, Convert.ToDouble(capasity_box.Text));
				if (find_position.Count==0) throw new Exception("Нет элементов, удовлетворяющих условию поиска");
				else   
				fill_tabel(find_position, trans_tabel);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void reset_button_Click(object sender, EventArgs e)
		{
			try
			{
				capasity_box.Clear();
				fill_tabel(trans, trans_tabel);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
