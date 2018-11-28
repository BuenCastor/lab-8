namespace lab_8
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tbDiskInfo = new System.Windows.Forms.TextBox();
            this.btnAddDisk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDiskInfo
            // 
            this.tbDiskInfo.Location = new System.Drawing.Point(14, 15);
            this.tbDiskInfo.Multiline = true;
            this.tbDiskInfo.Name = "tbDiskInfo";
            this.tbDiskInfo.ReadOnly = true;
            this.tbDiskInfo.Size = new System.Drawing.Size(499, 276);
            this.tbDiskInfo.TabIndex = 0;
            // 
            // btnAddDisk
            // 
            this.btnAddDisk.Location = new System.Drawing.Point(565, 34);
            this.btnAddDisk.Name = "btnAddDisk";
            this.btnAddDisk.Size = new System.Drawing.Size(104, 23);
            this.btnAddDisk.TabIndex = 1;
            this.btnAddDisk.Text = "Додати диск";
            this.btnAddDisk.UseVisualStyleBackColor = true;
            this.btnAddDisk.Click += new System.EventHandler(this.btnAddTown_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(565, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 316);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddDisk);
            this.Controls.Add(this.tbDiskInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lab8";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDiskInfo;
        private System.Windows.Forms.Button btnAddDisk;
        private System.Windows.Forms.Button btnClose;
    }
}

