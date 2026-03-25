using System;
using System.Windows.Forms;

namespace BMI計算機
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //可以用"this.xxx"來抓我們要的原件
            double height = double.Parse(txtHeight.Text) / 100;
            double weight = double.Parse(txtWeight.Text);
            // 計算BMI
            double bmi = weight / (height * height);

            // 顯示結果
            lblResult.Text = $"{bmi:F2}";
        }
    }
}
