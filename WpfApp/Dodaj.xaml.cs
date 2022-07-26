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
	/// Interaction logic for Dodaj.xaml
	/// </summary>
	public partial class Dodaj : Window
	{
		public Dodaj()
		{
			InitializeComponent();

			comboBoxMarke.ItemsSource = Marke.marke;
			cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
			cmbFontSize.ItemsSource = VelicinaFonta.vFont;
			cmbFontColor.ItemsSource = BojeTeksta.boje;

			textBoxModel.Text = "Unesite Model";
			textBoxModel.Foreground = Brushes.LightSlateGray;

			textBoxKubikaza.Text = "Unesite Kubikazu";
			textBoxKubikaza.Foreground = Brushes.LightSlateGray;

		}

		private void btnDodaj_Click(object sender, RoutedEventArgs e)
		{
			Auta novi;

			if(validate())
			{
				string richText = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd).Text;

				if (textBoxBrowse.Text.Trim().Equals(string.Empty))
				{
					novi = new Auta(comboBoxMarke.SelectedValue.ToString(), textBoxModel.Text,
									Convert.ToInt32(textBoxKubikaza.Text), DateTime.Now, richText, "All_logo.jpg");
				}
				else
				{
					novi = new Auta(comboBoxMarke.SelectedValue.ToString(), textBoxModel.Text,
									Convert.ToInt32(textBoxKubikaza.Text), DateTime.Now, richText, textBoxBrowse.Text);
				}

				MainWindow.Automobili.Add(novi);
				this.Close();
			}
			else
			{
				MessageBox.Show("Niste popunili sva polja!!", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void btnBrowse_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
			dialog.DefaultExt = ".jpg";
			dialog.Filter = "Picture documents (.jpg)|*.jpg";

			Nullable<bool> result = dialog.ShowDialog();

			if(result == true)
			{
				string name = dialog.FileName;
				textBoxBrowse.Text = name;
			}
		}

		

		private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (cmbFontFamily.SelectedItem != null && !rtbEditor.Selection.IsEmpty)
				rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
		}

		private void cmbFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (cmbFontSize.SelectedItem != null && !rtbEditor.Selection.IsEmpty)
			{
				rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.SelectedItem);
			}
		}

		private void cmbFontColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if(cmbFontColor.SelectedItem != null && !rtbEditor.Selection.IsEmpty)
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

			//font
			temp = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
			cmbFontSize.SelectedItem = temp;

			//color
			temp = rtbEditor.Selection.GetPropertyValue(Inline.ForegroundProperty);
			cmbFontColor.SelectedItem = temp;

			//Word count
			string richText = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd).Text;
			string[] strSplit;
			strSplit = richText.Split(' ');


			labelWordCount.Content = Convert.ToString(strSplit.Length);
		}

		private bool validate()
		{
			bool isValid = true;

			if(comboBoxMarke.SelectedItem == null)
			{
				isValid = false;
				MarkaError.Content = "Odaberite Marku automobila!!";
			}
			else
			{
				MarkaError.Content = "";
			}

			if(textBoxModel.Text.Trim().Equals(string.Empty) || textBoxModel.Text.Equals("Unesite Model"))
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

			if(richText.Trim().Equals(string.Empty))
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

		private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			this.DragMove();
		}

		private void btnIzadji_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void textBoxModel_GotFocus(object sender, RoutedEventArgs e)
		{
			if(textBoxModel.Text.Trim().Equals("Unesite Model"))
			{
				textBoxModel.Text = "";
				textBoxModel.Foreground = Brushes.Black;
			}
		}

		private void textBoxModel_LostFocus(object sender, RoutedEventArgs e)
		{
			if(textBoxModel.Text.Trim().Equals(string.Empty))
			{
				textBoxModel.Text = "Unesite Model";
				textBoxModel.Foreground = Brushes.LightSlateGray;
			}
		}

		private void textBoxKubikaza_GotFocus(object sender, RoutedEventArgs e)
		{
			if(textBoxKubikaza.Text.Trim().Equals("Unesite Kubikazu"))
			{
				textBoxKubikaza.Text = "";
				textBoxKubikaza.Foreground = Brushes.Black;
			}
		}

		private void textBoxKubikaza_LostFocus(object sender, RoutedEventArgs e)
		{
			if(textBoxKubikaza.Text.Trim().Equals(string.Empty))
			{
				textBoxKubikaza.Text = "Unesite Kubikazu";
				textBoxKubikaza.Foreground = Brushes.LightSlateGray;
			}
		}
	}
}
