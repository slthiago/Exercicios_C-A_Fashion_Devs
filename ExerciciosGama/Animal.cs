using System;

namespace ExerciciosGama
{
	public abstract class Animal
	{
		public string nome;
		public string tipo;
		protected string tutor;
		protected string registro;

		public void setNome(string nome)
		{
			this.nome = nome;
		}
		public void setTipo(string tipo)
		{
			this.tipo = tipo;
		}
		public void setTutor(string tutor)
		{
			this.tutor = tutor;
		}
		public void setRegistro(string registro)
		{
			this.registro = registro;
		}
		public string getNome()
		{
			return this.nome;
		}
		public string getTipo()
		{
			return this.tipo;
		}
		public string getTutor()
		{
			return this.tutor;
		}
		public string getRegistro()
		{
			return this.registro;
		}

	}

}