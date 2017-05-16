using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opgave1 {
	public partial class Products : System.Web.UI.Page {
		protected void Page_Load( object sender, EventArgs e ) {

		}

		protected void Button1_Click( object sender, EventArgs e ) {
			// Set variables
			int price, amount;
			string currencyType = "DKK";
			double currencyToCalculate = 1, equals;
			const double currencyDKK = 1; const double currencyEuro = 7.437; const double CurrencyDollar = 6.837;
			bool priceOK = int.TryParse( Pris.Text, out price );
			bool amountOK = int.TryParse( Antal.Text, out amount );

			// Finding out what currency is chosen
			int selectedValue = int.Parse( currency.SelectedValue );
			switch( selectedValue ) {
				case 0:

				currencyToCalculate = currencyDKK;
				currencyType = "DKK";
				break;

				case 1:

				currencyToCalculate = currencyEuro;
				currencyType = "EUR";
				break;

				case 2:

				currencyToCalculate = CurrencyDollar;
				currencyType = "USD";
				break;

			}

			// Check if Moms is set, and calculate based on it
			if( with.Checked == true ) {

				equals = Math.Round( System.Convert.ToDouble( ( price * amount - ( ( price * amount ) * 0.25 ) ) / currencyToCalculate ), 2 );
				valuta.Text = "( " + price + " * " + amount + " - ( ( " + price + " * " + amount + " ) * 0.25 ) ) / " + currencyToCalculate + " ) == " + equals;

			} else {

				equals = Math.Round( System.Convert.ToDouble( ( price * amount ) / currencyToCalculate ), 2 );
				valuta.Text = "( " + price + " * " + amount + " ) / " + currencyToCalculate + " ) == " + equals;

			}

			// Check if error statement is placed
			if( priceOK == true && amountOK == true ) {
				Lig.Text = equals.ToString() + " " + currencyType;
				Error.Text = "None!";

			} else {

				Error.Text = "Price or amount isn't OK!";
			}
		}
	}
}