using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETO
{
	public class Node
	{ 
		internal string data;
		internal Node next;
		internal Node previous;

		internal Node(string data)
		{
			this.data = data;
		}
	}
}
