using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //necesario para la pausa


namespace reloj_en_consola
{
    class Program
    {
        int seg = 0;       
        int min = 0;       
        int hor = 0;      
        private void timer1_Tick(object sender, EventArgs e)
        {           
            if (min == 61)            
            {            
                hor += 1;
                    min = 0;  
            }            
            if (seg == 61)
            {             
                min += 1;                
                seg = 0;           
            }
            seg += 1;         
                System.Console.WriteLine(hor.ToString() + ":" + min.ToString() + ":" + seg.ToString());    
        }
        static void Main(string[] args)
        {
            Console.Clear(); //limpia la consola
            Console.WriteLine(DateTime.Now); //imprime la fecha y hora actual del sistema
            Thread.Sleep(1000); //genera una pausa en el programa de 
        }
    }
}
