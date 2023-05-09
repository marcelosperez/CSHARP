



namespace Curso{

   class Programa {
      
	 static void Main (string[ ] args) {
      
	 double larg, alt;
	
     Retangulo retangulo = new Retangulo();
    
	 Console.Write("Digite a largura: ");
	 larg = double.Parse(Console.ReadLine() );
	 retangulo.SetLargura(larg);
    
	 Console.Write("Digite a altura: ");
	 alt = double.Parse(Console.ReadLine() );	
	 retangulo.SetAltura(alt);
    
	 Console.WriteLine("A largura eh: " + retangulo.GetLargura() );
    
     Console.WriteLine(" "); // blank line
	 
     Console.WriteLine("A altura eh: " + retangulo.GetAltura() );
    
     Console.WriteLine(" "); // blank line
   
     }
   }
}