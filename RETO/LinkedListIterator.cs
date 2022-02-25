using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETO
{
	public class LinkedListIterator
	{

		private Node currentNode;

		internal LinkedListIterator(Node startNode)
		{
			currentNode = startNode;
		}

		public virtual bool hasNext()
		{
			return currentNode != null;
		}

		public virtual string next()
		{
			string data = currentNode.data;

			currentNode = currentNode.next;

			return data;
		}
	}
}
