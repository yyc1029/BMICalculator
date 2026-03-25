using System;
using System.Drawing; // 引入 System.Drawing 以使用 Color
using System.Windows.Forms;

namespace BMI計算機
{
    public partial class frmBMI : Form
    {
        // 簡報第一頁：陣列宣告
        // 定義 BMI 結果描述陣列
        string[] strResultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
        // 定義對應的顏色陣列
        Color[] colorList = {
            Color.FromArgb(173, 216, 230), // 淡淡藍
            Color.FromArgb(193, 255, 193), // 淡淡綠
            Color.FromArgb(255, 224, 178), // 淡淡橘黃
            Color.FromArgb(255, 197, 148), // 淡淡粉橘
            Color.FromArgb(255, 182, 193), // 淡淡粉紅
            Color.FromArgb(230, 230, 250)  // 淡淡紫
        };

        public frmBMI()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // 宣告變數用於儲存解析後的數值
            double height = 0;
            double weight = 0;

            // 驗證身高輸入
            bool isHeightValid = double.TryParse(txtHeight.Text, out height);
            if (isHeightValid)
            {
                if (height <= 0)
                {
                    MessageBox.Show("身高必須大於零。", "身高值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // 停止執行
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的身高數值。", "身高值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 停止執行
            }

            // 驗證體重輸入
            bool isWeightValid = double.TryParse(txtWeight.Text, out weight);
            if (isWeightValid)
            {
                if (weight <= 0)
                {
                    MessageBox.Show("體重必須大於零。", "體重值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // 停止執行
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的體重數值。", "體重值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 停止執行
            }

            // 計算 BMI (身高先除以 100 換算成公尺)
            double bmi = weight / ((height / 100) * (height / 100));

            // 簡報第二頁：判斷式
            // 宣告變數用於儲存結果描述、顏色和陣列索引
            string strResult = "";
            Color colorResult = Color.Black;
            int resultIndex = 0;

            // 根據 BMI 值判斷所屬區間，並設定對應的陣列索引
            if (bmi < 18.5)
            {
                resultIndex = 0; // 體重過輕
            }
            else if (bmi < 24)
            {
                resultIndex = 1; // 健康體位
            }
            else if (bmi < 27)
            {
                resultIndex = 2; // 體位過重
            }
            else if (bmi < 30)
            {
                resultIndex = 3; // 輕度肥胖
            }
            else if (bmi < 35)
            {
                resultIndex = 4; // 中度肥胖
            }
            else
            {
                resultIndex = 5; // 重度肥胖
            }

            // 根據索引從陣列中取出對應的描述文字和顏色
            strResult = strResultList[resultIndex];
            colorResult = colorList[resultIndex];

            // 將 BMI 值 (格式化為兩位小數) 和描述文字顯示在 lblResult 上
            lblResult.Text = $"{bmi:F2} ({strResult})";
            // 將 lblResult 的背景顏色設定為對應的顏色
            lblResult.BackColor = colorResult;
        }
    }
}