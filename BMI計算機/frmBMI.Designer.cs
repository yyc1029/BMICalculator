namespace BMI計算機
{
    partial class frmBMI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRecommand = new System.Windows.Forms.Label();
            this.lblKG = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.cmbHeight = new System.Windows.Forms.ComboBox();
            this.cmbWeight = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbWeight);
            this.groupBox1.Controls.Add(this.cmbHeight);
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(33, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "輸入";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(536, 48);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(183, 170);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "計算";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Location = new System.Drawing.Point(255, 112);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(258, 43);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Location = new System.Drawing.Point(255, 50);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(258, 43);
            this.txtHeight.TabIndex = 1;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(27, 116);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(69, 34);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "體重";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(27, 52);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(69, 34);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "身高";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRecommand);
            this.groupBox2.Controls.Add(this.lblKG);
            this.groupBox2.Controls.Add(this.lblResult);
            this.groupBox2.Controls.Add(this.lblBMI);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(33, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "計算結果";
            // 
            // lblRecommand
            // 
            this.lblRecommand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecommand.Location = new System.Drawing.Point(289, 104);
            this.lblRecommand.Name = "lblRecommand";
            this.lblRecommand.Size = new System.Drawing.Size(398, 34);
            this.lblRecommand.TabIndex = 5;
            this.lblRecommand.Text = "                                                        ";
            this.lblRecommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Location = new System.Drawing.Point(15, 104);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(123, 34);
            this.lblKG.TabIndex = 4;
            this.lblKG.Text = "建議體重";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(289, 46);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(398, 34);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "                                                        ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(15, 46);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(246, 34);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.Text = "身體質量指數(BMI)";
            // 
            // cmbHeight
            // 
            this.cmbHeight.FormattingEnabled = true;
            this.cmbHeight.Items.AddRange(new object[] {
            "公尺",
            "呎"});
            this.cmbHeight.Location = new System.Drawing.Point(114, 50);
            this.cmbHeight.Name = "cmbHeight";
            this.cmbHeight.Size = new System.Drawing.Size(121, 42);
            this.cmbHeight.TabIndex = 0;
            this.cmbHeight.Text = "單位";
            // 
            // cmbWeight
            // 
            this.cmbWeight.FormattingEnabled = true;
            this.cmbWeight.Items.AddRange(new object[] {
            "公斤\t",
            "磅"});
            this.cmbWeight.Location = new System.Drawing.Point(114, 113);
            this.cmbWeight.Name = "cmbWeight";
            this.cmbWeight.Size = new System.Drawing.Size(121, 42);
            this.cmbWeight.TabIndex = 2;
            this.cmbWeight.Text = "單位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "性別";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "男生\t",
            "女生"});
            this.cmbGender.Location = new System.Drawing.Point(114, 176);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 42);
            this.cmbGender.TabIndex = 4;
            this.cmbGender.Text = "男/女";
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(812, 61);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(326, 377);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 2;
            this.picResult.TabStop = false;
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 475);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI計算機";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblRecommand;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.ComboBox cmbWeight;
        private System.Windows.Forms.ComboBox cmbHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.PictureBox picResult;
    }
}

