namespace kütüphane
{
    partial class kutuphane
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textuyeadi = new TextBox();
            textBoxuyesoyadi = new TextBox();
            textBoxkitapadi = new TextBox();
            textBoxkitapyazari = new TextBox();
            textBoxaranacakkitap = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBoxalmatarihi = new TextBox();
            label6 = new Label();
            textBoxiadetarih = new TextBox();
            label7 = new Label();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 372);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1124, 331);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(102, 44);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 1;
            label1.Text = "Üye Adı=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(74, 101);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 2;
            label2.Text = "Üye Soyadı=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(90, 158);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 3;
            label3.Text = "Kitap Adı=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(69, 215);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 4;
            label4.Text = "Kitap Yazarı=";
            // 
            // textuyeadi
            // 
            textuyeadi.Location = new Point(200, 44);
            textuyeadi.Name = "textuyeadi";
            textuyeadi.Size = new Size(125, 27);
            textuyeadi.TabIndex = 5;
            // 
            // textBoxuyesoyadi
            // 
            textBoxuyesoyadi.Location = new Point(200, 104);
            textBoxuyesoyadi.Name = "textBoxuyesoyadi";
            textBoxuyesoyadi.Size = new Size(125, 27);
            textBoxuyesoyadi.TabIndex = 6;
            // 
            // textBoxkitapadi
            // 
            textBoxkitapadi.Location = new Point(200, 159);
            textBoxkitapadi.Name = "textBoxkitapadi";
            textBoxkitapadi.Size = new Size(125, 27);
            textBoxkitapadi.TabIndex = 7;
            // 
            // textBoxkitapyazari
            // 
            textBoxkitapyazari.Location = new Point(200, 217);
            textBoxkitapyazari.Name = "textBoxkitapyazari";
            textBoxkitapyazari.Size = new Size(125, 27);
            textBoxkitapyazari.TabIndex = 8;
            // 
            // textBoxaranacakkitap
            // 
            textBoxaranacakkitap.Location = new Point(632, 60);
            textBoxaranacakkitap.Name = "textBoxaranacakkitap";
            textBoxaranacakkitap.Size = new Size(125, 27);
            textBoxaranacakkitap.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(471, 59);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 9;
            label5.Text = "Aranacak Kitap=";
            // 
            // button1
            // 
            button1.Location = new Point(993, 41);
            button1.Name = "button1";
            button1.Size = new Size(97, 58);
            button1.TabIndex = 11;
            button1.Text = "Yeni Üye Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(777, 44);
            button2.Name = "button2";
            button2.Size = new Size(97, 58);
            button2.TabIndex = 12;
            button2.Text = "Ara";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(993, 143);
            button3.Name = "button3";
            button3.Size = new Size(97, 58);
            button3.TabIndex = 13;
            button3.Text = "Kitap Ödünç Al";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(993, 239);
            button4.Name = "button4";
            button4.Size = new Size(97, 58);
            button4.TabIndex = 14;
            button4.Text = "kitap iade";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxalmatarihi
            // 
            textBoxalmatarihi.Location = new Point(200, 272);
            textBoxalmatarihi.Name = "textBoxalmatarihi";
            textBoxalmatarihi.Size = new Size(125, 27);
            textBoxalmatarihi.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(69, 272);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 15;
            label6.Text = "Alma Tarihi=";
            // 
            // textBoxiadetarih
            // 
            textBoxiadetarih.Location = new Point(200, 319);
            textBoxiadetarih.Name = "textBoxiadetarih";
            textBoxiadetarih.Size = new Size(125, 27);
            textBoxiadetarih.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(69, 319);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 17;
            label7.Text = "İade Tarihi=";
            // 
            // button5
            // 
            button5.Location = new Point(616, 101);
            button5.Name = "button5";
            button5.Size = new Size(106, 73);
            button5.TabIndex = 19;
            button5.Text = "Tüm Kayıtları Görüntüle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(616, 180);
            button6.Name = "button6";
            button6.Size = new Size(106, 73);
            button6.TabIndex = 20;
            button6.Text = "Üyeleri Görüntüle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // kutuphane
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 715);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBoxiadetarih);
            Controls.Add(label7);
            Controls.Add(textBoxalmatarihi);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxaranacakkitap);
            Controls.Add(label5);
            Controls.Add(textBoxkitapyazari);
            Controls.Add(textBoxkitapadi);
            Controls.Add(textBoxuyesoyadi);
            Controls.Add(textuyeadi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "kutuphane";
            Text = "kutuphane";
            Load += kutuphane_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textuyeadi;
        private TextBox textBoxuyesoyadi;
        private TextBox textBoxkitapadi;
        private TextBox textBoxkitapyazari;
        private TextBox textBoxaranacakkitap;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBoxalmatarihi;
        private Label label6;
        private TextBox textBoxiadetarih;
        private Label label7;
        private Button button5;
        private Button button6;
    }
}