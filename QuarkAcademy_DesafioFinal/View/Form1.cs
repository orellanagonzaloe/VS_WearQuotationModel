using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkAcademy_DesafioFinal.nsDomain;
using QuarkAcademy_DesafioFinal.nsPresenter;
using QuarkAcademy_DesafioFinal.View;

namespace QuarkAcademy_DesafioFinal
{
    public partial class Form1 : Form
    {
        private readonly Presenter presenter;
        private Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();

            presenter = new Presenter(this);

        }

        private void RB_trouser_CheckedChanged(object sender, EventArgs e)
        {
            RB_t_n.Enabled = true;
            RB_t_n.Checked = true;
            RB_t_s.Enabled = true;

            RB_t_n.Checked = true;
            RB_t_s.Checked = false;

            RB_s_m.Enabled = false;
            RB_s_n.Enabled = false;
            RB_s_s.Enabled = false;
            RB_s_l.Enabled = false;

            RB_s_m.Checked = false;
            RB_s_n.Checked = false;
            RB_s_s.Checked = false;
            RB_s_l.Checked = false;

            Quotation.Text = "-";
            AvailableUnits.Text = "-";
        }

        private void RB_shirt_CheckedChanged(object sender, EventArgs e)
        {
            RB_t_n.Enabled = false;
            RB_t_s.Enabled = false;

            RB_t_n.Checked = false;
            RB_t_s.Checked = false;

            RB_s_m.Enabled = true;
            RB_s_n.Enabled = true;
            RB_s_s.Enabled = true;
            RB_s_l.Enabled = true;

            RB_s_m.Checked = false;
            RB_s_n.Checked = true;
            RB_s_s.Checked = true;
            RB_s_l.Checked = false;

            Quotation.Text = "-";
            AvailableUnits.Text = "-";
        }

        private void Quote_Click(object sender, EventArgs e)
        {
            presenter.Quotation();
        }

        private void RB_t_n_CheckedChanged(object sender, EventArgs e)
        {
            Quotation.Text = "-";
            AvailableUnits.Text = "-";
        }

        private void RB_t_s_CheckedChanged(object sender, EventArgs e)
        {
            Quotation.Text = "-";
            AvailableUnits.Text = "-";
        }

        private void RB_s_s_CheckedChanged(object sender, EventArgs e)
        {
            Quotation.Text = "-";
            AvailableUnits.Text = "-";
        }

        private void RB_s_l_CheckedChanged(object sender, EventArgs e)
        {
            Quotation.Text = "-";
            AvailableUnits.Text = "-";
        }

        private void RB_s_n_CheckedChanged(object sender, EventArgs e)
        {
            Quotation.Text = "-";
            AvailableUnits.Text = "-";
        }

        private void RB_s_m_CheckedChanged(object sender, EventArgs e)
        {
            Quotation.Text = "-";
            AvailableUnits.Text = "-";
        }

        private void RB_std_CheckedChanged(object sender, EventArgs e)
        {
            Quotation.Text = "-";
            AvailableUnits.Text = "-";
        }

        private void RB_prem_CheckedChanged(object sender, EventArgs e)
        {
            Quotation.Text = "-";
            AvailableUnits.Text = "-";
        }

        private void UnitaryPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void SetStore(string name, string address)
        {
            StoreName.Text = name;
            StoreAddress.Text = address;
        }

        public void SetSeller(string name, string code)
        {
            SellerName.Text = name;
            SellerCode.Text = code;
        }

        public void SetResult(string quotation, string avunits)
        {
            Quotation.Text = quotation;
            AvailableUnits.Text = avunits;
        }

        private void SellerHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form2.Quotes = presenter.Quotes;
            form2.CreateHistory();
            form2.Show();
        }

    }
}
