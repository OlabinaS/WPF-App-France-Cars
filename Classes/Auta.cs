using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Auta
	{
		public String Marka { get; set; }
		public String Model { get; set; }
		public int Kubikaza { get; set; }
		public DateTime DatumIzmene { get; set; }
		public String Text { get; set; }
		public String PictureFile { get; set; }

		public Auta()
		{

		}

		public Auta(string marka, string model, int kubikaza, DateTime vreme, string text, string pf)
		{
			Marka = marka;
			Model = model;
			Kubikaza = kubikaza;
			DatumIzmene = vreme;
			Text = text;
			PictureFile = pf;
		}


	}

	public class Marke
	{
		public static List<string> marke = new List<string>() { "Bugatti", "Citroen", "Peugeot", "Renault", "Other"};
	}

	public class VelicinaFonta
	{
		public static List<string> vFont = new List<string>() { "6", "8", "10", "11", "12", "13", "14", "15", "16", "17", "18", "20", "22", "24" };
	}

	public class BojeTeksta
	{
		public static List<string> boje = new List<string>() { "Red", "Green", "Blue", "Orange", "White", "Black", "Yellow", "Purple", "Pink"};
	}
}
