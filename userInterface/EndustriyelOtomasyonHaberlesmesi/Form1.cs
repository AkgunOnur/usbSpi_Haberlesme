using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using UsbLibrary;

namespace EndustriyelOtomasyonHaberlesmesi
{
    public partial class Form1 : Form
    {

        byte veri1 = 0;
        byte veri2 = 0;
        byte gelenDenetim = 1;
        byte hangiIslem = 0;
        byte hangiIstemci = 0;
        byte metin_uzunlugu = 0;
        byte tam = 0, ondalik = 0;
        string metin = "";
        bool veriAkisi = false;
        bool bayrak1_1 = false;
        bool bayrak1_2 = false;
        bool bayrak1_3 = false;
        bool bayrak1_4 = false;
        bool bayrak1_5 = false;
        bool bayrak1_6 = false;
        bool bayrak1_7 = false;
        bool bayrak1_8 = false;
        bool bayrak2_1 = false;
        bool bayrak2_2 = false;
        bool bayrak2_3 = false;
        bool bayrak2_4 = false;
        bool bayrak2_5 = false;
        bool bayrak2_6 = false;
        bool bayrak2_7 = false;
        bool bayrak2_8 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            usbHidPort1.RegisterHandle(Handle);
        }

        protected override void WndProc(ref Message m)
        {
            usbHidPort1.ParseMessages(ref m);
            base.WndProc(ref m);
        }

