using System;
using System.Drawing; // 引入 System.Drawing 以使用 Color 和 Image
using System.IO;     // 引入 System.IO 以檢查檔案
using System.Windows.Forms;

namespace BMI計算機
{
    public partial class frmBMI : Form
    {
        // 1. 結果描述與顏色陣列 (保留原本嚴謹架構)
        string[] strResultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
        Color[] colorList = {
            Color.FromArgb(173, 216, 230), Color.FromArgb(193, 255, 193),
            Color.FromArgb(255, 224, 178), Color.FromArgb(255, 197, 148),
            Color.FromArgb(255, 182, 193), Color.FromArgb(230, 230, 250)
        };

        public frmBMI()
        {
            InitializeComponent();
            // 初始化 ComboBox 預設選取
            if (cmbHeight.Items.Count > 0) cmbHeight.SelectedIndex = 0;
            if (cmbWeight.Items.Count > 0) cmbWeight.SelectedIndex = 0;
            if (cmbGender.Items.Count > 0) cmbGender.SelectedIndex = 0;

            // PictureBox 初始設定
            picResult.Visible = false;
            picResult.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // --- 1. 變數宣告 ---
            double height = 0, weight = 0, hMeter = 0, wKg = 0;
            int resultIndex = 0;

            // --- 2. 輸入驗證 ---
            if (!double.TryParse(txtHeight.Text, out height) || height <= 0)
            {
                MessageBox.Show("請輸入有效身高", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (!double.TryParse(txtWeight.Text, out weight) || weight <= 0)
            {
                MessageBox.Show("請輸入有效體重", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            // --- 3. 單位換算與雙重防呆 ---
            // 身高處理
            if (cmbHeight.Text.Contains("呎") || cmbHeight.Text.ToLower().Contains("ft"))
                hMeter = height * 0.3048;
            else if (cmbHeight.Text.Contains("公分") || cmbHeight.Text.ToLower().Contains("cm"))
                hMeter = height / 100;
            else
            {
                hMeter = height;
                if (height > 3) MessageBox.Show("提醒：單位為公尺但數值 > 3？", "防呆", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // 體重處理
            if (cmbWeight.Text.Contains("磅") || cmbWeight.Text.ToLower().Contains("lb"))
            {
                wKg = weight * 0.45359;
                if (weight > 1100) MessageBox.Show("提醒：磅數異常過高？", "防呆", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                wKg = weight;
                if (weight > 500) MessageBox.Show("提醒：公斤數異常過高？", "防呆", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // --- 4. 數值計算 ---
            double bmi = wKg / (hMeter * hMeter);
            double minWkg = 18.5 * (hMeter * hMeter);
            double maxWkg = 24.0 * (hMeter * hMeter);

            // --- 5. 區間判斷 ---
            if (bmi < 18.5) resultIndex = 0;
            else if (bmi < 24) resultIndex = 1;
            else if (bmi < 27) resultIndex = 2;
            else if (bmi < 30) resultIndex = 3;
            else if (bmi < 35) resultIndex = 4;
            else resultIndex = 5;

            // --- 6. 結果顯示 ---
            lblResult.Text = $"{bmi:F2} ({strResultList[resultIndex]})";
            lblResult.BackColor = colorList[resultIndex];

            // 建議體重單位連動
            if (cmbWeight.Text.Contains("磅") || cmbWeight.Text.ToLower().Contains("lb"))
                lblRecommand.Text = $"{minWkg / 0.45359:F1} ~ {maxWkg / 0.45359:F1} (lb)";
            else
                lblRecommand.Text = $"{minWkg:F1} ~ {maxWkg:F1} (kg)";

            // --- 7. 性別圖片顯示 ---
            LoadResultImageWithGender(resultIndex);
        }

        private void LoadResultImageWithGender(int index)
        {
            string genderKey = (cmbGender.Text == "女生") ? "female" : "male";
            string fileName = "";

            if (index == 0) fileName = $"eatmore_{genderKey}.png";
            else if (index == 1) fileName = $"healthy_{genderKey}.png";
            else fileName = $"strong_{genderKey}.png";

            // 修改點：加上 Images/ 路徑
            string filePath = Path.Combine(Application.StartupPath, "Images", fileName);

            if (File.Exists(filePath))
            {
                if (picResult.Image != null) picResult.Image.Dispose();

                // 使用從 Images 資料夾讀取的路徑
                picResult.Image = Image.FromFile(filePath);
                picResult.Visible = true;
            }
            else
            {
                // 偵錯用：如果還是找不到，顯示程式到底在找哪裡
                // MessageBox.Show($"找不到檔案：{filePath}");
                picResult.Visible = false;
            }
        }

        // Enter 鍵直接計算功能
        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 消除嗶聲
                btnRun_Click(sender, e);
            }
        }
    }
}