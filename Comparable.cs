﻿using System;

namespace Clase_5
{
	public interface Comparable
	{
		bool sosIgual(Comparable c);
		bool sosMenor(Comparable c);
		bool sosMayor(Comparable c);
		string toString();
	}
}
