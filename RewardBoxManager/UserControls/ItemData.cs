using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UserControls.ItemData
{
    public partial class ItemData: UserControl
    {
        public ItemData()
        {
            InitializeComponent();
        }

        public Image Icon
        {
            get { return IMG_Icon.Image; }
            set { IMG_Icon.Image = value; }
        }

        public string NameText
        {
            get { return T_Name.Text; }
            set { T_Name.Text = value; }
        }

        public string CodeText
        {
            get { return T_Code.Text; }
            set { T_Code.Text = value; }
        }

        public string WidthText
        {
            get { return T_Width.Text; }
            set { T_Width.Text = $"가로 : {value}"; }
        }

        public string HeightText
        {
            get { return T_Height.Text; }
            set { T_Height.Text = $"높이 : {value}"; }
        }

        public string WeightText
        {
            get { return T_Weight.Text; }
            set { T_Weight.Text = $"무게 : {value}"; }
        }

        public string AmountText
        {
            get { return T_Amount.Text; }
            set { T_Amount.Text = $"수량 : {value}"; }
        }

        private void OnClick_Item(object sender, EventArgs e)
        {

        }

    }
}
