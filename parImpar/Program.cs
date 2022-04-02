int numeroDigitado;

Console.Write("Digite um número: ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

bool numeroEhPar = (numeroDigitado % 2) == 0;

if (numeroEhPar)

{
   Console.WriteLine($"{numeroDigitado} é par");
}

else

{
   Console.WriteLine($"{numeroDigitado} é impar");
}
   