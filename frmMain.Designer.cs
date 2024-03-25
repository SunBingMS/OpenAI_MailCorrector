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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.txtBaseUrl = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtApiKey = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBefore = new ReaLTaiizor.Controls.RichTextBoxEdit();
            this.txtAfter = new ReaLTaiizor.Controls.RichTextBoxEdit();
            this.btnCorrect = new ReaLTaiizor.Controls.ForeverButton();
            this.controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            this.themeForm1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.tableLayoutPanel2);
            this.themeForm1.Controls.Add(this.tableLayoutPanel1);
            this.themeForm1.Controls.Add(this.btnCorrect);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.94223F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.05777F));
            this.tableLayoutPanel2.Controls.Add(this.labelEdit1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBaseUrl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtApiKey, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelEdit2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.78572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.21429F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(727, 56);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelEdit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit1.Location = new System.Drawing.Point(3, 0);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(51, 15);
            this.labelEdit1.TabIndex = 7;
            this.labelEdit1.Text = "BaseUrl";
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.BackColor = System.Drawing.Color.Transparent;
            this.txtBaseUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBaseUrl.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBaseUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtBaseUrl.Image = null;
            this.txtBaseUrl.Location = new System.Drawing.Point(3, 18);
            this.txtBaseUrl.MaxLength = 32767;
            this.txtBaseUrl.Multiline = false;
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.ReadOnly = false;
            this.txtBaseUrl.Size = new System.Drawing.Size(328, 38);
            this.txtBaseUrl.TabIndex = 9;
            this.txtBaseUrl.Text = "https://openkey.cloud/v1/chat/completions";
            this.txtBaseUrl.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBaseUrl.UseSystemPasswordChar = false;
            // 
            // txtApiKey
            // 
            this.txtApiKey.BackColor = System.Drawing.Color.Transparent;
            this.txtApiKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApiKey.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtApiKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtApiKey.Image = null;
            this.txtApiKey.Location = new System.Drawing.Point(337, 18);
            this.txtApiKey.MaxLength = 32767;
            this.txtApiKey.Multiline = false;
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.ReadOnly = false;
            this.txtApiKey.Size = new System.Drawing.Size(387, 38);
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
            this.labelEdit2.Location = new System.Drawing.Point(337, 0);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(44, 15);
            this.labelEdit2.TabIndex = 13;
            this.labelEdit2.Text = "ApiKey";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel1.Controls.Add(this.txtBefore, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAfter, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 265);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // txtBefore
            // 
            this.txtBefore.AutoWordSelection = false;
            this.txtBefore.BackColor = System.Drawing.Color.Transparent;
            this.txtBefore.BaseColor = System.Drawing.Color.Transparent;
            this.txtBefore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBefore.EdgeColor = System.Drawing.Color.White;
            this.txtBefore.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBefore.ForeColor = System.Drawing.Color.DimGray;
            this.txtBefore.Location = new System.Drawing.Point(3, 3);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.ReadOnly = false;
            this.txtBefore.Size = new System.Drawing.Size(255, 259);
            this.txtBefore.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.txtBefore.TabIndex = 8;
            this.txtBefore.TextBackColor = System.Drawing.Color.White;
            this.txtBefore.TextBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBefore.TextFont = new System.Drawing.Font("Tahoma", 10F);
            this.txtBefore.WordWrap = true;
            // 
            // txtAfter
            // 
            this.txtAfter.AutoWordSelection = false;
            this.txtAfter.BackColor = System.Drawing.Color.Transparent;
            this.txtAfter.BaseColor = System.Drawing.Color.Transparent;
            this.txtAfter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAfter.EdgeColor = System.Drawing.Color.White;
            this.txtAfter.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAfter.ForeColor = System.Drawing.Color.DimGray;
            this.txtAfter.Location = new System.Drawing.Point(264, 3);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.ReadOnly = false;
            this.txtAfter.Size = new System.Drawing.Size(460, 259);
            this.txtAfter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.txtAfter.TabIndex = 15;
            this.txtAfter.TextBackColor = System.Drawing.Color.White;
            this.txtAfter.TextBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAfter.TextFont = new System.Drawing.Font("Tahoma", 10F);
            this.txtAfter.WordWrap = true;
            // 
            // btnCorrect
            // 
            this.btnCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "FormMain";
            this.Text = "OpenAI Email Corrector";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.themeForm1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

