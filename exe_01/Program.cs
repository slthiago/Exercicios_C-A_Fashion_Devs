using System;

namespace exe_01
{
	class Program
	{

		static void Main(string[] args)
		{
			double peso, altura, imc;
			Program program = new Program();

			do
			{
				Console.WriteLine("### Seja bem vindo(a) a calculadora de IMC ###");
				Console.Write("Informe o seu peso em kg: ");
				peso = Convert.ToDouble(Console.ReadLine());
				Console.Write("Informe a sua altura em cm: ");
				altura = Convert.ToDouble(Console.ReadLine());

				if (peso <= 0 || altura <= 0)
				{
					Console.WriteLine("### Peso e altura precisam ser maiores que zero. Tente novamente! ### \n\n");
				}

			} while (peso <= 0 || altura <= 0);

			imc = program.calculoIMC(peso, altura);

			Console.WriteLine("Seu IMC é: {0}", Math.Round(imc, 2));

			if (imc < 20)
			{
				Console.WriteLine("Abaixo do peso!");
			}
			else if (imc >= 20 && imc < 25)
			{
				Console.WriteLine("Peso ideal!");
			}
			else if (imc >= 25)
			{
				Console.WriteLine("Acima do peso!");
			}
		}

		public double calculoIMC(double peso, double altura)
		{
			return (peso / (Math.Pow((altura / 100), 2)));
		}


	}
}
