using System; 

class Classe {

    static void Main(string[] args)
    {

      //insira o calculo da area de acordo com o solicitado
      double pi = 3.14159, r;
      r = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine("A=" + (pi * (r * r)).ToString("0.0000"));
      Console.ReadKey();
      
    }


}
