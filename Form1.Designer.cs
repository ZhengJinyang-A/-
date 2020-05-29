namespace 插值小程序
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_StartInterpolate = new System.Windows.Forms.Button();
            this.rtbx_InitialData = new System.Windows.Forms.RichTextBox();
            this.cbx_IsContainInitialData = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbx_InterolatedData = new System.Windows.Forms.RichTextBox();
            this.btn_rtbx_ClearInitialData = new System.Windows.Forms.Button();
            this.btn_rtbx_InterpolatedData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_InterpolateJianju = new System.Windows.Forms.TextBox();
            this.tbx_StartIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ClearXuLie = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbx_xulie = new System.Windows.Forms.RichTextBox();
            this.btn_CreateXuLie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_StartInterpolate
            // 
            this.btn_StartInterpolate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_StartInterpolate.Location = new System.Drawing.Point(748, 101);
            this.btn_StartInterpolate.Name = "btn_StartInterpolate";
            this.btn_StartInterpolate.Size = new System.Drawing.Size(100, 69);
            this.btn_StartInterpolate.TabIndex = 0;
            this.btn_StartInterpolate.Text = "开始插值";
            this.btn_StartInterpolate.UseVisualStyleBackColor = true;
            this.btn_StartInterpolate.Click += new System.EventHandler(this.btn_StartInterpolate_Click);
            // 
            // rtbx_InitialData
            // 
            this.rtbx_InitialData.Location = new System.Drawing.Point(20, 101);
            this.rtbx_InitialData.Name = "rtbx_InitialData";
            this.rtbx_InitialData.Size = new System.Drawing.Size(173, 448);
            this.rtbx_InitialData.TabIndex = 1;
            this.rtbx_InitialData.Text = resources.GetString("rtbx_InitialData.Text");
            // 
            // cbx_IsContainInitialData
            // 
            this.cbx_IsContainInitialData.AutoSize = true;
            this.cbx_IsContainInitialData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_IsContainInitialData.Location = new System.Drawing.Point(405, 162);
            this.cbx_IsContainInitialData.Name = "cbx_IsContainInitialData";
            this.cbx_IsContainInitialData.Size = new System.Drawing.Size(107, 20);
            this.cbx_IsContainInitialData.TabIndex = 2;
            this.cbx_IsContainInitialData.Text = "包含原数据";
            this.cbx_IsContainInitialData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(62, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "原始数据";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(602, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "插值后数据";
            // 
            // rtbx_InterolatedData
            // 
            this.rtbx_InterolatedData.Location = new System.Drawing.Point(553, 100);
            this.rtbx_InterolatedData.Name = "rtbx_InterolatedData";
            this.rtbx_InterolatedData.Size = new System.Drawing.Size(173, 448);
            this.rtbx_InterolatedData.TabIndex = 4;
            this.rtbx_InterolatedData.Text = "";
            // 
            // btn_rtbx_ClearInitialData
            // 
            this.btn_rtbx_ClearInitialData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_rtbx_ClearInitialData.Location = new System.Drawing.Point(44, 567);
            this.btn_rtbx_ClearInitialData.Name = "btn_rtbx_ClearInitialData";
            this.btn_rtbx_ClearInitialData.Size = new System.Drawing.Size(100, 25);
            this.btn_rtbx_ClearInitialData.TabIndex = 6;
            this.btn_rtbx_ClearInitialData.Text = "清空";
            this.btn_rtbx_ClearInitialData.UseVisualStyleBackColor = true;
            this.btn_rtbx_ClearInitialData.Click += new System.EventHandler(this.btn_rtbx_ClearInitialData_Click);
            // 
            // btn_rtbx_InterpolatedData
            // 
            this.btn_rtbx_InterpolatedData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_rtbx_InterpolatedData.Location = new System.Drawing.Point(581, 567);
            this.btn_rtbx_InterpolatedData.Name = "btn_rtbx_InterpolatedData";
            this.btn_rtbx_InterpolatedData.Size = new System.Drawing.Size(100, 25);
            this.btn_rtbx_InterpolatedData.TabIndex = 7;
            this.btn_rtbx_InterpolatedData.Text = "清空";
            this.btn_rtbx_InterpolatedData.UseVisualStyleBackColor = true;
            this.btn_rtbx_InterpolatedData.Click += new System.EventHandler(this.btn_rtbx_InterpolatedData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(402, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "插值间距：";
            // 
            // tbx_InterpolateJianju
            // 
            this.tbx_InterpolateJianju.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_InterpolateJianju.Location = new System.Drawing.Point(480, 130);
            this.tbx_InterpolateJianju.Name = "tbx_InterpolateJianju";
            this.tbx_InterpolateJianju.Size = new System.Drawing.Size(32, 26);
            this.tbx_InterpolateJianju.TabIndex = 9;
            this.tbx_InterpolateJianju.Text = "20";
            this.tbx_InterpolateJianju.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_StartIndex
            // 
            this.tbx_StartIndex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_StartIndex.Location = new System.Drawing.Point(480, 98);
            this.tbx_StartIndex.Name = "tbx_StartIndex";
            this.tbx_StartIndex.Size = new System.Drawing.Size(32, 26);
            this.tbx_StartIndex.TabIndex = 11;
            this.tbx_StartIndex.Text = "0";
            this.tbx_StartIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(402, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "初始值：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "初始值应不小于原始数据的起始索引！";
            // 
            // btn_ClearXuLie
            // 
            this.btn_ClearXuLie.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ClearXuLie.Location = new System.Drawing.Point(236, 567);
            this.btn_ClearXuLie.Name = "btn_ClearXuLie";
            this.btn_ClearXuLie.Size = new System.Drawing.Size(100, 25);
            this.btn_ClearXuLie.TabIndex = 15;
            this.btn_ClearXuLie.Text = "清空";
            this.btn_ClearXuLie.UseVisualStyleBackColor = true;
            this.btn_ClearXuLie.Click += new System.EventHandler(this.btn_ClearXuLie_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(257, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "插值序列";
            // 
            // rtbx_xulie
            // 
            this.rtbx_xulie.Location = new System.Drawing.Point(208, 100);
            this.rtbx_xulie.Name = "rtbx_xulie";
            this.rtbx_xulie.Size = new System.Drawing.Size(173, 448);
            this.rtbx_xulie.TabIndex = 13;
            this.rtbx_xulie.Text = "";
            // 
            // btn_CreateXuLie
            // 
            this.btn_CreateXuLie.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CreateXuLie.Location = new System.Drawing.Point(405, 202);
            this.btn_CreateXuLie.Name = "btn_CreateXuLie";
            this.btn_CreateXuLie.Size = new System.Drawing.Size(100, 34);
            this.btn_CreateXuLie.TabIndex = 16;
            this.btn_CreateXuLie.Text = "生成序列";
            this.btn_CreateXuLie.UseVisualStyleBackColor = true;
            this.btn_CreateXuLie.Click += new System.EventHandler(this.btn_CreateXuLie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 620);
            this.Controls.Add(this.btn_CreateXuLie);
            this.Controls.Add(this.btn_ClearXuLie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbx_xulie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_StartIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_InterpolateJianju);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_rtbx_InterpolatedData);
            this.Controls.Add(this.btn_rtbx_ClearInitialData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbx_InterolatedData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_IsContainInitialData);
            this.Controls.Add(this.rtbx_InitialData);
            this.Controls.Add(this.btn_StartInterpolate);
            this.Name = "Form1";
            this.Text = "插值小程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartInterpolate;
        private System.Windows.Forms.RichTextBox rtbx_InitialData;
        private System.Windows.Forms.CheckBox cbx_IsContainInitialData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbx_InterolatedData;
        private System.Windows.Forms.Button btn_rtbx_ClearInitialData;
        private System.Windows.Forms.Button btn_rtbx_InterpolatedData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_InterpolateJianju;
        private System.Windows.Forms.TextBox tbx_StartIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ClearXuLie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbx_xulie;
        private System.Windows.Forms.Button btn_CreateXuLie;
    }
}

