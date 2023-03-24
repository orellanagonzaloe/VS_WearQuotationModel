using QuarkAcademy_DesafioFinal.nsDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuarkAcademy_DesafioFinal.nsPresenter
{
    internal class Presenter
    {
        private readonly Form1 form1;
        Store store;
        Seller seller;

        public List<Quote> Quotes = new List<Quote>();

        public Presenter(Form1 form)
        {
            form1 = form;

            store = new Store("DummyStoreName", "DummyStoreAddress");
            store.GenerateInventory();

            form1.SetStore(store.Name, store.Address);

            seller = new Seller("DummySellerName", "DummySellerSurname", "DummySellerCode");

            form1.SetSeller(seller.Name, seller.Code);

        }

        public void Quotation()
        {
            Quote quote = new Quote();

            quote.Number = Quotes.Count;
            quote.DateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            quote.Code = seller.Code;
            quote.Quantity = Int32.Parse(form1.Quantity.Text);

            if (form1.RB_trouser.Checked)
            {
                Trouser trouser = new Trouser(form1.RB_t_s.Checked, form1.RB_prem.Checked, quote.Quantity);
                quote.wear = trouser;
            }
            else
            {
                Shirt shirt = new Shirt(form1.RB_s_s.Checked, form1.RB_s_m.Checked, form1.RB_prem.Checked, quote.Quantity);
                quote.wear = shirt;
            }

            int AvUnits = store.Inventory[quote.wear.GetStringCode()].Quantity;

            if (AvUnits == 0)
            {
                form1.Quotation.Text = "Error";
                form1.AvailableUnits.Text = "0";
                form1.SetResult("Error", "0");
                MessageBox.Show("That kind of wear is not availible anymore", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            quote.wear.Price = float.Parse(form1.UnitaryPrice.Text);

            quote.Quotate();

            Quotes.Add(quote);

            form1.SetResult(quote.Result.ToString("N4"), AvUnits.ToString());

        }

    }
}
