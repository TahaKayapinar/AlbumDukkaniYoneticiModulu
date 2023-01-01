namespace EF_Core_Maraton_Taha_Kayapinar_HS6
{
    partial class FormAlbum
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
            this.btnDeleteAlbum = new System.Windows.Forms.Button();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.btnNewAlbum = new System.Windows.Forms.Button();
            this.txtSinger = new System.Windows.Forms.TextBox();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtAlbumBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.radioYES = new System.Windows.Forms.RadioButton();
            this.radioNO = new System.Windows.Forms.RadioButton();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numDiscountRate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscountRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteAlbum
            // 
            this.btnDeleteAlbum.Location = new System.Drawing.Point(381, 165);
            this.btnDeleteAlbum.Name = "btnDeleteAlbum";
            this.btnDeleteAlbum.Size = new System.Drawing.Size(172, 68);
            this.btnDeleteAlbum.TabIndex = 21;
            this.btnDeleteAlbum.Text = " S İ L ";
            this.btnDeleteAlbum.UseVisualStyleBackColor = true;
            this.btnDeleteAlbum.Click += new System.EventHandler(this.btnDeleteAlbum_Click);
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Location = new System.Drawing.Point(381, 90);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(172, 69);
            this.btnSaveAlbum.TabIndex = 20;
            this.btnSaveAlbum.Text = "K A Y D E T";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSaveAlbum_Click);
            // 
            // btnNewAlbum
            // 
            this.btnNewAlbum.Location = new System.Drawing.Point(381, 12);
            this.btnNewAlbum.Name = "btnNewAlbum";
            this.btnNewAlbum.Size = new System.Drawing.Size(172, 72);
            this.btnNewAlbum.TabIndex = 19;
            this.btnNewAlbum.Text = "Y E N İ";
            this.btnNewAlbum.UseVisualStyleBackColor = true;
            this.btnNewAlbum.Click += new System.EventHandler(this.btnNewAlbum_Click);
            // 
            // txtSinger
            // 
            this.txtSinger.Location = new System.Drawing.Point(144, 62);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.Size = new System.Drawing.Size(200, 23);
            this.txtSinger.TabIndex = 17;
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(143, 25);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(201, 23);
            this.txtAlbumName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "İndirim Oranı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fiyatı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sanatçı / Şarkıcı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Albüm Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Albüm Çıkış Tarihi :";
            // 
            // dtAlbumBirthDate
            // 
            this.dtAlbumBirthDate.Location = new System.Drawing.Point(144, 102);
            this.dtAlbumBirthDate.Name = "dtAlbumBirthDate";
            this.dtAlbumBirthDate.Size = new System.Drawing.Size(200, 23);
            this.dtAlbumBirthDate.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Satış Devam Ediyor MU ? :";
            // 
            // radioYES
            // 
            this.radioYES.AutoSize = true;
            this.radioYES.Location = new System.Drawing.Point(149, 204);
            this.radioYES.Name = "radioYES";
            this.radioYES.Size = new System.Drawing.Size(47, 19);
            this.radioYES.TabIndex = 23;
            this.radioYES.TabStop = true;
            this.radioYES.Text = "Evet";
            this.radioYES.UseVisualStyleBackColor = true;
            // 
            // radioNO
            // 
            this.radioNO.AutoSize = true;
            this.radioNO.Location = new System.Drawing.Point(202, 204);
            this.radioNO.Name = "radioNO";
            this.radioNO.Size = new System.Drawing.Size(53, 19);
            this.radioNO.TabIndex = 23;
            this.radioNO.TabStop = true;
            this.radioNO.Text = "Hayır";
            this.radioNO.UseVisualStyleBackColor = true;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(144, 137);
            this.numPrice.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(200, 23);
            this.numPrice.TabIndex = 24;
            // 
            // numDiscountRate
            // 
            this.numDiscountRate.Location = new System.Drawing.Point(144, 166);
            this.numDiscountRate.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numDiscountRate.Name = "numDiscountRate";
            this.numDiscountRate.Size = new System.Drawing.Size(200, 23);
            this.numDiscountRate.TabIndex = 24;
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 246);
            this.Controls.Add(this.numDiscountRate);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.radioNO);
            this.Controls.Add(this.radioYES);
            this.Controls.Add(this.dtAlbumBirthDate);
            this.Controls.Add(this.btnDeleteAlbum);
            this.Controls.Add(this.btnSaveAlbum);
            this.Controls.Add(this.btnNewAlbum);
            this.Controls.Add(this.txtSinger);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAlbum";
            this.Text = "FormAlbum";
            this.Load += new System.EventHandler(this.FormAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscountRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDeleteAlbum;
        private Button btnSaveAlbum;
        private Button btnNewAlbum;
        private TextBox txtSinger;
        private TextBox txtAlbumName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DateTimePicker dtAlbumBirthDate;
        private Label label2;
        private RadioButton radioYES;
        private RadioButton radioNO;
        private NumericUpDown numPrice;
        private NumericUpDown numDiscountRate;
    }
}