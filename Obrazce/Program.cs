using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stvorec stvorec = new Stvorec(4.2);
            //Console.WriteLine("Obsah stvorca: {0}",stvorec.VypocitajObsah());

            //Stvorec stvorec2 = new Stvorec(4.2);

            //Console.WriteLine("Porovnanie {0}", Stvorec.Porovnaj(stvorec, stvorec2));
            
            

            //Obrazec kruh = new Kruh(3.4); //ked zmenime Obrazec na Kruh tak pomocou . mame ine funkcionality
            
            //Console.WriteLine("Obsah kruhu: {0}", kruh.VypocitajObsah());
            
            

            //IKreslenie k = stvorec2;
            //IKreslenie k1 = new Kruh(10.2);
            //k.Vykresli();
            //k1.Vytlac();

            Kruh kruh1 = new Kruh(3);
            IZmenRozmer zmenaKruhu = kruh1;
            zmenaKruhu.ZmenRozmer(1);
            Console.WriteLine("Obsah je: {0}",kruh1.VypocitajObsah()); 

            Stvorec stvorec3 = new Stvorec(4);
            IZmenRozmer zmenaStvorca = stvorec3;
            zmenaStvorca.ZmenRozmer(2);
            Console.WriteLine("Obsah je: {0}",stvorec3.VypocitajObsah()); 



            Console.ReadKey();
        }
    }
}
