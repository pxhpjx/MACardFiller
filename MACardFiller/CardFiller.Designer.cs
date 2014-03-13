namespace MACardFiller
{
    partial class CardFiller
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardFiller));
            this.pbCard = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtLv = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtATK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.chkSize = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCard
            // 
            this.pbCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCard.Location = new System.Drawing.Point(12, 12);
            this.pbCard.Name = "pbCard";
            this.pbCard.Size = new System.Drawing.Size(322, 450);
            this.pbCard.TabIndex = 0;
            this.pbCard.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(366, 40);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(63, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "选择图鉴";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(354, 13);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(302, 21);
            this.txtImagePath.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(537, 40);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(63, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "重新载入";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtLv
            // 
            this.txtLv.Location = new System.Drawing.Point(354, 130);
            this.txtLv.MaxLength = 3;
            this.txtLv.Name = "txtLv";
            this.txtLv.Size = new System.Drawing.Size(41, 21);
            this.txtLv.TabIndex = 4;
            this.txtLv.TextChanged += new System.EventHandler(this.txtLv_TextChanged);
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(354, 180);
            this.txtHP.MaxLength = 6;
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(54, 21);
            this.txtHP.TabIndex = 8;
            this.txtHP.TextChanged += new System.EventHandler(this.txtHP_TextChanged);
            // 
            // txtATK
            // 
            this.txtATK.Location = new System.Drawing.Point(354, 230);
            this.txtATK.MaxLength = 6;
            this.txtATK.Name = "txtATK";
            this.txtATK.Size = new System.Drawing.Size(54, 21);
            this.txtATK.TabIndex = 8;
            this.txtATK.TextChanged += new System.EventHandler(this.txtATK_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "ATK:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(472, 178);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "移除数据";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(354, 304);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 11;
            this.btnOutput.Text = "输出";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // chkSize
            // 
            this.chkSize.AutoSize = true;
            this.chkSize.Location = new System.Drawing.Point(440, 44);
            this.chkSize.Name = "chkSize";
            this.chkSize.Size = new System.Drawing.Size(72, 16);
            this.chkSize.TabIndex = 12;
            this.chkSize.Text = "任意尺寸";
            this.chkSize.UseVisualStyleBackColor = true;
            // 
            // CardFiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 473);
            this.Controls.Add(this.chkSize);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtATK);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.txtLv);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.pbCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardFiller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PP\'s MACardFiller";
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCard;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtLv;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtATK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.CheckBox chkSize;
    }
}

