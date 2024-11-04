using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.ItemData;

namespace RewardBoxManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            ItemData newItem = new ItemData();
            newItem.Icon = Properties.Resources.Axe;
            newItem.NameText = "Axe";
            newItem.CodeText = "ITEM_W001";
            newItem.WidthText = "2";
            newItem.HeightText = "2";
            newItem.WeightText = "1.5";
            newItem.AmountText = "1";

            FLP_Items.Controls.Add(newItem);
        }
    }
}
