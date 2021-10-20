using System;

namespace ExerciciosGama
{
	class Cachorro : Animal
	{
		//construtor
		public Cachorro(string nome, string tipo, string tutor, string registro)
		{
			this.setNome(nome);
			this.setTipo(tipo);
			this.setTutor(tutor);
			this.setRegistro(registro);
		}
	}

}