        private void Usb_veriGonder()
        {
            try
            {
                if ((gelenDenetim == 1) && (usbHidPort1.SpecifiedDevice != null))
                {
                    gelenDenetim = 0;

                    int diziUzunlugu = usbHidPort1.SpecifiedDevice.OutputReportLength;
                    byte[] gonderilenVeri = new byte[diziUzunlugu + 1];

                    for (int i = 0; i < diziUzunlugu; i++)
                        gonderilenVeri[i] = 0x00;
                    
                    if (denetim_istemci1.Checked)
                        hangiIstemci = 1;
                    else if (denetim_istemci2.Checked)
                        hangiIstemci = 2;

                    gonderilenVeri[0] = 0;
                    gonderilenVeri[1] = hangiIstemci;
                    gonderilenVeri[2] = hangiIslem;
                    

                    if (hangiIstemci == 1 && hangiIslem == 1)
                        gonderilenVeri[3] = veri1;
                    
                    else if (hangiIstemci == 2 && hangiIslem == 1)
                        gonderilenVeri[3] = veri2;
                    

                    else if (hangiIstemci == 1 && hangiIslem == 2)
                    {
                        metin = metin1_yazi.Text;
                        metin_uzunlugu = Convert.ToByte(metin.Length);
                        gonderilenVeri[3] = 32;

                        for (int i = 0; i < 32; i++)
                        {
                            if (metin_uzunlugu > i)
                                gonderilenVeri[i + 4] = Convert.ToByte(metin[i]);
                            else
                                gonderilenVeri[i + 4] = Convert.ToByte(' ');
                        }
                    }
                    else if (hangiIstemci == 2 && hangiIslem == 2)
                    {
                        metin = metin2_yazi.Text;
                        metin_uzunlugu = Convert.ToByte(metin.Length);
                        gonderilenVeri[3] = 32;

                        for (int i = 0; i < 32; i++)
                        {
                            if (metin_uzunlugu > i)
                                gonderilenVeri[i + 4] = Convert.ToByte(metin[i]);
                            else
                                gonderilenVeri[i + 4] = Convert.ToByte(' ');
                        }
                    }
                    

                    usbHidPort1.SpecifiedDevice.SendData(gonderilenVeri);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                usbHidPort1.VendorId = 0x1111;
                usbHidPort1.ProductId = 0x1111;
                usbHidPort1.CheckDevicePresent();
                
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }

        }

        private void denetim_istemci1_CheckedChanged(object sender, EventArgs e)
        {
            if (denetim_istemci1.Checked)
            {
                grup_secim1.Enabled = true;
                grup_secim2.Enabled = false;
                denetim_lamba2.Checked = false;
                denetim_lcd2.Checked = false;
                grup_sicaklik1.Enabled = true;
            }
            else
            {
                grup_secim1.Enabled = false;
                grup_sicaklik1.Enabled = false;
                denetim_lamba1.Checked = false;
                denetim_lcd1.Checked = false;
            }

        }

        private void denetim_istemci2_CheckedChanged(object sender, EventArgs e)
        {
            if (denetim_istemci2.Checked)
            {
                grup_secim1.Enabled = false;
                grup_secim2.Enabled = true;
                denetim_lamba1.Checked = false;
                denetim_lcd1.Checked = false;
                grup_sicaklik2.Enabled = true;

            }
            else
            {
                grup_secim2.Enabled = false;
                grup_sicaklik2.Enabled = false;
                denetim_lamba2.Checked = false;
                denetim_lcd2.Checked = false;
            }
        }

        

        private void denetim_lamba1_CheckedChanged(object sender, EventArgs e)
        {
            if (denetim_lamba1.Checked)
            {
                grup_buton1.Enabled = true;
                grup_metin1.Enabled = false;
                veriAkisi = true;
                hangiIslem = 1;
                Usb_veriGonder();
            }
            else
            {
                grup_buton1.Enabled = false;
            }
            
        }

        private void denetim_lamba2_CheckedChanged(object sender, EventArgs e)
        {

            if (denetim_lamba2.Checked)
            {
                grup_buton2.Enabled = true;
                grup_metin2.Enabled = false;
                veriAkisi = true;
                hangiIslem = 1;
                Usb_veriGonder();
            }
            else
            {
                grup_buton2.Enabled = false;
            }
            
        }

        private void denetim_lcd1_CheckedChanged(object sender, EventArgs e)
        {
            if (denetim_lcd1.Checked)
            {
                grup_buton1.Enabled = false;
                grup_metin1.Enabled = true;
            }
            else
            {
                grup_metin1.Enabled = false;
                metin1_yazi.Text = "";
            }
            
        }

        private void denetim_lcd2_CheckedChanged(object sender, EventArgs e)
        {
            if (denetim_lcd2.Checked)
            {
                grup_buton2.Enabled = false;
                grup_metin2.Enabled = true;

            }
            else
            {
                grup_metin2.Enabled = false;
                metin2_yazi.Text = "";
            }
            
        }

        private void dugme1_1_Click(object sender, EventArgs e)
        {
            bayrak1_1 = !bayrak1_1;
            hangiIslem = 1;
            if (bayrak1_1)
            {
                veri1 |= 0x01;
                dugme1_1.BackColor = Color.Red;
            }
            else
            {
                veri1 &= 0xFE;
                dugme1_1.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();

        }

        private void dugme1_2_Click(object sender, EventArgs e)
        {

            bayrak1_2 = !bayrak1_2;
            hangiIslem = 1;
            if (bayrak1_2)
            {
                veri1 |= 0x02;
                dugme1_2.BackColor = Color.Red;
            }
            else
            {
                veri1 &= 0xFD;
                dugme1_2.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme1_3_Click(object sender, EventArgs e)
        {
            bayrak1_3 = !bayrak1_3;
            hangiIslem = 1;
            if (bayrak1_3)
            {
                veri1 |= 0x04;
                dugme1_3.BackColor = Color.Red;
            }
            else
            {
                veri1 &= 0xFB;
                dugme1_3.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme1_4_Click(object sender, EventArgs e)
        {
            bayrak1_4 = !bayrak1_4;
            hangiIslem = 1;
            if (bayrak1_4)
            {
                veri1 |= 0x08;
                dugme1_4.BackColor = Color.Red;
            }
            else
            {
                veri1 &= 0xF7;
                dugme1_4.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme1_5_Click(object sender, EventArgs e)
        {
            bayrak1_5 = !bayrak1_5;
            hangiIslem = 1;
            if (bayrak1_5)
            {
                veri1 |= 0x10;
                dugme1_5.BackColor = Color.Red;
            }
            else
            {
                veri1 &= 0xEF;
                dugme1_5.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme1_6_Click(object sender, EventArgs e)
        {
            bayrak1_6 = !bayrak1_6;
            hangiIslem = 1;
            if (bayrak1_6)
            {
                veri1 |= 0x20;
                dugme1_6.BackColor = Color.Red;
            }
            else
            {
                veri1 &= 0xDF;
                dugme1_6.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme1_7_Click(object sender, EventArgs e)
        {
            bayrak1_7 = !bayrak1_7;
            hangiIslem = 1;
            if (bayrak1_7)
            {
                veri1 |= 0x40;
                dugme1_7.BackColor = Color.Red;
            }
            else
            {
                veri1 &= 0xBF;
                dugme1_7.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme1_8_Click(object sender, EventArgs e)
        {
            bayrak1_8 = !bayrak1_8;
            hangiIslem = 1;
            if (bayrak1_8)
            {
                veri1 |= 0x80;
                dugme1_8.BackColor = Color.Red;
            }
            else
            {
                veri1 &= 0x7F;
                dugme1_8.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme2_1_Click(object sender, EventArgs e)
        {
            
            bayrak2_1 = !bayrak2_1;
            hangiIslem = 1;

            if (bayrak2_1)
            {
                veri2 |= 0x01;
                dugme2_1.BackColor = Color.Green;
            }
            else
            {
                veri2 &= 0xFE;
                dugme2_1.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme2_2_Click(object sender, EventArgs e)
        {
            bayrak2_2 = !bayrak2_2;
            hangiIslem = 1;

            if (bayrak2_2)
            {
                veri2 |= 0x02;
                dugme2_2.BackColor = Color.Green;
            }
            else
            {
                veri2 &= 0xFD;
                dugme2_2.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme2_3_Click(object sender, EventArgs e)
        {
            bayrak2_3 = !bayrak2_3;
            hangiIslem = 1;

            if (bayrak2_3)
            {
                veri2 |= 0x04;
                dugme2_3.BackColor = Color.Green;
            }
            else
            {
                veri2 &= 0xFB;
                dugme2_3.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme2_4_Click(object sender, EventArgs e)
        {
            bayrak2_4 = !bayrak2_4;
            hangiIslem = 1;

            if (bayrak2_4)
            {
                veri2 |= 0x08;
                dugme2_4.BackColor = Color.Green;
            }
            else
            {
                veri2 &= 0xF7;
                dugme2_4.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme2_5_Click(object sender, EventArgs e)
        {
            bayrak2_5 = !bayrak2_5;
            hangiIslem = 1;

            if (bayrak2_5)
            {
                veri2 |= 0x10;
                dugme2_5.BackColor = Color.Green;
            }
            else
            {
                veri2 &= 0xEF;
                dugme2_5.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme2_6_Click(object sender, EventArgs e)
        {
            bayrak2_6 = !bayrak2_6;
            hangiIslem = 1;
            if (bayrak2_6)
            {
                veri2 |= 0x20;
                dugme2_6.BackColor = Color.Green;
            }
            else
            {
                veri2 &= 0xDF;
                dugme2_6.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme2_7_Click(object sender, EventArgs e)
        {
            bayrak2_7 = !bayrak2_7;
            hangiIslem = 1;

            if (bayrak2_7)
            {
                veri2 |= 0x40;
                dugme2_7.BackColor = Color.Green;
            }
            else
            {
                veri2 &= 0xBF;
                dugme2_7.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme2_8_Click(object sender, EventArgs e)
        {
            bayrak2_8 = !bayrak2_8;
            hangiIslem = 1;

            if (bayrak2_8)
            {
                veri2 |= 0x80;
                dugme2_8.BackColor = Color.Green;
            }
            else
            {
                veri2 &= 0x7F;
                dugme2_8.BackColor = Color.Gainsboro;
            }

            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme1_gonder_Click(object sender, EventArgs e)
        {
            hangiIslem = 2;
            veriAkisi = true;
            Usb_veriGonder();
        }

        private void dugme2_gonder_Click(object sender, EventArgs e)
        {
            hangiIslem = 2;
            veriAkisi = true;
            Usb_veriGonder();
        }

        private void usbHidPort1_OnDataRecieved(object sender, DataRecievedEventArgs args)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new DataRecievedEventHandler(usbHidPort1_OnDataRecieved), new object[] { sender, args });
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.ToString());
                }
            }
            else
            {
                int diziUzunlugu = usbHidPort1.SpecifiedDevice.OutputReportLength;
                byte[] alinanVeri = new byte[diziUzunlugu + 1];
                alinanVeri = args.data;
                gelenDenetim = alinanVeri[1];
                tam = alinanVeri[2];
                ondalik = alinanVeri[3];
                if(denetim_istemci1.Checked)
                    etiket_sicaklik1.Text = tam + "." + ondalik + " °C";
                else if (denetim_istemci2.Checked)
                    etiket_sicaklik2.Text = tam + "." + ondalik + " °C";
                
                veriAkisi = false;
            }
        }

        private void metin1_yazi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hangiIslem = 2;
                veriAkisi = true;
                Usb_veriGonder();
            }
        }

        private void metin2_yazi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hangiIslem = 2;
                veriAkisi = true;
                Usb_veriGonder();
            }
        }

        private void usbHidPort1_OnDeviceArrived(object sender, EventArgs e)
        {
            durum_yazisi.Text = "Bir USB cihazı bağlandı!";
        }

        private void usbHidPort1_OnDeviceRemoved(object sender, EventArgs e)
        {
            durum_yazisi.Text = "USB cihazı çıkarıldı!";
        }

        private void usbHidPort1_OnSpecifiedDeviceArrived(object sender, EventArgs e)
        {
            durum_yazisi.Text = "PIC18F4550 Bağlandı!";
            grup_istemci.Enabled = true;
            timer1.Enabled = true;
        }

        private void usbHidPort1_OnSpecifiedDeviceRemoved(object sender, EventArgs e)
        {
            durum_yazisi.Text = "PIC18F4550 Bağlantısı Kesildi!";
            grup_istemci.Enabled = false;
            grup_sicaklik1.Enabled = false;
            grup_sicaklik2.Enabled = false;
            grup_secim1.Enabled = false;
            grup_secim2.Enabled = false;
            grup_buton1.Enabled = false;
            grup_buton2.Enabled = false;
            grup_metin1.Enabled = false;
            grup_metin2.Enabled = false;
            timer1.Enabled = false;
            veriAkisi = false;
            Application.Exit();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!veriAkisi)
            {
                hangiIslem = 3;
                Usb_veriGonder();
            }
        }
    }
}
