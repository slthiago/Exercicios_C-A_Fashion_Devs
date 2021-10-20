using System;
using System.Collections.Generic;

namespace ExerciciosGama
{
	class Program
	{

		static void Main(string[] args)
		{
			int opcao;

			do
			{
				Console.Write("### Exercício C# - C&A Fashion Devs: ###\n" +
				"1 - Calculadora de IMC\n" +
				"2 - Cálculo de salário\n" +
				"3 - Cálculo de volume de esfera\n" +
				"4 - Cáculo de média de notas\n" +
				"5 - Animais de estimação\n" +
				"Escolha uma opção: ");

				opcao = Convert.ToInt32(Console.ReadLine());

				if (opcao < 1 || opcao > 5)
				{
					Console.WriteLine("\n*** Opção inválida! Por favor, tente novamente. ***\n");
				}

			} while (opcao < 1 || opcao > 5);



			switch (opcao)
			{
				case 1:
					double imc = exe_01();
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
					break;
				case 2:
					double salario, resultado;
					resultado = exe_02(out salario);
					Console.WriteLine("R${0} é equivalente a {1} salários mínimos.", salario, Math.Round(resultado, 3));
					break;
				case 3:
					double raio, volume;
					volume = exe_03(out raio);
					Console.WriteLine("O volume da esfera com raio {0} é de: {1} metros³.", raio, Math.Round(volume, 2));
					break;
				case 4:
					exe_04();
					break;
				case 5:
					exe_05();
					break;

			}

		}

		/* #######		EXERCÍCIO 01		####### */
		public static double exe_01()
		{
			double peso, altura, imc;

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

			imc = calculoIMC(peso, altura);


			return imc;

		}
		//metodo calcula o imc e retorna para o método exe_01
		public static double calculoIMC(double peso, double altura)
		{
			return (peso / ((altura / 100) * 2));
		}

		/* #######		EXERCÍCIO 02		####### */
		public const double salarioMinimo = 1100;
		public static double exe_02(out double salario)
		{
			double resultado;

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


			return (resultado = calculoSalario(salario, salarioMinimo));


		}
		public static double calculoSalario(double salario, double salarioMinimo)
		{
			return (salario / salarioMinimo);
		}

		/* #######		EXERCÍCIO 03		####### */
		public static double exe_03(out double raio)
		{
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

			return calculoVolume(raio);
		}
		public static double calculoVolume(double raio)
		{
			return (4 * Math.PI * (Math.Pow(raio, 3)) / 3);
		}

		/* #######		EXERCÍCIO 04		####### */
		public static void exe_04()
		{
			//declaração de array para receber notas
			double[] notas = new double[3];
			double media, exame = 0, resultado;

			Console.WriteLine("Informe as 3 notas do aluno:");
			//laço para percorrer o array preenchendo as notas do aluno
			for (int i = 0; i < 3; i++)
			{
				//laço testa e execulta enquanto a nota for menor que 0 ou maior que 10
				do
				{
					Console.Write("Informe a {0}ª nota: ", i + 1);
					notas[i] = Convert.ToDouble(Console.ReadLine());

					if (notas[i] < 0 || notas[i] > 10)
					{
						Console.WriteLine("A nota deve ser entre 0 a 10. Por favor, informe a {0}ª nota novamente!", i + 1);
					}
				} while (notas[i] < 0 || notas[i] > 10);

			}
			//media recebe o resultado do calculo feito no método calculaMedia
			media = calculaMedia(notas);

			//condicional testa resultado da média e imprime aprovado caso média >= 7
			if (media >= 7)
			{
				Console.WriteLine("Média: {0} ### APROVADO!", media);
			}
			//se média < 7, else executa bloco que pede a nota de exame e chama método que calcula nova média
			else
			{
				//laço testa e execulta enquanto a nota do exame for menor que 0 ou maior que 10
				do
				{
					Console.Write("Informe a nota de exame do aluno: ");
					exame = Convert.ToDouble(Console.ReadLine());

					if (exame < 0 || exame > 10)
					{
						Console.WriteLine("A nota do exame deve ser entre 0 a 10. Por favor, informe a nota novamente!");
					}
				} while (exame < 0 || exame > 10);

				resultado = calculaMediaExame(media, exame);

				if (resultado >= 5)
				{
					Console.WriteLine("Média: {0} ### APROVADO EM EXAME!", resultado);
				}
				else
				{
					Console.WriteLine("Média com exame: {0} ### REPROVADO!", resultado);
				}

			}
		}

		public static double calculaMedia(double[] notas)
		{
			double soma = 0;
			for (int i = 0; i < 3; i++)
			{
				soma += notas[i];
			}
			return Math.Round((soma / 3), 2);
		}

		public static double calculaMediaExame(double media, double exame)
		{
			return Math.Round(((media + exame) / 2), 2);
		}

		/* #######		EXERCÍCIO 05		####### */
		public static void exe_05()
		{
			List<Animal> animais = new List<Animal>();
			int num_cachorros = 0;
			int num_gatos = 0;
			int num_peixes = 0;

			for (int i = 0; i < 5; i++)
			{
				Console.Write("### Tipos de animais ###\n" +
				"01 -  Cachorro\n" +
				"02 -  Gato\n" +
				"03 -  Peixe\n" +
				"Digite o nome do tipo do animal {0}: ", i + 1);
				string tipo = Console.ReadLine();

				if (tipo != "cachorro" && tipo != "gato" && tipo != "peixe")
				{
					Console.WriteLine("\n*** Tipo inválido. O tipo Peixe foi atribuído automaticamente. ***\n");
				}

				Console.Write("Informe o nome do animal {0}: ", i + 1);
				string nome = Console.ReadLine();

				Console.Write("Informe o nome do tutor do animal {0}: ", i + 1);
				string tutor = Console.ReadLine();

				Console.Write("Informe o registro do animal {0}: ", i + 1);
				string registro = Console.ReadLine();

				switch (tipo)
				{
					case "cachorro":
						Cachorro cachorro = new Cachorro(nome, tipo, tutor, registro);
						animais.Add(cachorro);
						break;
					case "gato":
						Gato gato = new Gato(nome, tipo, tutor, registro);
						animais.Add(gato);
						break;
					case "peixe":
						Peixe peixe = new Peixe(nome, tipo, tutor, registro);
						animais.Add(peixe);
						break;
					default:
						Peixe peixe_default = new Peixe(nome, tipo, tutor, registro);
						animais.Add(peixe_default);
						break;
				}
			}

			foreach (Animal animal in animais)
			{
				if (animal.getTipo() == "cachorro")
				{
					num_cachorros++;
				}
				else if (animal.getTipo() == "gato")
				{
					num_gatos++;
				}
				else if (animal.getTipo() == "peixe")
				{
					num_peixes++;
				}
				else
				{
					num_peixes++;
				}
			}

			Console.WriteLine("\nForam informados 5 animais:");
			Console.WriteLine("{0} Cachorros", num_cachorros);
			Console.WriteLine("{0} Gatos", num_gatos);
			Console.WriteLine("{0} Peixes", num_peixes);

		}

	}
}
