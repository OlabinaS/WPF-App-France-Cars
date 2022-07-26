using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Classes;

namespace WpfApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public static BindingList<Auta> Automobili { get; set; }
		public MainWindow()
		{
			InitializeComponent();

			if(Automobili == null)
			{
				Automobili = new BindingList<Auta>();
			}
			DataContext = this;
		}

		private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			this.DragMove();
		}

		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void btnDodaj_Click(object sender, RoutedEventArgs e)
		{
			Dodaj newWindow = new Dodaj();
			newWindow.ShowDialog();
		}

		private void btnProcitaj_Click(object sender, RoutedEventArgs e)
		{
			Procitaj newWindow = new Procitaj(Automobili.IndexOf((Auta)dataGridCar.SelectedItem));
			newWindow.ShowDialog();
		}

		private void btnIzmeni_Click(object sender, RoutedEventArgs e)
		{
			Izmeni newWindow = new Izmeni(Automobili.IndexOf((Auta)dataGridCar.SelectedItem));
			newWindow.ShowDialog();
		}

		private void btnObrisi_Click(object sender, RoutedEventArgs e)
		{
			Automobili.Remove((Auta)dataGridCar.SelectedItem);
		}
	}
}
