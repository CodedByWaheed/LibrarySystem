using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.MainScreen.Fines
{
    public partial class ctrlFinesCard : UserControl
    {
        public enum enBorder { Visible = 1, unVisibel = 2 }
        enBorder _Border = enBorder.Visible;
        
        public enBorder Border
        {
            set {
                _Border = value;
                if (value == enBorder.Visible)
                    uiPanel1.RectColor = Color.Black;

                else
                    uiPanel1.RectColor = Color.Transparent;
            }
            get { return _Border; }
        }
        public ctrlFinesCard()
        {
            InitializeComponent();
        }

        private void ctrlFinesCard_Load(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
