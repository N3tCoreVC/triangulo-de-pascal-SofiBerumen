using System;

namespace triangulo_de_pascal_SofiBerumen
{
    class Program
    {
        static void Main(string[] args)
        {
            int lin;
            
            Console.WriteLine("Dame base: ");
            int.TryParse(Console.ReadLine(), out lin);
            lin+=2;
            int[,] tri = new int[lin,lin];
            
            for(int i=2; i<lin; i++){
                for(int j=1; j<lin; j++){
                    if(j==0 || j==i){
                        tri[i,j]=1;
                    }else{
                        tri[i,j]=tri[i-1, j-1]+tri[i-1,j];
                    }
                }
                
            }

            //IMPRIMIR
            for(int i=0; i<lin; i++){
                for(int j=2; j<=i; j++){
                    Console.Write(tri[i,j]+"  ");
                }
                Console.Write("\n");
            }
        }
    }
}
