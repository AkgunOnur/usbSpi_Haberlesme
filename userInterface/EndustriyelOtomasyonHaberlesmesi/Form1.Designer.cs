namespace EndustriyelOtomasyonHaberlesmesi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.grup_istemci = new System.Windows.Forms.GroupBox();
            this.denetim_istemci2 = new System.Windows.Forms.RadioButton();
            this.denetim_istemci1 = new System.Windows.Forms.RadioButton();
            this.grup_secim1 = new System.Windows.Forms.GroupBox();
            this.denetim_lcd1 = new System.Windows.Forms.RadioButton();
            this.denetim_lamba1 = new System.Windows.Forms.RadioButton();
            this.grup_secim2 = new System.Windows.Forms.GroupBox();
            this.denetim_lamba2 = new System.Windows.Forms.RadioButton();
            this.denetim_lcd2 = new System.Windows.Forms.RadioButton();
            this.dugme1_1 = new System.Windows.Forms.Button();
            this.dugme1_2 = new System.Windows.Forms.Button();
            this.dugme1_3 = new System.Windows.Forms.Button();
            this.dugme1_4 = new System.Windows.Forms.Button();
            this.dugme1_5 = new System.Windows.Forms.Button();
            this.dugme1_6 = new System.Windows.Forms.Button();
            this.dugme1_7 = new System.Windows.Forms.Button();
            this.dugme1_8 = new System.Windows.Forms.Button();
            this.dugme2_1 = new System.Windows.Forms.Button();
            this.dugme2_2 = new System.Windows.Forms.Button();
            this.dugme2_3 = new System.Windows.Forms.Button();
            this.dugme2_4 = new System.Windows.Forms.Button();
            this.dugme2_5 = new System.Windows.Forms.Button();
            this.dugme2_6 = new System.Windows.Forms.Button();
            this.dugme2_7 = new System.Windows.Forms.Button();
            this.dugme2_8 = new System.Windows.Forms.Button();
            this.etiket2_yazi = new System.Windows.Forms.Label();
            this.etiket1_yazi = new System.Windows.Forms.Label();
            this.metin1_yazi = new System.Windows.Forms.TextBox();
            this.metin2_yazi = new System.Windows.Forms.TextBox();
            this.dugme1_gonder = new System.Windows.Forms.Button();
            this.dugme2_gonder = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.durum_yazisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.grup_buton1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grup_metin2 = new System.Windows.Forms.GroupBox();
            this.grup_metin1 = new System.Windows.Forms.GroupBox();
            this.grup_buton2 = new System.Windows.Forms.GroupBox();
            this.usbHidPort1 = new UsbLibrary.UsbHidPort(this.components);
            this.grup_sicaklik1 = new System.Windows.Forms.GroupBox();
            this.etiket_sicaklik1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grup_sicaklik2 = new System.Windows.Forms.GroupBox();
            this.etiket_sicaklik2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grup_istemci.SuspendLayout();
            this.grup_secim1.SuspendLayout();
            this.grup_secim2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grup_buton1.SuspendLayout();
            this.grup_metin2.SuspendLayout();
            this.grup_metin1.SuspendLayout();
            this.grup_buton2.SuspendLayout();
            this.grup_sicaklik1.SuspendLayout();
            this.grup_sicaklik2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(285, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fabrika Haberleşme Uygulaması";
            // 
            // grup_istemci
            // 
            this.grup_istemci.Controls.Add(this.denetim_istemci2);
            this.grup_istemci.Controls.Add(this.denetim_istemci1);
            this.grup_istemci.Enabled = false;
            this.grup_istemci.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grup_istemci.Location = new System.Drawing.Point(287, 107);
            this.grup_istemci.Name = "grup_istemci";
            this.grup_istemci.Size = new System.Drawing.Size(198, 46);
            this.grup_istemci.TabIndex = 1;
            this.grup_istemci.TabStop = false;
            // 
            // denetim_istemci2
            // 
            this.denetim_istemci2.AutoSize = true;
            this.denetim_istemci2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.denetim_istemci2.Location = new System.Drawing.Point(112, 16);
            this.denetim_istemci2.Name = "denetim_istemci2";
            this.denetim_istemci2.Size = new System.Drawing.Size(80, 21);
            this.denetim_istemci2.TabIndex = 2;
            this.denetim_istemci2.TabStop = true;
            this.denetim_istemci2.Text = "2.İstemci";
            this.denetim_istemci2.UseVisualStyleBackColor = true;
            this.denetim_istemci2.CheckedChanged += new System.EventHandler(this.denetim_istemci2_CheckedChanged);
            // 
            // denetim_istemci1
            // 
            this.denetim_istemci1.AutoSize = true;
            this.denetim_istemci1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.denetim_istemci1.Location = new System.Drawing.Point(16, 16);
            this.denetim_istemci1.Name = "denetim_istemci1";
            this.denetim_istemci1.Size = new System.Drawing.Size(80, 21);
            this.denetim_istemci1.TabIndex = 1;
            this.denetim_istemci1.TabStop = true;
            this.denetim_istemci1.Text = "1.İstemci";
            this.denetim_istemci1.UseVisualStyleBackColor = true;
            this.denetim_istemci1.CheckedChanged += new System.EventHandler(this.denetim_istemci1_CheckedChanged);
            // 
            // grup_secim1
            // 
            this.grup_secim1.Controls.Add(this.denetim_lcd1);
            this.grup_secim1.Controls.Add(this.denetim_lamba1);
            this.grup_secim1.Enabled = false;
            this.grup_secim1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grup_secim1.Location = new System.Drawing.Point(43, 178);
            this.grup_secim1.Name = "grup_secim1";
            this.grup_secim1.Size = new System.Drawing.Size(158, 44);
            this.grup_secim1.TabIndex = 1;
            this.grup_secim1.TabStop = false;
            // 
            // denetim_lcd1
            // 
            this.denetim_lcd1.AutoSize = true;
            this.denetim_lcd1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.denetim_lcd1.Location = new System.Drawing.Point(89, 16);
            this.denetim_lcd1.Name = "denetim_lcd1";
            this.denetim_lcd1.Size = new System.Drawing.Size(56, 21);
            this.denetim_lcd1.TabIndex = 3;
            this.denetim_lcd1.TabStop = true;
            this.denetim_lcd1.Text = "LCD";
            this.denetim_lcd1.UseVisualStyleBackColor = true;
            this.denetim_lcd1.CheckedChanged += new System.EventHandler(this.denetim_lcd1_CheckedChanged);
            // 
            // denetim_lamba1
            // 
            this.denetim_lamba1.AutoSize = true;
            this.denetim_lamba1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.denetim_lamba1.Location = new System.Drawing.Point(16, 16);
            this.denetim_lamba1.Name = "denetim_lamba1";
            this.denetim_lamba1.Size = new System.Drawing.Size(67, 21);
            this.denetim_lamba1.TabIndex = 2;
            this.denetim_lamba1.TabStop = true;
            this.denetim_lamba1.Text = "Lamba";
            this.denetim_lamba1.UseVisualStyleBackColor = true;
            this.denetim_lamba1.CheckedChanged += new System.EventHandler(this.denetim_lamba1_CheckedChanged);
            // 
            // grup_secim2
            // 
            this.grup_secim2.Controls.Add(this.denetim_lamba2);
            this.grup_secim2.Controls.Add(this.denetim_lcd2);
            this.grup_secim2.Enabled = false;
            this.grup_secim2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grup_secim2.Location = new System.Drawing.Point(582, 178);
            this.grup_secim2.Name = "grup_secim2";
            this.grup_secim2.Size = new System.Drawing.Size(158, 44);
            this.grup_secim2.TabIndex = 1;
            this.grup_secim2.TabStop = false;
            // 
            // denetim_lamba2
            // 
            this.denetim_lamba2.AutoSize = true;
            this.denetim_lamba2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.denetim_lamba2.Location = new System.Drawing.Point(20, 16);
            this.denetim_lamba2.Name = "denetim_lamba2";
            this.denetim_lamba2.Size = new System.Drawing.Size(67, 21);
            this.denetim_lamba2.TabIndex = 17;
            this.denetim_lamba2.Text = "Lamba";
            this.denetim_lamba2.UseVisualStyleBackColor = true;
            this.denetim_lamba2.CheckedChanged += new System.EventHandler(this.denetim_lamba2_CheckedChanged);
            // 
            // denetim_lcd2
            // 
            this.denetim_lcd2.AutoSize = true;
            this.denetim_lcd2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.denetim_lcd2.Location = new System.Drawing.Point(89, 16);
            this.denetim_lcd2.Name = "denetim_lcd2";
            this.denetim_lcd2.Size = new System.Drawing.Size(56, 21);
            this.denetim_lcd2.TabIndex = 17;
            this.denetim_lcd2.Text = "LCD";
            this.denetim_lcd2.UseVisualStyleBackColor = true;
            this.denetim_lcd2.CheckedChanged += new System.EventHandler(this.denetim_lcd2_CheckedChanged);
            // 
            // dugme1_1
            // 
            this.dugme1_1.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme1_1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme1_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme1_1.Location = new System.Drawing.Point(9, 18);
            this.dugme1_1.Name = "dugme1_1";
            this.dugme1_1.Size = new System.Drawing.Size(35, 35);
            this.dugme1_1.TabIndex = 6;
            this.dugme1_1.Text = "1";
            this.dugme1_1.UseVisualStyleBackColor = false;
            this.dugme1_1.Click += new System.EventHandler(this.dugme1_1_Click);
            // 
            // dugme1_2
            // 
            this.dugme1_2.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme1_2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme1_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme1_2.Location = new System.Drawing.Point(50, 18);
            this.dugme1_2.Name = "dugme1_2";
            this.dugme1_2.Size = new System.Drawing.Size(35, 35);
            this.dugme1_2.TabIndex = 7;
            this.dugme1_2.Text = "2";
            this.dugme1_2.UseVisualStyleBackColor = false;
            this.dugme1_2.Click += new System.EventHandler(this.dugme1_2_Click);
            // 
            // dugme1_3
            // 
            this.dugme1_3.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme1_3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme1_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme1_3.Location = new System.Drawing.Point(91, 18);
            this.dugme1_3.Name = "dugme1_3";
            this.dugme1_3.Size = new System.Drawing.Size(35, 35);
            this.dugme1_3.TabIndex = 8;
            this.dugme1_3.Text = "3";
            this.dugme1_3.UseVisualStyleBackColor = false;
            this.dugme1_3.Click += new System.EventHandler(this.dugme1_3_Click);
            // 
            // dugme1_4
            // 
            this.dugme1_4.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme1_4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme1_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme1_4.Location = new System.Drawing.Point(132, 18);
            this.dugme1_4.Name = "dugme1_4";
            this.dugme1_4.Size = new System.Drawing.Size(35, 35);
            this.dugme1_4.TabIndex = 9;
            this.dugme1_4.Text = "4";
            this.dugme1_4.UseVisualStyleBackColor = false;
            this.dugme1_4.Click += new System.EventHandler(this.dugme1_4_Click);
            // 
            // dugme1_5
            // 
            this.dugme1_5.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme1_5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme1_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme1_5.Location = new System.Drawing.Point(9, 59);
            this.dugme1_5.Name = "dugme1_5";
            this.dugme1_5.Size = new System.Drawing.Size(35, 35);
            this.dugme1_5.TabIndex = 10;
            this.dugme1_5.Text = "5";
            this.dugme1_5.UseVisualStyleBackColor = false;
            this.dugme1_5.Click += new System.EventHandler(this.dugme1_5_Click);
            // 
            // dugme1_6
            // 
            this.dugme1_6.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme1_6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme1_6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme1_6.Location = new System.Drawing.Point(50, 59);
            this.dugme1_6.Name = "dugme1_6";
            this.dugme1_6.Size = new System.Drawing.Size(35, 35);
            this.dugme1_6.TabIndex = 11;
            this.dugme1_6.Text = "6";
            this.dugme1_6.UseVisualStyleBackColor = false;
            this.dugme1_6.Click += new System.EventHandler(this.dugme1_6_Click);
            // 
            // dugme1_7
            // 
            this.dugme1_7.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme1_7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme1_7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme1_7.Location = new System.Drawing.Point(91, 59);
            this.dugme1_7.Name = "dugme1_7";
            this.dugme1_7.Size = new System.Drawing.Size(35, 35);
            this.dugme1_7.TabIndex = 12;
            this.dugme1_7.Text = "7";
            this.dugme1_7.UseVisualStyleBackColor = false;
            this.dugme1_7.Click += new System.EventHandler(this.dugme1_7_Click);
            // 
            // dugme1_8
            // 
            this.dugme1_8.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme1_8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme1_8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme1_8.Location = new System.Drawing.Point(132, 59);
            this.dugme1_8.Name = "dugme1_8";
            this.dugme1_8.Size = new System.Drawing.Size(35, 35);
            this.dugme1_8.TabIndex = 13;
            this.dugme1_8.Text = "8";
            this.dugme1_8.UseVisualStyleBackColor = false;
            this.dugme1_8.Click += new System.EventHandler(this.dugme1_8_Click);
            // 
            // dugme2_1
            // 
            this.dugme2_1.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme2_1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme2_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme2_1.Location = new System.Drawing.Point(5, 19);
            this.dugme2_1.Name = "dugme2_1";
            this.dugme2_1.Size = new System.Drawing.Size(35, 35);
            this.dugme2_1.TabIndex = 18;
            this.dugme2_1.Text = "1";
            this.dugme2_1.UseVisualStyleBackColor = false;
            this.dugme2_1.Click += new System.EventHandler(this.dugme2_1_Click);
            // 
            // dugme2_2
            // 
            this.dugme2_2.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme2_2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme2_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme2_2.Location = new System.Drawing.Point(46, 19);
            this.dugme2_2.Name = "dugme2_2";
            this.dugme2_2.Size = new System.Drawing.Size(35, 35);
            this.dugme2_2.TabIndex = 19;
            this.dugme2_2.Text = "2";
            this.dugme2_2.UseVisualStyleBackColor = false;
            this.dugme2_2.Click += new System.EventHandler(this.dugme2_2_Click);
            // 
            // dugme2_3
            // 
            this.dugme2_3.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme2_3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme2_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme2_3.Location = new System.Drawing.Point(87, 19);
            this.dugme2_3.Name = "dugme2_3";
            this.dugme2_3.Size = new System.Drawing.Size(35, 35);
            this.dugme2_3.TabIndex = 20;
            this.dugme2_3.Text = "3";
            this.dugme2_3.UseVisualStyleBackColor = false;
            this.dugme2_3.Click += new System.EventHandler(this.dugme2_3_Click);
            // 
            // dugme2_4
            // 
            this.dugme2_4.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme2_4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme2_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme2_4.Location = new System.Drawing.Point(128, 19);
            this.dugme2_4.Name = "dugme2_4";
            this.dugme2_4.Size = new System.Drawing.Size(35, 35);
            this.dugme2_4.TabIndex = 21;
            this.dugme2_4.Text = "4";
            this.dugme2_4.UseVisualStyleBackColor = false;
            this.dugme2_4.Click += new System.EventHandler(this.dugme2_4_Click);
            // 
            // dugme2_5
            // 
            this.dugme2_5.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme2_5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme2_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme2_5.Location = new System.Drawing.Point(5, 60);
            this.dugme2_5.Name = "dugme2_5";
            this.dugme2_5.Size = new System.Drawing.Size(35, 35);
            this.dugme2_5.TabIndex = 22;
            this.dugme2_5.Text = "5";
            this.dugme2_5.UseVisualStyleBackColor = false;
            this.dugme2_5.Click += new System.EventHandler(this.dugme2_5_Click);
            // 
            // dugme2_6
            // 
            this.dugme2_6.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme2_6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme2_6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme2_6.Location = new System.Drawing.Point(46, 60);
            this.dugme2_6.Name = "dugme2_6";
            this.dugme2_6.Size = new System.Drawing.Size(35, 35);
            this.dugme2_6.TabIndex = 23;
            this.dugme2_6.Text = "6";
            this.dugme2_6.UseVisualStyleBackColor = false;
            this.dugme2_6.Click += new System.EventHandler(this.dugme2_6_Click);
            // 
            // dugme2_7
            // 
            this.dugme2_7.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme2_7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme2_7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme2_7.Location = new System.Drawing.Point(87, 60);
            this.dugme2_7.Name = "dugme2_7";
            this.dugme2_7.Size = new System.Drawing.Size(35, 35);
            this.dugme2_7.TabIndex = 24;
            this.dugme2_7.Text = "7";
            this.dugme2_7.UseVisualStyleBackColor = false;
            this.dugme2_7.Click += new System.EventHandler(this.dugme2_7_Click);
            // 
            // dugme2_8
            // 
            this.dugme2_8.BackColor = System.Drawing.Color.Gainsboro;
            this.dugme2_8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme2_8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dugme2_8.Location = new System.Drawing.Point(128, 60);
            this.dugme2_8.Name = "dugme2_8";
            this.dugme2_8.Size = new System.Drawing.Size(35, 35);
            this.dugme2_8.TabIndex = 25;
            this.dugme2_8.Text = "8";
            this.dugme2_8.UseVisualStyleBackColor = false;
            this.dugme2_8.Click += new System.EventHandler(this.dugme2_8_Click);
            // 
            // etiket2_yazi
            // 
            this.etiket2_yazi.AutoSize = true;
            this.etiket2_yazi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiket2_yazi.Location = new System.Drawing.Point(49, 20);
            this.etiket2_yazi.Name = "etiket2_yazi";
            this.etiket2_yazi.Size = new System.Drawing.Size(33, 17);
            this.etiket2_yazi.TabIndex = 29;
            this.etiket2_yazi.Text = "Yazı";
            // 
            // etiket1_yazi
            // 
            this.etiket1_yazi.AutoSize = true;
            this.etiket1_yazi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiket1_yazi.Location = new System.Drawing.Point(51, 20);
            this.etiket1_yazi.Name = "etiket1_yazi";
            this.etiket1_yazi.Size = new System.Drawing.Size(33, 17);
            this.etiket1_yazi.TabIndex = 28;
            this.etiket1_yazi.Text = "Yazı";
            // 
            // metin1_yazi
            // 
            this.metin1_yazi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metin1_yazi.Location = new System.Drawing.Point(18, 40);
            this.metin1_yazi.Name = "metin1_yazi";
            this.metin1_yazi.Size = new System.Drawing.Size(100, 25);
            this.metin1_yazi.TabIndex = 14;
            this.metin1_yazi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.metin1_yazi_KeyUp);
            // 
            // metin2_yazi
            // 
            this.metin2_yazi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metin2_yazi.Location = new System.Drawing.Point(17, 40);
            this.metin2_yazi.Name = "metin2_yazi";
            this.metin2_yazi.Size = new System.Drawing.Size(100, 25);
            this.metin2_yazi.TabIndex = 26;
            this.metin2_yazi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.metin2_yazi_KeyUp);
            // 
            // dugme1_gonder
            // 
            this.dugme1_gonder.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme1_gonder.Location = new System.Drawing.Point(29, 71);
            this.dugme1_gonder.Name = "dugme1_gonder";
            this.dugme1_gonder.Size = new System.Drawing.Size(76, 37);
            this.dugme1_gonder.TabIndex = 15;
            this.dugme1_gonder.Text = "Gönder";
            this.dugme1_gonder.UseVisualStyleBackColor = true;
            this.dugme1_gonder.Click += new System.EventHandler(this.dugme1_gonder_Click);
            // 
            // dugme2_gonder
            // 
            this.dugme2_gonder.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugme2_gonder.Location = new System.Drawing.Point(28, 71);
            this.dugme2_gonder.Name = "dugme2_gonder";
            this.dugme2_gonder.Size = new System.Drawing.Size(76, 37);
            this.dugme2_gonder.TabIndex = 27;
            this.dugme2_gonder.Text = "Gönder";
            this.dugme2_gonder.UseVisualStyleBackColor = true;
            this.dugme2_gonder.Click += new System.EventHandler(this.dugme2_gonder_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durum_yazisi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(778, 22);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // durum_yazisi
            // 
            this.durum_yazisi.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durum_yazisi.Name = "durum_yazisi";
            this.durum_yazisi.Size = new System.Drawing.Size(0, 17);
            // 
            // grup_buton1
            // 
            this.grup_buton1.Controls.Add(this.dugme1_8);
            this.grup_buton1.Controls.Add(this.dugme1_1);
            this.grup_buton1.Controls.Add(this.dugme1_2);
            this.grup_buton1.Controls.Add(this.dugme1_3);
            this.grup_buton1.Controls.Add(this.dugme1_4);
            this.grup_buton1.Controls.Add(this.dugme1_5);
            this.grup_buton1.Controls.Add(this.dugme1_6);
            this.grup_buton1.Controls.Add(this.dugme1_7);
            this.grup_buton1.Enabled = false;
            this.grup_buton1.Location = new System.Drawing.Point(29, 228);
            this.grup_buton1.Name = "grup_buton1";
            this.grup_buton1.Size = new System.Drawing.Size(178, 100);
            this.grup_buton1.TabIndex = 33;
            this.grup_buton1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(342, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grup_metin2
            // 
            this.grup_metin2.Controls.Add(this.metin2_yazi);
            this.grup_metin2.Controls.Add(this.etiket2_yazi);
            this.grup_metin2.Controls.Add(this.dugme2_gonder);
            this.grup_metin2.Enabled = false;
            this.grup_metin2.Location = new System.Drawing.Point(592, 347);
            this.grup_metin2.Name = "grup_metin2";
            this.grup_metin2.Size = new System.Drawing.Size(135, 120);
            this.grup_metin2.TabIndex = 34;
            this.grup_metin2.TabStop = false;
            // 
            // grup_metin1
            // 
            this.grup_metin1.Controls.Add(this.dugme1_gonder);
            this.grup_metin1.Controls.Add(this.etiket1_yazi);
            this.grup_metin1.Controls.Add(this.metin1_yazi);
            this.grup_metin1.Enabled = false;
            this.grup_metin1.Location = new System.Drawing.Point(49, 347);
            this.grup_metin1.Name = "grup_metin1";
            this.grup_metin1.Size = new System.Drawing.Size(135, 120);
            this.grup_metin1.TabIndex = 0;
            this.grup_metin1.TabStop = false;
            // 
            // grup_buton2
            // 
            this.grup_buton2.Controls.Add(this.dugme2_4);
            this.grup_buton2.Controls.Add(this.dugme2_1);
            this.grup_buton2.Controls.Add(this.dugme2_2);
            this.grup_buton2.Controls.Add(this.dugme2_3);
            this.grup_buton2.Controls.Add(this.dugme2_5);
            this.grup_buton2.Controls.Add(this.dugme2_6);
            this.grup_buton2.Controls.Add(this.dugme2_7);
            this.grup_buton2.Controls.Add(this.dugme2_8);
            this.grup_buton2.Enabled = false;
            this.grup_buton2.Location = new System.Drawing.Point(572, 228);
            this.grup_buton2.Name = "grup_buton2";
            this.grup_buton2.Size = new System.Drawing.Size(173, 100);
            this.grup_buton2.TabIndex = 0;
            this.grup_buton2.TabStop = false;
            // 
            // usbHidPort1
            // 
            this.usbHidPort1.ProductId = 0;
            this.usbHidPort1.VendorId = 0;
            this.usbHidPort1.OnSpecifiedDeviceArrived += new System.EventHandler(this.usbHidPort1_OnSpecifiedDeviceArrived);
            this.usbHidPort1.OnSpecifiedDeviceRemoved += new System.EventHandler(this.usbHidPort1_OnSpecifiedDeviceRemoved);
            this.usbHidPort1.OnDeviceArrived += new System.EventHandler(this.usbHidPort1_OnDeviceArrived);
            this.usbHidPort1.OnDeviceRemoved += new System.EventHandler(this.usbHidPort1_OnDeviceRemoved);
            this.usbHidPort1.OnDataRecieved += new UsbLibrary.DataRecievedEventHandler(this.usbHidPort1_OnDataRecieved);
            // 
            // grup_sicaklik1
            // 
            this.grup_sicaklik1.Controls.Add(this.etiket_sicaklik1);
            this.grup_sicaklik1.Controls.Add(this.label2);
            this.grup_sicaklik1.Enabled = false;
            this.grup_sicaklik1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grup_sicaklik1.Location = new System.Drawing.Point(288, 194);
            this.grup_sicaklik1.Name = "grup_sicaklik1";
            this.grup_sicaklik1.Size = new System.Drawing.Size(200, 100);
            this.grup_sicaklik1.TabIndex = 35;
            this.grup_sicaklik1.TabStop = false;
            this.grup_sicaklik1.Text = "1.İstemci";
            // 
            // etiket_sicaklik1
            // 
            this.etiket_sicaklik1.AutoSize = true;
            this.etiket_sicaklik1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiket_sicaklik1.Location = new System.Drawing.Point(73, 59);
            this.etiket_sicaklik1.Name = "etiket_sicaklik1";
            this.etiket_sicaklik1.Size = new System.Drawing.Size(54, 19);
            this.etiket_sicaklik1.TabIndex = 1;
            this.etiket_sicaklik1.Text = "__._°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sıcaklık";
            // 
            // grup_sicaklik2
            // 
            this.grup_sicaklik2.Controls.Add(this.etiket_sicaklik2);
            this.grup_sicaklik2.Controls.Add(this.label5);
            this.grup_sicaklik2.Enabled = false;
            this.grup_sicaklik2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grup_sicaklik2.Location = new System.Drawing.Point(288, 347);
            this.grup_sicaklik2.Name = "grup_sicaklik2";
            this.grup_sicaklik2.Size = new System.Drawing.Size(200, 100);
            this.grup_sicaklik2.TabIndex = 35;
            this.grup_sicaklik2.TabStop = false;
            this.grup_sicaklik2.Text = "2.İstemci";
            // 
            // etiket_sicaklik2
            // 
            this.etiket_sicaklik2.AutoSize = true;
            this.etiket_sicaklik2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiket_sicaklik2.Location = new System.Drawing.Point(73, 59);
            this.etiket_sicaklik2.Name = "etiket_sicaklik2";
            this.etiket_sicaklik2.Size = new System.Drawing.Size(54, 19);
            this.etiket_sicaklik2.TabIndex = 1;
            this.etiket_sicaklik2.Text = "__._°C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(64, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sıcaklık";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 520);
            this.Controls.Add(this.grup_sicaklik2);
            this.Controls.Add(this.grup_sicaklik1);
            this.Controls.Add(this.grup_metin1);
            this.Controls.Add(this.grup_buton2);
            this.Controls.Add(this.grup_metin2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grup_buton1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grup_secim2);
            this.Controls.Add(this.grup_secim1);
            this.Controls.Add(this.grup_istemci);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Endüstriyel Otomasyon Haberleşmesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grup_istemci.ResumeLayout(false);
            this.grup_istemci.PerformLayout();
            this.grup_secim1.ResumeLayout(false);
            this.grup_secim1.PerformLayout();
            this.grup_secim2.ResumeLayout(false);
            this.grup_secim2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grup_buton1.ResumeLayout(false);
            this.grup_metin2.ResumeLayout(false);
            this.grup_metin2.PerformLayout();
            this.grup_metin1.ResumeLayout(false);
            this.grup_metin1.PerformLayout();
            this.grup_buton2.ResumeLayout(false);
            this.grup_sicaklik1.ResumeLayout(false);
            this.grup_sicaklik1.PerformLayout();
            this.grup_sicaklik2.ResumeLayout(false);
            this.grup_sicaklik2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grup_istemci;
        private System.Windows.Forms.RadioButton denetim_istemci2;
        private System.Windows.Forms.RadioButton denetim_istemci1;
        private System.Windows.Forms.GroupBox grup_secim1;
        private System.Windows.Forms.RadioButton denetim_lcd1;
        private System.Windows.Forms.RadioButton denetim_lamba1;
        private System.Windows.Forms.GroupBox grup_secim2;
        private System.Windows.Forms.RadioButton denetim_lcd2;
        private System.Windows.Forms.Button dugme1_1;
        private System.Windows.Forms.Button dugme1_2;
        private System.Windows.Forms.Button dugme1_3;
        private System.Windows.Forms.Button dugme1_4;
        private System.Windows.Forms.Button dugme1_5;
        private System.Windows.Forms.Button dugme1_6;
        private System.Windows.Forms.Button dugme1_7;
        private System.Windows.Forms.Button dugme1_8;
        private System.Windows.Forms.Button dugme2_1;
        private System.Windows.Forms.Button dugme2_2;
        private System.Windows.Forms.Button dugme2_3;
        private System.Windows.Forms.Button dugme2_4;
        private System.Windows.Forms.Button dugme2_5;
        private System.Windows.Forms.Button dugme2_6;
        private System.Windows.Forms.Button dugme2_7;
        private System.Windows.Forms.Button dugme2_8;
        private System.Windows.Forms.Label etiket2_yazi;
        private System.Windows.Forms.Label etiket1_yazi;
        private System.Windows.Forms.TextBox metin1_yazi;
        private System.Windows.Forms.TextBox metin2_yazi;
        private System.Windows.Forms.Button dugme1_gonder;
        private System.Windows.Forms.Button dugme2_gonder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel durum_yazisi;
        private System.Windows.Forms.RadioButton denetim_lamba2;
        private System.Windows.Forms.GroupBox grup_buton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grup_metin2;
        private System.Windows.Forms.GroupBox grup_metin1;
        private System.Windows.Forms.GroupBox grup_buton2;
        private UsbLibrary.UsbHidPort usbHidPort1;
        private System.Windows.Forms.GroupBox grup_sicaklik1;
        private System.Windows.Forms.Label etiket_sicaklik1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grup_sicaklik2;
        private System.Windows.Forms.Label etiket_sicaklik2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

