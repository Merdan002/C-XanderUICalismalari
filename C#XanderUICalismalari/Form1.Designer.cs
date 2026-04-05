namespace C_XanderUICalismalari
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xuıFormDesign1 = new XanderUI.XUIFormDesign();
            this.materialTxtEposta = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtTel = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtSoyad = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTxtAd = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuıButton3 = new XanderUI.XUIButton();
            this.xuıButton2 = new XanderUI.XUIButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xuıSuperButton1 = new XanderUI.XUISuperButton();
            this.xuıButton1 = new XanderUI.XUIButton();
            this.xuıFlatMenuStrip1 = new XanderUI.XUIFlatMenuStrip();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xuıCard1 = new XanderUI.XUICard();
            this.xuıClock1 = new XanderUI.XUIClock();
            this.xuıFormDesign1.WorkingArea.SuspendLayout();
            this.xuıFormDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xuıFormDesign1
            // 
            this.xuıFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuıFormDesign1.ExitApplication = true;
            this.xuıFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.Ubuntu;
            this.xuıFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuıFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuıFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuıFormDesign1.Name = "xuıFormDesign1";
            this.xuıFormDesign1.ShowMaximize = true;
            this.xuıFormDesign1.ShowMinimize = true;
            this.xuıFormDesign1.Size = new System.Drawing.Size(869, 634);
            this.xuıFormDesign1.TabIndex = 0;
            this.xuıFormDesign1.TitleText = "C# Xender UI Çalışmaları";
            // 
            // xuıFormDesign1.WorkingArea
            // 
            this.xuıFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.xuıClock1);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.xuıCard1);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.label5);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.materialTextBox1);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.materialTxtEposta);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.materialTxtTel);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.materialTxtSoyad);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.materialTxtAd);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.label4);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.label3);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.label2);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.label1);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.xuıButton3);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.xuıButton2);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.dataGridView1);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.xuıSuperButton1);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.xuıButton1);
            this.xuıFormDesign1.WorkingArea.Controls.Add(this.xuıFlatMenuStrip1);
            this.xuıFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuıFormDesign1.WorkingArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xuıFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 30);
            this.xuıFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuıFormDesign1.WorkingArea.Size = new System.Drawing.Size(869, 604);
            this.xuıFormDesign1.WorkingArea.TabIndex = 0;
            this.xuıFormDesign1.WorkingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.xuıFormDesign1_WorkingArea_Paint);
            // 
            // materialTxtEposta
            // 
            this.materialTxtEposta.AnimateReadOnly = false;
            this.materialTxtEposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtEposta.Depth = 0;
            this.materialTxtEposta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtEposta.LeadingIcon = null;
            this.materialTxtEposta.Location = new System.Drawing.Point(153, 365);
            this.materialTxtEposta.MaxLength = 50;
            this.materialTxtEposta.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtEposta.Multiline = false;
            this.materialTxtEposta.Name = "materialTxtEposta";
            this.materialTxtEposta.Size = new System.Drawing.Size(174, 50);
            this.materialTxtEposta.TabIndex = 14;
            this.materialTxtEposta.Text = "";
            this.materialTxtEposta.TrailingIcon = null;
            // 
            // materialTxtTel
            // 
            this.materialTxtTel.AnimateReadOnly = false;
            this.materialTxtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtTel.Depth = 0;
            this.materialTxtTel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtTel.LeadingIcon = null;
            this.materialTxtTel.Location = new System.Drawing.Point(153, 287);
            this.materialTxtTel.MaxLength = 50;
            this.materialTxtTel.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtTel.Multiline = false;
            this.materialTxtTel.Name = "materialTxtTel";
            this.materialTxtTel.Size = new System.Drawing.Size(174, 50);
            this.materialTxtTel.TabIndex = 13;
            this.materialTxtTel.Text = "";
            this.materialTxtTel.TrailingIcon = null;
            // 
            // materialTxtSoyad
            // 
            this.materialTxtSoyad.AnimateReadOnly = false;
            this.materialTxtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtSoyad.Depth = 0;
            this.materialTxtSoyad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtSoyad.LeadingIcon = null;
            this.materialTxtSoyad.Location = new System.Drawing.Point(153, 208);
            this.materialTxtSoyad.MaxLength = 50;
            this.materialTxtSoyad.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtSoyad.Multiline = false;
            this.materialTxtSoyad.Name = "materialTxtSoyad";
            this.materialTxtSoyad.Size = new System.Drawing.Size(174, 50);
            this.materialTxtSoyad.TabIndex = 12;
            this.materialTxtSoyad.Text = "";
            this.materialTxtSoyad.TrailingIcon = null;
            // 
            // materialTxtAd
            // 
            this.materialTxtAd.AnimateReadOnly = false;
            this.materialTxtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTxtAd.Depth = 0;
            this.materialTxtAd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTxtAd.LeadingIcon = null;
            this.materialTxtAd.Location = new System.Drawing.Point(153, 132);
            this.materialTxtAd.MaxLength = 50;
            this.materialTxtAd.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTxtAd.Multiline = false;
            this.materialTxtAd.Name = "materialTxtAd";
            this.materialTxtAd.Size = new System.Drawing.Size(174, 50);
            this.materialTxtAd.TabIndex = 11;
            this.materialTxtAd.Text = "";
            this.materialTxtAd.TrailingIcon = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Eposta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad";
            // 
            // xuıButton3
            // 
            this.xuıButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuıButton3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuıButton3.ButtonImage")));
            this.xuıButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuıButton3.ButtonText = "Güncelle";
            this.xuıButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuıButton3.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuıButton3.CornerRadius = 5;
            this.xuıButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xuıButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton3.HoverBackgroundColor = System.Drawing.Color.Blue;
            this.xuıButton3.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuıButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuıButton3.Location = new System.Drawing.Point(371, 354);
            this.xuıButton3.Name = "xuıButton3";
            this.xuıButton3.Size = new System.Drawing.Size(172, 50);
            this.xuıButton3.TabIndex = 6;
            this.xuıButton3.TextColor = System.Drawing.Color.Blue;
            this.xuıButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton3.Click += new System.EventHandler(this.xuıButton3_Click);
            // 
            // xuıButton2
            // 
            this.xuıButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuıButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuıButton2.ButtonImage")));
            this.xuıButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuıButton2.ButtonText = "Sil";
            this.xuıButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuıButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuıButton2.CornerRadius = 5;
            this.xuıButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xuıButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton2.HoverBackgroundColor = System.Drawing.Color.Blue;
            this.xuıButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuıButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuıButton2.Location = new System.Drawing.Point(371, 260);
            this.xuıButton2.Name = "xuıButton2";
            this.xuıButton2.Size = new System.Drawing.Size(172, 50);
            this.xuıButton2.TabIndex = 5;
            this.xuıButton2.TextColor = System.Drawing.Color.Blue;
            this.xuıButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton2.Click += new System.EventHandler(this.xuıButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 431);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(845, 170);
            this.dataGridView1.TabIndex = 4;
            // 
            // xuıSuperButton1
            // 
            this.xuıSuperButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.xuıSuperButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuıSuperButton1.ButtonImage")));
            this.xuıSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuıSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuıSuperButton1.ButtonText = " Görüntüle";
            this.xuıSuperButton1.CornerRadius = 5;
            this.xuıSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıSuperButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuıSuperButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuıSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuıSuperButton1.Location = new System.Drawing.Point(371, 162);
            this.xuıSuperButton1.Name = "xuıSuperButton1";
            this.xuıSuperButton1.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuıSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuıSuperButton1.Size = new System.Drawing.Size(172, 48);
            this.xuıSuperButton1.SuperSelected = false;
            this.xuıSuperButton1.TabIndex = 2;
            this.xuıSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuıSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıSuperButton1.Click += new System.EventHandler(this.xuıSuperButton1_Click);
            // 
            // xuıButton1
            // 
            this.xuıButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuıButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuıButton1.ButtonImage")));
            this.xuıButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuıButton1.ButtonText = "Ekle";
            this.xuıButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuıButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuıButton1.CornerRadius = 5;
            this.xuıButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xuıButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton1.HoverBackgroundColor = System.Drawing.Color.Blue;
            this.xuıButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuıButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuıButton1.Location = new System.Drawing.Point(371, 63);
            this.xuıButton1.Name = "xuıButton1";
            this.xuıButton1.Size = new System.Drawing.Size(172, 50);
            this.xuıButton1.TabIndex = 2;
            this.xuıButton1.TextColor = System.Drawing.Color.Blue;
            this.xuıButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton1.Click += new System.EventHandler(this.xuıButton1_Click);
            // 
            // xuıFlatMenuStrip1
            // 
            this.xuıFlatMenuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.xuıFlatMenuStrip1.HoverBackColor = System.Drawing.Color.RoyalBlue;
            this.xuıFlatMenuStrip1.HoverTextColor = System.Drawing.Color.White;
            this.xuıFlatMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.xuıFlatMenuStrip1.ItemBackColor = System.Drawing.Color.DodgerBlue;
            this.xuıFlatMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.xuıFlatMenuStrip1.Name = "xuıFlatMenuStrip1";
            this.xuıFlatMenuStrip1.SelectedBackColor = System.Drawing.Color.DarkOrchid;
            this.xuıFlatMenuStrip1.SelectedTextColor = System.Drawing.Color.White;
            this.xuıFlatMenuStrip1.SeperatorColor = System.Drawing.Color.White;
            this.xuıFlatMenuStrip1.Size = new System.Drawing.Size(869, 24);
            this.xuıFlatMenuStrip1.TabIndex = 3;
            this.xuıFlatMenuStrip1.Text = "xuıFlatMenuStrip1";
            this.xuıFlatMenuStrip1.TextColor = System.Drawing.Color.White;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(153, 63);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(174, 50);
            this.materialTextBox1.TabIndex = 15;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Id";
            // 
            // xuıCard1
            // 
            this.xuıCard1.BackColor = System.Drawing.Color.Transparent;
            this.xuıCard1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuıCard1.Color2 = System.Drawing.Color.LimeGreen;
            this.xuıCard1.ForeColor = System.Drawing.Color.White;
            this.xuıCard1.Location = new System.Drawing.Point(596, 27);
            this.xuıCard1.Name = "xuıCard1";
            this.xuıCard1.Size = new System.Drawing.Size(273, 141);
            this.xuıCard1.TabIndex = 17;
            this.xuıCard1.Text = "xuıCard1";
            this.xuıCard1.Text1 = "Tarsus Ünüversitesi";
            this.xuıCard1.Text2 = " No:24110103";
            this.xuıCard1.Text3 = "Bölüm: Bilgisaya P.";
            // 
            // xuıClock1
            // 
            this.xuıClock1.CircleThickness = 6;
            this.xuıClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuıClock1.FilledHourColor = System.Drawing.Color.Blue;
            this.xuıClock1.FilledMinuteColor = System.Drawing.Color.Fuchsia;
            this.xuıClock1.FilledSecondColor = System.Drawing.Color.Red;
            this.xuıClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuıClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuıClock1.Location = new System.Drawing.Point(726, 295);
            this.xuıClock1.Name = "xuıClock1";
            this.xuıClock1.ShowAmPm = false;
            this.xuıClock1.ShowHexagon = true;
            this.xuıClock1.ShowMinutesCircle = true;
            this.xuıClock1.ShowSecondsCircle = true;
            this.xuıClock1.Size = new System.Drawing.Size(131, 130);
            this.xuıClock1.TabIndex = 2;
            this.xuıClock1.Text = "xuıClock1";
            this.xuıClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuıClock1.UnfilledMinuteColor = System.Drawing.Color.Fuchsia;
            this.xuıClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 634);
            this.Controls.Add(this.xuıFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.xuıFlatMenuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.xuıFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuıFormDesign1.WorkingArea.PerformLayout();
            this.xuıFormDesign1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuıFormDesign1;
        private XanderUI.XUIButton xuıButton1;
        private XanderUI.XUIFlatMenuStrip xuıFlatMenuStrip1;
        private XanderUI.XUISuperButton xuıSuperButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuıButton3;
        private XanderUI.XUIButton xuıButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox materialTxtTel;
        private MaterialSkin.Controls.MaterialTextBox materialTxtSoyad;
        private MaterialSkin.Controls.MaterialTextBox materialTxtAd;
        private MaterialSkin.Controls.MaterialTextBox materialTxtEposta;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.Label label5;
        private XanderUI.XUICard xuıCard1;
        private XanderUI.XUIClock xuıClock1;
    }
}

