namespace lab_8
{
    partial class fDisk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDisk));
            this.tbDiskInfo = new System.Windows.Forms.GroupBox();
            this.tbSata = new System.Windows.Forms.TextBox();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbTyp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbInternet = new System.Windows.Forms.CheckBox();
            this.chbGaranty = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbDiskInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDiskInfo
            // 
            this.tbDiskInfo.Controls.Add(this.tbSata);
            this.tbDiskInfo.Controls.Add(this.tbVolume);
            this.tbDiskInfo.Controls.Add(this.tbCapacity);
            this.tbDiskInfo.Controls.Add(this.tbSpeed);
            this.tbDiskInfo.Controls.Add(this.tbCountry);
            this.tbDiskInfo.Controls.Add(this.tbTyp);
            this.tbDiskInfo.Controls.Add(this.label6);
            this.tbDiskInfo.Controls.Add(this.label5);
            this.tbDiskInfo.Controls.Add(this.label4);
            this.tbDiskInfo.Controls.Add(this.label3);
            this.tbDiskInfo.Controls.Add(this.label2);
            this.tbDiskInfo.Controls.Add(this.label1);
            this.tbDiskInfo.Location = new System.Drawing.Point(21, 12);
            this.tbDiskInfo.Name = "tbDiskInfo";
            this.tbDiskInfo.Size = new System.Drawing.Size(300, 257);
            this.tbDiskInfo.TabIndex = 0;
            this.tbDiskInfo.TabStop = false;
            this.tbDiskInfo.Text = "Загальні данні";
            // 
            // tbSata
            // 
            this.tbSata.Location = new System.Drawing.Point(164, 212);
            this.tbSata.Name = "tbSata";
            this.tbSata.Size = new System.Drawing.Size(106, 20);
            this.tbSata.TabIndex = 11;
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(164, 174);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(106, 20);
            this.tbVolume.TabIndex = 10;
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(164, 141);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(106, 20);
            this.tbCapacity.TabIndex = 9;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(164, 110);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(106, 20);
            this.tbSpeed.TabIndex = 8;
            this.tbSpeed.TextChanged += new System.EventHandler(this.tbSpeed_TextChanged);
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(164, 79);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(106, 20);
            this.tbCountry.TabIndex = 7;
            // 
            // tbTyp
            // 
            this.tbTyp.Location = new System.Drawing.Point(164, 49);
            this.tbTyp.Name = "tbTyp";
            this.tbTyp.Size = new System.Drawing.Size(106, 20);
            this.tbTyp.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Інтерфейс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Об\'єм буферу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ємність ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Швидкість передачі данних";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Країна виробник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип диску";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbInternet);
            this.groupBox2.Controls.Add(this.chbGaranty);
            this.groupBox2.Location = new System.Drawing.Point(21, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Покупка";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chbInternet
            // 
            this.chbInternet.AutoSize = true;
            this.chbInternet.Location = new System.Drawing.Point(29, 62);
            this.chbInternet.Name = "chbInternet";
            this.chbInternet.Size = new System.Drawing.Size(170, 17);
            this.chbInternet.TabIndex = 1;
            this.chbInternet.Text = "Чи можна купити в інтернеті";
            this.chbInternet.UseVisualStyleBackColor = true;
            // 
            // chbGaranty
            // 
            this.chbGaranty.AutoSize = true;
            this.chbGaranty.Location = new System.Drawing.Point(29, 29);
            this.chbGaranty.Name = "chbGaranty";
            this.chbGaranty.Size = new System.Drawing.Size(94, 17);
            this.chbGaranty.TabIndex = 0;
            this.chbGaranty.Text = "Чи є гарантія";
            this.chbGaranty.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(382, 34);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 40);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(382, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 44);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fDisk
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(522, 388);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbDiskInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fDisk";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данні про новий диск";
            this.Load += new System.EventHandler(this.fTown_Load);
            this.tbDiskInfo.ResumeLayout(false);
            this.tbDiskInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tbDiskInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSata;
        private System.Windows.Forms.TextBox tbVolume;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbTyp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbInternet;
        private System.Windows.Forms.CheckBox chbGaranty;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}