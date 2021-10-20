using System;

namespace ExerciciosGama
{
	class Peixe : Animal
	{
		//construtor
		public Peixe(string nome, string tipo, string tutor, string registro)
		{
			this.setNome(nome);
			this.setTipo(tipo);
			this.setTutor(tutor);
			this.setRegistro(registro);
		}
	}

}