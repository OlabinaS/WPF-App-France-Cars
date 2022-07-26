using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Classes;

namespace WpfApp
{
	/// <summary>
	/// Interaction logic for Izmeni.xaml
	/// </summary>
	public partial class Izmeni : Window
	{
		public Izmeni(int index)
		{
			InitializeComponent();

			cmbMarka.ItemsSource = Marke.marke;
			cmbMarka.SelectedItem = MainWindow.Automobili[index].Marka;

			cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
			cmbFontSize.ItemsSource = VelicinaFonta.vFont;
			cmbFontColor.ItemsSource = BojeTeksta.boje;

			textBoxModel.Text = MainWindow.Automobili[index].Model;
			textBoxKubikaza.Text = Convert.ToString(MainWindow.Automobili[index].Kubikaza);
			textBoxBrowse.Text = MainWindow.Automobili[index].PictureFile;

			rtbEditor.Document.Blocks.Clear();
			rtbEditor.Document.Blocks.Add(new Paragraph(new Run(MainWindow.Automobili[index].Text)));

			labelIndex.Content = Convert.ToString(index);
		}

		private void btnBrowse_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
			dialog.DefaultExt = ".jpg";
			dialog.Filter = "Picture documents (.jpg)|*.jpg";

			Nullable<bool> result = dialog.ShowDialog();

			if (result == true)
			{
				string name = dialog.FileName;
				textBoxBrowse.Text = name;
			}
		}

		private void cmbFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if(cmbFontSize.SelectedItem != null && !rtbEditor.Selection.IsEmpty)
			{
				rtbEditor.Selection.ApplyPropertyValue(FontSizeProperty, cmbFontSize.SelectedItem);
			}
		}

		private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (cmbFontFamily.SelectedItem != null && !rtbEditor.Selection.IsEmpty)
				rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
		}

		private void cmbFontColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (cmbFontColor.SelectedItem != null && !rtbEditor.Selection.IsEmpty)
			{
				rtbEditor.Selection.ApplyPropertyValue(Inline.ForegroundProperty, cmbFontColor.SelectedItem);
			}
		}

		private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
		{
			object temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
			btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));

			temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
			cmbFontFamily.SelectedItem = temp;

			//italic
			temp = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
			btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));

			//underline
			temp = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
			btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

			//FontSize
			temp = rtbEditor.Selection.GetPropertyValue(FontSizeProperty);
			cmbFontSize.SelectedItem = temp;

			//Color
			string richText = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd).Text;
			string[] strSplit;
			strSplit = richText.Split(' ');

			labelWordCount.Content = Convert.ToString(strSplit.Length);
		}
		private void btnIzmeni_Click(object sender, RoutedEventArgs e)
		{
			int index = Convert.ToInt32(labelIndex.Content);
			if(validate())
			{
				string richText = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd).Text;

				MainWindow.Automobili[index].Marka = (string)cmbMarka.SelectedItem;
				MainWindow.Automobili[index].Model = textBoxModel.Text;
				MainWindow.Automobili[index].Kubikaza = Convert.ToInt32(textBoxKubikaza.Text);
				MainWindow.Automobili[index].DatumIzmene = DateTime.Now;
				MainWindow.Automobili[index].Text = richText;
				MainWindow.Automobili[index].PictureFile = textBoxBrowse.Text;

				this.Close();
			}
			else
			{
				MessageBox.Show("Neka polja nisu pravilno popunjena!!", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private bool validate()
		{
			bool isValid = true;

			if (cmbMarka.SelectedItem == null)
			{
				isValid = false;
				MarkaError.Content = "Odaberite Marku automobila!!";
			}
			else
			{
				MarkaError.Content = "";
			}

			if (textBoxModel.Text.Trim().Equals(string.Empty) || textBoxModel.Text.Equals("Unesite Model"))
			{
				isValid = false;
				ModelError.Content = "Unesite Model automobila!!";
				textBoxModel.BorderBrush = Brushes.Red;
			}
			else
			{
				ModelError.Content = "";
				textBoxModel.BorderBrush = Brushes.Black;
			}

			if (!(Int32.TryParse(textBoxKubikaza.Text.Trim(), out int i)))
			{
				isValid = false;
				KubikazaError.Content = "Unesite Kubikazu automobila!!";
				textBoxKubikaza.BorderBrush = Brushes.Red;
			}
			else
			{
				KubikazaError.Content = "";
				textBoxKubikaza.BorderBrush = Brushes.Black;
			}

			string richText = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd).Text;

			if (richText.Trim().Equals(string.Empty))
			{
				isValid = false;
				TextError.Content = "Unesite Tekst o automobilu!!";
				rtbEditor.BorderBrush = Brushes.Red;
			}
			else
			{
				TextError.Content = "";
				rtbEditor.BorderBrush = Brushes.Black;
			}

			return isValid;
		}

		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			this.DragMove();
		}
	}
}
