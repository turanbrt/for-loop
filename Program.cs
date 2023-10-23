namespace for_loop;

class Program
{
    static void Main(string[] args)
    {   

        
        //loop and if 

        //Verilen inputa kadar olan tek sayıları ekrana yazdıram program
        /*
        Console.WriteLine("***İF***");
        Console.WriteLine("bir değer giriniz");
        int sayac=int.Parse(Console.ReadLine());
        for(int i=1; i<=sayac; i++){
            if(i%2==1)  Console.WriteLine(i);
        }

        //1-1000 arasındaki tek ve çift sayıların toplamını konsola yazdıran program

        int tek=0,cift=0;
        for(int i=0;    i<1000; i++){
            if(i%2==0){
            tek=tek+i;
            }else{
                cift=cift+i;
            }
       
        }
        Console.WriteLine("Tek sayiların toplamı="+tek);
        Console.WriteLine("Cift sayiların toplamı="+cift);

        */
        //break: continue:

        for(int i=1;    i<=10; i++){
            if(i==4) {
                break;
            }   
            Console.WriteLine(i);
        }
           for(int i=1;    i<=10; i++){
            if(i==4) {
                continue;
            }   
            Console.WriteLine(i);
        }

    }
}
