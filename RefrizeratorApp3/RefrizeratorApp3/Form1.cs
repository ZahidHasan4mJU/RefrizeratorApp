using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrizeratorApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Refrizerator aRefrizerator;
        private void saveButton_Click(object sender, EventArgs e)
        {
           aRefrizerator = new Refrizerator(Convert.ToDouble(maxWeightTextBox.Text));
            MessageBox.Show(@"Maximum wight has been entered");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aRefrizerator.NoOfItems = Convert.ToDouble(noOfItemsTextBox.Text);
            aRefrizerator.WightPerunit = Convert.ToDouble(weightPerUnitTextBox.Text);

            try
            {
                aRefrizerator.addItem();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Overflow");
            }
            currentWeightTextBox.Text = aRefrizerator.CurrentWeight.ToString();
            remainingWeightTextBox.Text = aRefrizerator.Remainingweight.ToString();
        }
    }
}
