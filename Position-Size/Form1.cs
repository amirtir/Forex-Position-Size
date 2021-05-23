using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Position_Size
{
    public partial class Form1 : Form
    {
        double ValueofOnePip, ContractSize, PositionValue;
        float   AcountSize, RiskRatio, StopLossPips, MarginValue,ValuePerPip;

      
        private void btnResult_Click(object sender, EventArgs e)
        {
          
            AcountSize = Convert.ToInt32(txtAcountSize.Text);
            RiskRatio = Convert.ToInt32(txtRiskRatio.Text);
            StopLossPips = Convert.ToInt32(txtStopLossPips.Text);
            ValueofOnePip = Convert.ToDouble(txtValueofOnePip.Text);
            ContractSize = ValueofOnePip * 10000;

            MarginValue = AcountSize * RiskRatio / 100;

            ValuePerPip = MarginValue / StopLossPips * (10000);

            PositionValue = ValuePerPip / ContractSize;
            double PositionValuef = Math.Round(PositionValue * 100.0) / 100.0;


            lblPositionValue.Text = PositionValuef.ToString() + " " + "لات";

            lblMargin.Text = MarginValue.ToString() + " " + "دلار";


        
        }

        public Form1()
        {
       

            InitializeComponent();
        }


      
      
      
    }
}
