using System;

namespace exe_03
{
	class Program
	{
		static void Main(string[] args)
		{
			double raio, volume;
			Program program = new Program();

			do
			{
				Console.WriteLine("### Seja bem vindo(a) ao programa de cálculo de volume de esfera! ###");
				Console.Write("Informe o raio da esfera em metros: ");
				raio = Convert.ToDouble(Console.ReadLine());
				if (raio <= 0)
				{
					Console.WriteLine("### Raio precisa ser maior que zero. Informe o raio novamente. ### \n");
				}
			} while (raio <= 0);


			volume = program.calculoVolume(raio);

			Console.WriteLine("O volume da esfera com raio {0} é de: {1} metros³.", raio, Math.Round(volume, 2));
		}

		public double calculoVolume(double raio)
		{
			//verificar cálculo
			return (4 * 3.14 * (Math.Pow(raio, 3)) / 3);
		}
	}
}
