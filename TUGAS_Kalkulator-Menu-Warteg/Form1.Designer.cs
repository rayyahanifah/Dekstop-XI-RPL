namespace TUGAS_Kalkulator_Menu_Warteg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbtnBuburKetanHitam = new RadioButton();
            rbtnBuburKacangHijau = new RadioButton();
            rbtnBuburAyam = new RadioButton();
            rbtnNasi2 = new RadioButton();
            rbtnNasi1 = new RadioButton();
            groupBox2 = new GroupBox();
            cbTumisToge = new CheckBox();
            cbAyam = new CheckBox();
            checkBox4 = new CheckBox();
            cbKikil = new CheckBox();
            cbSayurLabu = new CheckBox();
            cbTempe = new CheckBox();
            cbUsus = new CheckBox();
            cbCapcay = new CheckBox();
            groupBox3 = new GroupBox();
            cbLumpiaTahu = new CheckBox();
            cbKerupuk = new CheckBox();
            cbTahuIsi = new CheckBox();
            cbBakwan = new CheckBox();
            cbTempeGoreng = new CheckBox();
            cbPisang = new CheckBox();
            groupBox4 = new GroupBox();
            rbtnJusPepaya = new RadioButton();
            rbtnJusMangga = new RadioButton();
            rbtnJusAlpukat = new RadioButton();
            rbtnJusJeruk = new RadioButton();
            rbtnTehTawar = new RadioButton();
            rbtnTehManis = new RadioButton();
            rbtnAirPutih = new RadioButton();
            txtHarga = new TextBox();
            txtNama = new TextBox();
            groupBox5 = new GroupBox();
            label4 = new Label();
            txtTotal = new TextBox();
            txtPajak = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox6 = new GroupBox();
            txtEnergi = new TextBox();
            label9 = new Label();
            label6 = new Label();
            txtProtein = new TextBox();
            label7 = new Label();
            txtLemak = new TextBox();
            label8 = new Label();
            txtKarbohidrat = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 36);
            label1.TabIndex = 0;
            label1.Text = "Warteg Modern";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnBuburKetanHitam);
            groupBox1.Controls.Add(rbtnBuburKacangHijau);
            groupBox1.Controls.Add(rbtnBuburAyam);
            groupBox1.Controls.Add(rbtnNasi2);
            groupBox1.Controls.Add(rbtnNasi1);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(36, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 182);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pilih Karbohidrat";
            // 
            // rbtnBuburKetanHitam
            // 
            rbtnBuburKetanHitam.AutoSize = true;
            rbtnBuburKetanHitam.Location = new Point(17, 138);
            rbtnBuburKetanHitam.Name = "rbtnBuburKetanHitam";
            rbtnBuburKetanHitam.Size = new Size(225, 23);
            rbtnBuburKetanHitam.TabIndex = 4;
            rbtnBuburKetanHitam.Text = "Bubur Ketan Hitam (Rp. 10000)";
            rbtnBuburKetanHitam.UseVisualStyleBackColor = true;
            rbtnBuburKetanHitam.CheckedChanged += rbtnBuburKetanHitam_CheckedChanged;
            // 
            // rbtnBuburKacangHijau
            // 
            rbtnBuburKacangHijau.AutoSize = true;
            rbtnBuburKacangHijau.Location = new Point(19, 111);
            rbtnBuburKacangHijau.Name = "rbtnBuburKacangHijau";
            rbtnBuburKacangHijau.Size = new Size(216, 23);
            rbtnBuburKacangHijau.TabIndex = 3;
            rbtnBuburKacangHijau.Text = "Bubur Kacang Ijo (Rp. 10000)";
            rbtnBuburKacangHijau.UseVisualStyleBackColor = true;
            rbtnBuburKacangHijau.CheckedChanged += rbtnBuburKacangHijau_CheckedChanged;
            // 
            // rbtnBuburAyam
            // 
            rbtnBuburAyam.AutoSize = true;
            rbtnBuburAyam.Location = new Point(19, 82);
            rbtnBuburAyam.Name = "rbtnBuburAyam";
            rbtnBuburAyam.Size = new Size(182, 23);
            rbtnBuburAyam.TabIndex = 2;
            rbtnBuburAyam.Text = "Bubur Ayam (Rp. 12000)";
            rbtnBuburAyam.UseVisualStyleBackColor = true;
            rbtnBuburAyam.CheckedChanged += rbtnBuburAyam_CheckedChanged;
            // 
            // rbtnNasi2
            // 
            rbtnNasi2.AutoSize = true;
            rbtnNasi2.Location = new Point(19, 53);
            rbtnNasi2.Name = "rbtnNasi2";
            rbtnNasi2.Size = new Size(178, 23);
            rbtnNasi2.TabIndex = 1;
            rbtnNasi2.Text = "Nasi ½ Porsi (Rp. 3000)";
            rbtnNasi2.UseVisualStyleBackColor = true;
            rbtnNasi2.CheckedChanged += rbtnNasi2_CheckedChanged;
            // 
            // rbtnNasi1
            // 
            rbtnNasi1.AutoSize = true;
            rbtnNasi1.Location = new Point(19, 24);
            rbtnNasi1.Name = "rbtnNasi1";
            rbtnNasi1.Size = new Size(174, 23);
            rbtnNasi1.TabIndex = 0;
            rbtnNasi1.Text = "Nasi 1 Porsi (Rp. 5000)";
            rbtnNasi1.UseVisualStyleBackColor = true;
            rbtnNasi1.CheckedChanged += rbtnNasi1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbTumisToge);
            groupBox2.Controls.Add(cbAyam);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(cbKikil);
            groupBox2.Controls.Add(cbSayurLabu);
            groupBox2.Controls.Add(cbTempe);
            groupBox2.Controls.Add(cbUsus);
            groupBox2.Controls.Add(cbCapcay);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(36, 289);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(245, 264);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pilih Protein Nabati / Hewani";
            // 
            // cbTumisToge
            // 
            cbTumisToge.AutoSize = true;
            cbTumisToge.Location = new Point(16, 230);
            cbTumisToge.Name = "cbTumisToge";
            cbTumisToge.Size = new Size(169, 23);
            cbTumisToge.TabIndex = 7;
            cbTumisToge.Text = "Tumis Toge (Rp. 3000)";
            cbTumisToge.UseVisualStyleBackColor = true;
            cbTumisToge.CheckedChanged += cbTumisToge_CheckedChanged;
            // 
            // cbAyam
            // 
            cbAyam.AutoSize = true;
            cbAyam.Location = new Point(16, 25);
            cbAyam.Name = "cbAyam";
            cbAyam.Size = new Size(184, 23);
            cbAyam.TabIndex = 2;
            cbAyam.Text = "Ayam Goreng (Rp. 7000)";
            cbAyam.UseVisualStyleBackColor = true;
            cbAyam.CheckedChanged += cbAyam_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(16, 54);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(177, 23);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Telur Balado (Rp. 5000)";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // cbKikil
            // 
            cbKikil.AutoSize = true;
            cbKikil.Location = new Point(16, 85);
            cbKikil.Name = "cbKikil";
            cbKikil.Size = new Size(129, 23);
            cbKikil.TabIndex = 0;
            cbKikil.Text = "Kikil (Rp. 4000)";
            cbKikil.UseVisualStyleBackColor = true;
            cbKikil.CheckedChanged += cbKikil_CheckedChanged;
            // 
            // cbSayurLabu
            // 
            cbSayurLabu.AutoSize = true;
            cbSayurLabu.Location = new Point(16, 201);
            cbSayurLabu.Name = "cbSayurLabu";
            cbSayurLabu.Size = new Size(170, 23);
            cbSayurLabu.TabIndex = 5;
            cbSayurLabu.Text = "Sayur Labu (Rp. 3000)";
            cbSayurLabu.UseVisualStyleBackColor = true;
            cbSayurLabu.CheckedChanged += cbSayurLabu_CheckedChanged;
            // 
            // cbTempe
            // 
            cbTempe.AutoSize = true;
            cbTempe.Location = new Point(16, 143);
            cbTempe.Name = "cbTempe";
            cbTempe.Size = new Size(177, 23);
            cbTempe.TabIndex = 4;
            cbTempe.Text = "Tempe Orek (Rp. 4000)";
            cbTempe.UseVisualStyleBackColor = true;
            cbTempe.CheckedChanged += cbTempe_CheckedChanged;
            // 
            // cbUsus
            // 
            cbUsus.AutoSize = true;
            cbUsus.Location = new Point(16, 114);
            cbUsus.Name = "cbUsus";
            cbUsus.Size = new Size(130, 23);
            cbUsus.TabIndex = 1;
            cbUsus.Text = "Usus (Rp. 4000)";
            cbUsus.UseVisualStyleBackColor = true;
            cbUsus.CheckedChanged += cbUsus_CheckedChanged;
            // 
            // cbCapcay
            // 
            cbCapcay.AutoSize = true;
            cbCapcay.Location = new Point(16, 172);
            cbCapcay.Name = "cbCapcay";
            cbCapcay.Size = new Size(147, 23);
            cbCapcay.TabIndex = 6;
            cbCapcay.Text = "Capcay (Rp. 4000)";
            cbCapcay.UseVisualStyleBackColor = true;
            cbCapcay.CheckedChanged += cbCapcay_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbLumpiaTahu);
            groupBox3.Controls.Add(cbKerupuk);
            groupBox3.Controls.Add(cbTahuIsi);
            groupBox3.Controls.Add(cbBakwan);
            groupBox3.Controls.Add(cbTempeGoreng);
            groupBox3.Controls.Add(cbPisang);
            groupBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(299, 345);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(245, 208);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tambahan";
            // 
            // cbLumpiaTahu
            // 
            cbLumpiaTahu.AutoSize = true;
            cbLumpiaTahu.Location = new Point(16, 114);
            cbLumpiaTahu.Name = "cbLumpiaTahu";
            cbLumpiaTahu.Size = new Size(178, 23);
            cbLumpiaTahu.TabIndex = 5;
            cbLumpiaTahu.Text = "Lumpia Tahu (Rp. 2000)";
            cbLumpiaTahu.UseVisualStyleBackColor = true;
            cbLumpiaTahu.CheckedChanged += cbLumpiaTahu_CheckedChanged;
            // 
            // cbKerupuk
            // 
            cbKerupuk.AutoSize = true;
            cbKerupuk.Location = new Point(16, 172);
            cbKerupuk.Name = "cbKerupuk";
            cbKerupuk.Size = new Size(154, 23);
            cbKerupuk.TabIndex = 4;
            cbKerupuk.Text = "Kerupuk (Rp. 1000)";
            cbKerupuk.UseVisualStyleBackColor = true;
            cbKerupuk.CheckedChanged += cbKerupuk_CheckedChanged;
            // 
            // cbTahuIsi
            // 
            cbTahuIsi.AutoSize = true;
            cbTahuIsi.Location = new Point(16, 25);
            cbTahuIsi.Name = "cbTahuIsi";
            cbTahuIsi.Size = new Size(147, 23);
            cbTahuIsi.TabIndex = 2;
            cbTahuIsi.Text = "Tahu Isi (Rp. 2000)";
            cbTahuIsi.UseVisualStyleBackColor = true;
            cbTahuIsi.CheckedChanged += cbTahuIsi_CheckedChanged;
            // 
            // cbBakwan
            // 
            cbBakwan.AutoSize = true;
            cbBakwan.Location = new Point(16, 54);
            cbBakwan.Name = "cbBakwan";
            cbBakwan.Size = new Size(150, 23);
            cbBakwan.TabIndex = 3;
            cbBakwan.Text = "Bakwan (Rp. 1000)";
            cbBakwan.UseVisualStyleBackColor = true;
            cbBakwan.CheckedChanged += cbBakwan_CheckedChanged;
            // 
            // cbTempeGoreng
            // 
            cbTempeGoreng.AutoSize = true;
            cbTempeGoreng.Location = new Point(16, 85);
            cbTempeGoreng.Name = "cbTempeGoreng";
            cbTempeGoreng.Size = new Size(190, 23);
            cbTempeGoreng.TabIndex = 0;
            cbTempeGoreng.Text = "Tempe Goreng (Rp. 1000)";
            cbTempeGoreng.UseVisualStyleBackColor = true;
            cbTempeGoreng.CheckedChanged += cbTempeGoreng_CheckedChanged;
            // 
            // cbPisang
            // 
            cbPisang.AutoSize = true;
            cbPisang.Location = new Point(16, 143);
            cbPisang.Name = "cbPisang";
            cbPisang.Size = new Size(188, 23);
            cbPisang.TabIndex = 1;
            cbPisang.Text = "Pisang Goreng (Rp. 2000)";
            cbPisang.UseVisualStyleBackColor = true;
            cbPisang.CheckedChanged += cbPisang_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbtnJusPepaya);
            groupBox4.Controls.Add(rbtnJusMangga);
            groupBox4.Controls.Add(rbtnJusAlpukat);
            groupBox4.Controls.Add(rbtnJusJeruk);
            groupBox4.Controls.Add(rbtnTehTawar);
            groupBox4.Controls.Add(rbtnTehManis);
            groupBox4.Controls.Add(rbtnAirPutih);
            groupBox4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(299, 101);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(245, 236);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pilih Minuman";
            // 
            // rbtnJusPepaya
            // 
            rbtnJusPepaya.AutoSize = true;
            rbtnJusPepaya.Location = new Point(19, 198);
            rbtnJusPepaya.Name = "rbtnJusPepaya";
            rbtnJusPepaya.Size = new Size(167, 23);
            rbtnJusPepaya.TabIndex = 6;
            rbtnJusPepaya.TabStop = true;
            rbtnJusPepaya.Text = "Jus Pepaya (Rp. 7000)";
            rbtnJusPepaya.UseVisualStyleBackColor = true;
            rbtnJusPepaya.CheckedChanged += rbtnJusPepaya_CheckedChanged;
            // 
            // rbtnJusMangga
            // 
            rbtnJusMangga.AutoSize = true;
            rbtnJusMangga.Location = new Point(19, 169);
            rbtnJusMangga.Name = "rbtnJusMangga";
            rbtnJusMangga.Size = new Size(171, 23);
            rbtnJusMangga.TabIndex = 5;
            rbtnJusMangga.TabStop = true;
            rbtnJusMangga.Text = "Jus Mangga (Rp. 9000)";
            rbtnJusMangga.UseVisualStyleBackColor = true;
            rbtnJusMangga.CheckedChanged += rbtnJusMangga_CheckedChanged;
            // 
            // rbtnJusAlpukat
            // 
            rbtnJusAlpukat.AutoSize = true;
            rbtnJusAlpukat.Location = new Point(19, 140);
            rbtnJusAlpukat.Name = "rbtnJusAlpukat";
            rbtnJusAlpukat.Size = new Size(169, 23);
            rbtnJusAlpukat.TabIndex = 4;
            rbtnJusAlpukat.TabStop = true;
            rbtnJusAlpukat.Text = "Jus Alpukat (Rp. 8000)";
            rbtnJusAlpukat.UseVisualStyleBackColor = true;
            rbtnJusAlpukat.CheckedChanged += rbtnJusAlpukat_CheckedChanged;
            // 
            // rbtnJusJeruk
            // 
            rbtnJusJeruk.AutoSize = true;
            rbtnJusJeruk.Location = new Point(19, 111);
            rbtnJusJeruk.Name = "rbtnJusJeruk";
            rbtnJusJeruk.Size = new Size(155, 23);
            rbtnJusJeruk.TabIndex = 3;
            rbtnJusJeruk.TabStop = true;
            rbtnJusJeruk.Text = "Jus Jeruk (Rp. 5000)";
            rbtnJusJeruk.UseVisualStyleBackColor = true;
            rbtnJusJeruk.CheckedChanged += rbtnJusJeruk_CheckedChanged;
            // 
            // rbtnTehTawar
            // 
            rbtnTehTawar.AutoSize = true;
            rbtnTehTawar.Location = new Point(19, 53);
            rbtnTehTawar.Name = "rbtnTehTawar";
            rbtnTehTawar.Size = new Size(163, 23);
            rbtnTehTawar.TabIndex = 2;
            rbtnTehTawar.TabStop = true;
            rbtnTehTawar.Text = "Teh Tawar (Rp. 3000)";
            rbtnTehTawar.UseVisualStyleBackColor = true;
            rbtnTehTawar.CheckedChanged += rbtnTehTawar_CheckedChanged;
            // 
            // rbtnTehManis
            // 
            rbtnTehManis.AutoSize = true;
            rbtnTehManis.Location = new Point(19, 82);
            rbtnTehManis.Name = "rbtnTehManis";
            rbtnTehManis.Size = new Size(162, 23);
            rbtnTehManis.TabIndex = 1;
            rbtnTehManis.TabStop = true;
            rbtnTehManis.Text = "Teh Manis (Rp. 5000)";
            rbtnTehManis.UseVisualStyleBackColor = true;
            rbtnTehManis.CheckedChanged += rbtnTehManis_CheckedChanged;
            // 
            // rbtnAirPutih
            // 
            rbtnAirPutih.AutoSize = true;
            rbtnAirPutih.Location = new Point(19, 24);
            rbtnAirPutih.Name = "rbtnAirPutih";
            rbtnAirPutih.Size = new Size(134, 23);
            rbtnAirPutih.TabIndex = 0;
            rbtnAirPutih.TabStop = true;
            rbtnAirPutih.Text = "Air Putih  (Gratis)";
            rbtnAirPutih.UseVisualStyleBackColor = true;
            rbtnAirPutih.CheckedChanged += rbtAirPutih_CheckedChanged;
            // 
            // txtHarga
            // 
            txtHarga.Enabled = false;
            txtHarga.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHarga.Location = new Point(71, 25);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(159, 26);
            txtHarga.TabIndex = 10;
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNama.Location = new Point(367, 65);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(245, 26);
            txtNama.TabIndex = 11;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(txtTotal);
            groupBox5.Controls.Add(txtPajak);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(txtHarga);
            groupBox5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(565, 101);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(245, 130);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 92);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 14;
            label4.Text = "Total :";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(71, 89);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(159, 26);
            txtTotal.TabIndex = 13;
            // 
            // txtPajak
            // 
            txtPajak.Enabled = false;
            txtPajak.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPajak.Location = new Point(71, 57);
            txtPajak.Name = "txtPajak";
            txtPajak.Size = new Size(159, 26);
            txtPajak.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 11;
            label3.Text = "Pajak :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 28);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 0;
            label2.Text = "Harga :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(204, 68);
            label5.Name = "label5";
            label5.Size = new Size(157, 19);
            label5.TabIndex = 14;
            label5.Text = "Masukkan Nama Anda :";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(749, 430);
            button1.Name = "button1";
            button1.Size = new Size(61, 28);
            button1.TabIndex = 15;
            button1.Text = "Kirim";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(682, 430);
            button2.Name = "button2";
            button2.Size = new Size(61, 28);
            button2.TabIndex = 16;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(572, 430);
            button3.Name = "button3";
            button3.Size = new Size(61, 28);
            button3.TabIndex = 17;
            button3.Text = "Tutup";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtEnergi);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(txtProtein);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(txtLemak);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(txtKarbohidrat);
            groupBox6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(565, 241);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(245, 166);
            groupBox6.TabIndex = 15;
            groupBox6.TabStop = false;
            groupBox6.Text = "Kandungan";
            // 
            // txtEnergi
            // 
            txtEnergi.Enabled = false;
            txtEnergi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnergi.Location = new Point(71, 25);
            txtEnergi.Name = "txtEnergi";
            txtEnergi.Size = new Size(159, 26);
            txtEnergi.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 28);
            label9.Name = "label9";
            label9.Size = new Size(54, 19);
            label9.TabIndex = 15;
            label9.Text = "Energi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 61);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 14;
            label6.Text = "Lemak :";
            // 
            // txtProtein
            // 
            txtProtein.Enabled = false;
            txtProtein.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProtein.Location = new Point(71, 89);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(159, 26);
            txtProtein.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 92);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 11;
            label7.Text = "Protein :";
            // 
            // txtLemak
            // 
            txtLemak.Enabled = false;
            txtLemak.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLemak.Location = new Point(71, 58);
            txtLemak.Name = "txtLemak";
            txtLemak.Size = new Size(159, 26);
            txtLemak.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 124);
            label8.Name = "label8";
            label8.Size = new Size(90, 19);
            label8.TabIndex = 0;
            label8.Text = "Karbohidrat :";
            // 
            // txtKarbohidrat
            // 
            txtKarbohidrat.Enabled = false;
            txtKarbohidrat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKarbohidrat.Location = new Point(108, 121);
            txtKarbohidrat.Name = "txtKarbohidrat";
            txtKarbohidrat.Size = new Size(122, 26);
            txtKarbohidrat.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 579);
            Controls.Add(groupBox6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(groupBox5);
            Controls.Add(txtNama);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtnNasi1;
        private RadioButton rbtnNasi2;
        private GroupBox groupBox2;
        private CheckBox cbUsus;
        private CheckBox cbKikil;
        private CheckBox cbTumisToge;
        private CheckBox cbAyam;
        private CheckBox cbSayurLabu;
        private CheckBox cbCapcay;
        private CheckBox checkBox4;
        private CheckBox cbTempe;
        private GroupBox groupBox3;
        private CheckBox cbTahuIsi;
        private CheckBox cbBakwan;
        private CheckBox cbTempeGoreng;
        private CheckBox cbPisang;
        private RadioButton rbtnBuburKetanHitam;
        private RadioButton rbtnBuburKacangHijau;
        private RadioButton rbtnBuburAyam;
        private GroupBox groupBox4;
        private RadioButton rbtnJusJeruk;
        private RadioButton rbtnTehTawar;
        private RadioButton rbtnTehManis;
        private RadioButton rbtnAirPutih;
        private TextBox txtHarga;
        private TextBox txtNama;
        private GroupBox groupBox5;
        private Label label4;
        private TextBox txtTotal;
        private TextBox txtPajak;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private RadioButton rbtnJusAlpukat;
        private CheckBox cbLumpiaTahu;
        private CheckBox cbKerupuk;
        private RadioButton rbtnJusPepaya;
        private RadioButton rbtnJusMangga;
        private GroupBox groupBox6;
        private Label label6;
        private TextBox txtLemak;
        private TextBox txtProtein;
        private Label label7;
        private Label label8;
        private TextBox txtKarbohidrat;
        private TextBox txtEnergi;
        private Label label9;
    }
}
