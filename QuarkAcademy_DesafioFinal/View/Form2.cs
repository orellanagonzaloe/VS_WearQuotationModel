using QuarkAcademy_DesafioFinal.nsDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarkAcademy_DesafioFinal.View
{
    public partial class Form2 : Form
    {
        public List<Quote> Quotes = new List<Quote>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        public void CreateHistory()
        {
            string history = "";

            for (int i = 0; i < Quotes.Count; i++)
            {
                history += String.Format("Date and time: {0}, Seller code: {1}, Wear type: {2}, Quantity: {3}, Quotation: {4}" + Environment.NewLine, Quotes[i].DateTime, Quotes[i].Code, Quotes[i].wear.GetStringCode(), Quotes[i].Quantity, Quotes[i].Result);
            }

            HistoryBox.Text = history;
        }

    }
}
