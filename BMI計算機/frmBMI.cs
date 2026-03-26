using System;
using System.Drawing; // 引入 System.Drawing 以使用 Color
using System.Windows.Forms;

namespace BMI計算機
{
    public partial class frmBMI : Form
    {
        // 定義 BMI 結果描述陣列
        string[] strResultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };

        // 定義對應的顏色陣列
        Color[] colorList = {
            Color.FromArgb(173, 216, 230), // 淡淡藍 (過輕)
            Color.FromArgb(193, 255, 193), // 淡淡綠 (健康)
            Color.FromArgb(255, 224, 178), // 淡淡橘黃 (過重)
            Color.FromArgb(255, 197, 148), // 淡淡粉橘 (輕度)
            Color.FromArgb(255, 182, 193), // 淡淡粉紅 (中度)
            Color.FromArgb(230, 230, 250)  // 淡淡紫 (重度)
        };

        public frmBMI()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // --- 1. 變數宣告 ---
            double height = 0;
            double weight = 0;
            double bmi = 0;
            double minHealthyWeight = 0;
            double maxHealthyWeight = 0;
            string strResult = "";
            Color colorResult = Color.Black;
            int resultIndex = 0;

            // --- 2. 輸入驗證 (防錯處理) ---
            // 驗證身高輸入
            bool isHeightValid = double.TryParse(txtHeight.Text, out height);
            if (isHeightValid)
            {
                if (height <= 0)
                {
                    MessageBox.Show("身高必須大於零。", "身高值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的身高數值。", "身高值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 驗證體重輸入
            bool isWeightValid = double.TryParse(txtWeight.Text, out weight);
            if (isWeightValid)
            {
                if (weight <= 0)
                {
                    MessageBox.Show("體重必須大於零。", "體重值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的體重數值。", "體重值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- 3. 數值計算 ---
            // 計算 BMI (身高先除以 100 換算成公尺)
            double heightInMeter = height / 100;
            bmi = weight / (heightInMeter * heightInMeter);

            // 計算健康體重範圍 (BMI 18.5 ~ 24)
            minHealthyWeight = 18.5 * (heightInMeter * heightInMeter);
            maxHealthyWeight = 24.0 * (heightInMeter * heightInMeter);

            // --- 4. 邏輯判斷 ---
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

            // --- 5. 結果顯示 ---
            // 顯示 BMI 值 (格式化為兩位小數) 和描述文字
            lblResult.Text = $"{bmi:F2} ({strResult})";
            lblResult.BackColor = colorResult;

            // 顯示建議體重範圍 (格式化為一位小數)
            lblRecommand.Text = $"{minHealthyWeight:F1} ~ {maxHealthyWeight:F1} (kg)";
        }
    }
}