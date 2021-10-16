using System;

namespace exe_02
{
	class Program
	{
		static void Main(string[] args)
		{
			double salario, resultado;
			Program program = new Program();

			do
			{
				Console.WriteLine("### Seja bem vindo(a) a calculadora de salários mínimos! ###");
				Console.Write("Informe o seu salário: ");
				salario = Convert.ToDouble(Console.ReadLine());
				if (salario <= 0)
				{
					Console.WriteLine("### Salário precisa ser maior que zero. Informe o salário novamente. ### \n");
				}
			} while (salario <= 0);


			resultado = program.calculoSalario(salario);

			Console.WriteLine("R${0} é equivalente a {1} salários mínimos.", salario, Math.Round(resultado, 1));
		}

		public double calculoSalario(double salario)
		{
			return (salario / 1100);
		}
	}
}
