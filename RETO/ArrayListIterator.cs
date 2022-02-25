using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETO
{

	public class ArrayListIterator
	{

		private ArrayList arrayList;
		private int currentItem;

		public ArrayListIterator(ArrayList arrayList)
		{
			this.arrayList = arrayList;

		}

		public virtual bool hasNext()
		{
			return currentItem < arrayList.Size;
		}

		public virtual string next()
		{
			string data = arrayList.getAt(currentItem);

			currentItem++;

			return data;
		}

	}

}
