using System;

namespace Clase_5
{
	public interface Observado
	{
		void agregraObservador(Observador o);
		void quitarObsevador(Observador o);
		void notificar();
	}
}
