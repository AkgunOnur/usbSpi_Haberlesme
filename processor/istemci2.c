#include <16f877.h> 

#device ADC=10

#fuses XT,NOWDT,NOPROTECT,NOBROWNOUT,NOLVP,NOPUT,NOWRT,NODEBUG,NOCPD
#use delay(clock=4000000)

#use fast_io(a)
#use fast_io(b)
#use fast_io(c)
#use fast_io(d)

#define use_portb_lcd TRUE
#include <lcd.c>

unsigned int8 veri,uzunluk = 0,denetim=0,i=0;
unsigned int8 j=0,mod=0,kalan=0,tam=0,ondalik=0;
char ilk_denetim=0;
char gelenYazi[32], gelenVeri=0;
char Yazi1[16];
char Yazi2[16];
float gerilim, sicaklik;
unsigned long int bilgi;

void sicaklikOku()
{
      for(i=0;i<3;i++)
      {
         bilgi = read_adc();
         delay_us(20);
      }
      gerilim=(0.0048828125*bilgi)*1000;
      sicaklik=gerilim/10;
      tam = sicaklik;
      ondalik = (sicaklik-tam)*100;
}

void main()
{
   setup_psp(PSP_DISABLED);
   setup_timer_0(RTCC_INTERNAL|RTCC_DIV_1);
   setup_timer_1(T1_DISABLED);
   setup_timer_2(T2_DISABLED,0,1);
   setup_spi(spi_slave | spi_L_to_H | spi_clk_div_4);
   setup_adc(adc_clock_div_32);   
   setup_adc_ports(AN0); 
   
   set_tris_a(0x21);
   set_tris_b(0x00);
   set_tris_c(0x18);
   set_tris_d(0x00);
   
   output_a(0x20);
   output_b(0x00);
   output_c(0x00);
   output_d(0x00);
   
   lcd_init();
   
   
   while(ilk_denetim != '1')
   {
      spi_write('2');
      while(!spi_data_is_in());
      ilk_denetim = spi_read();
   }

   while(mod == 0)
   {
      spi_write('4');
      while(!spi_data_is_in());
      mod = spi_read();     
   }
   
   
   while(1)
   {
                  
         if(spi_data_is_in())
         {         
            denetim = spi_read();         
            if(denetim == '1')
            {
               while(!spi_data_is_in());
               veri = spi_read();
               spi_write('1');
               while(!spi_data_is_in());
               kalan = spi_read();
                  
               if((veri%mod)==kalan)
                   output_d(veri); 
            }
            else if(denetim == '2')
            {
               while(!spi_data_is_in());
               veri = spi_read();
               spi_write('1');
               while(!spi_data_is_in());
               kalan = spi_read();
               
               if((veri%mod)==kalan)
                  uzunluk = veri;
               
               for(j=0;j<uzunluk;j++)
               {   
                  while(!spi_data_is_in());
                  gelenVeri = spi_read();
                  spi_write('1');
                  while(!spi_data_is_in());
                  kalan = spi_read();
                  
                  if((gelenVeri%mod)==kalan)
                     gelenYazi[j] = gelenVeri;
 
               }
               
               for(j=0;j<uzunluk;j++)
               {
                  if(j<16)
                  {
                     Yazi1[j] = gelenYazi[j];
                     Yazi2[15-j] = '\0';
                  }
                  else if(j>=16)
                     Yazi2[j-16] = gelenYazi[j];   
               }

               printf(lcd_putc,"\f");
               lcd_gotoxy(1,1);
               printf(lcd_putc,Yazi1);
               lcd_gotoxy(1,2);
               printf(lcd_putc,Yazi2);
            }
            
            else if(denetim=='3')
            {        
               
               sicaklikOku();
               
               spi_write(ondalik);
               
               while(!spi_data_is_in());
               gelenVeri = spi_read();
               
               spi_write(tam);
               
            }
         }
   }

}
