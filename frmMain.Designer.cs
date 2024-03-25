namespace EmailCorrector
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            this.txtAfter = new ReaLTaiizor.Controls.RichTextBoxEdit();
            this.txtApiKey = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.btnCorrect = new ReaLTaiizor.Controls.ForeverButton();
            this.txtBaseUrl = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtBefore = new ReaLTaiizor.Controls.RichTextBoxEdit();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            this.themeForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.txtAfter);
            this.themeForm1.Controls.Add(this.txtApiKey);
            this.themeForm1.Controls.Add(this.labelEdit2);
            this.themeForm1.Controls.Add(this.btnCorrect);
            this.themeForm1.Controls.Add(this.txtBaseUrl);
            this.themeForm1.Controls.Add(this.txtBefore);
            this.themeForm1.Controls.Add(this.labelEdit1);
            this.themeForm1.Controls.Add(this.controlBox1);
            this.themeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.themeForm1.Image = ((System.Drawing.Image)(resources.GetObject("themeForm1.Image")));
            this.themeForm1.Location = new System.Drawing.Point(0, 0);
            this.themeForm1.Name = "themeForm1";
            this.themeForm1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.themeForm1.RoundCorners = true;
            this.themeForm1.Sizable = true;
            this.themeForm1.Size = new System.Drawing.Size(761, 463);
            this.themeForm1.SmartBounds = true;
            this.themeForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.themeForm1.TabIndex = 7;
            this.themeForm1.Text = "OpenAI Email Corrector";
            // 
            // txtAfter
            // 
            this.txtAfter.AutoWordSelection = false;
            this.txtAfter.BackColor = System.Drawing.Color.Transparent;
            this.txtAfter.BaseColor = System.Drawing.Color.Transparent;
            this.txtAfter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAfter.EdgeColor = System.Drawing.Color.White;
            this.txtAfter.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAfter.ForeColor = System.Drawing.Color.DimGray;
            this.txtAfter.Location = new System.Drawing.Point(294, 138);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.ReadOnly = false;
            this.txtAfter.Size = new System.Drawing.Size(449, 265);
            this.txtAfter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.txtAfter.TabIndex = 15;
            this.txtAfter.TextBackColor = System.Drawing.Color.White;
            this.txtAfter.TextBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAfter.TextFont = new System.Drawing.Font("Tahoma", 10F);
            this.txtAfter.WordWrap = true;
            // 
            // txtApiKey
            // 
            this.txtApiKey.BackColor = System.Drawing.Color.Transparent;
            this.txtApiKey.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtApiKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtApiKey.Image = null;
            this.txtApiKey.Location = new System.Drawing.Point(361, 94);
            this.txtApiKey.MaxLength = 32767;
            this.txtApiKey.Multiline = false;
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.ReadOnly = false;
            this.txtApiKey.Size = new System.Drawing.Size(382, 38);
            this.txtApiKey.TabIndex = 14;
            this.txtApiKey.Text = "sk-YY3oeipPdqfx2INyqiYIhXDk81U12WWszNfHFRQ5SnrRjKzX";
            this.txtApiKey.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApiKey.UseSystemPasswordChar = false;
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelEdit2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit2.Location = new System.Drawing.Point(358, 76);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(44, 15);
            this.labelEdit2.TabIndex = 13;
            this.labelEdit2.Text = "ApiKey";
            // 
            // btnCorrect
            // 
            this.btnCorrect.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnCorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCorrect.Location = new System.Drawing.Point(16, 409);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Rounded = false;
            this.btnCorrect.Size = new System.Drawing.Size(120, 40);
            this.btnCorrect.TabIndex = 11;
            this.btnCorrect.Text = "Correct";
            this.btnCorrect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnCorrect.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.BackColor = System.Drawing.Color.Transparent;
            this.txtBaseUrl.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBaseUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtBaseUrl.Image = null;
            this.txtBaseUrl.Location = new System.Drawing.Point(16, 94);
            this.txtBaseUrl.MaxLength = 32767;
            this.txtBaseUrl.Multiline = false;
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.ReadOnly = false;
            this.txtBaseUrl.Size = new System.Drawing.Size(331, 38);
            this.txtBaseUrl.TabIndex = 9;
            this.txtBaseUrl.Text = "https://openkey.cloud/v1/chat/completions";
            this.txtBaseUrl.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBaseUrl.UseSystemPasswordChar = false;
            // 
            // txtBefore
            // 
            this.txtBefore.AutoWordSelection = false;
            this.txtBefore.BackColor = System.Drawing.Color.Transparent;
            this.txtBefore.BaseColor = System.Drawing.Color.Transparent;
            this.txtBefore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtBefore.EdgeColor = System.Drawing.Color.White;
            this.txtBefore.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBefore.ForeColor = System.Drawing.Color.DimGray;
            this.txtBefore.Location = new System.Drawing.Point(16, 138);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.ReadOnly = false;
            this.txtBefore.Size = new System.Drawing.Size(272, 265);
            this.txtBefore.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.txtBefore.TabIndex = 8;
            this.txtBefore.TextBackColor = System.Drawing.Color.White;
            this.txtBefore.TextBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBefore.TextFont = new System.Drawing.Font("Tahoma", 10F);
            this.txtBefore.WordWrap = true;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelEdit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit1.Location = new System.Drawing.Point(13, 76);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(51, 15);
            this.labelEdit1.TabIndex = 7;
            this.labelEdit1.Text = "BaseUrl";
            // 
            // controlBox1
            // 
            this.controlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.controlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.controlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlBox1.DefaultLocation = true;
            this.controlBox1.EnableHoverHighlight = true;
            this.controlBox1.EnableMaximizeButton = true;
            this.controlBox1.EnableMinimizeButton = true;
            this.controlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.controlBox1.Location = new System.Drawing.Point(661, 18);
            this.controlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.controlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(90, 25);
            this.controlBox1.TabIndex = 6;
            this.controlBox1.Text = "controlBox1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 463);
            this.Controls.Add(this.themeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "FormMain";
            this.Text = "OpenAI Email Corrector";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.themeForm1.ResumeLayout(false);
            this.themeForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.RichTextBoxEdit txtBefore;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private ReaLTaiizor.Controls.ForeverButton btnCorrect;
        private ReaLTaiizor.Controls.TextBoxEdit txtBaseUrl;
        private ReaLTaiizor.Controls.TextBoxEdit txtApiKey;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.RichTextBoxEdit txtAfter;
    }
}

