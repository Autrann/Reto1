using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RETO
{


	public class ArrayList
	{
		private const int DEFAULT_SIZE = 2;
		private string[] array;
		private int size;

		public ArrayList()
		{
			array = new string[DEFAULT_SIZE];
		}

		public ArrayList(int size)
		{
			array = new string[size];
		}

		public virtual void addAtTail(string data)
		{
			if (size == array.Length)
			{
				increaseArraySize();
			}

			array[size] = data;
			size++;
		}

		public virtual void addAtFront(string data)
		{
			if (size == array.Length)
			{
				increaseArraySize();
			}

			if (size >= 0)
			{
				Array.Copy(array, 0, array, 1, size);
			}
			array[0] = data;
			size++;
		}

		public virtual void remove(int index)
		{

			if (index < 0 || index >= size)
			{
				return;
			}

			if (size - 1 - index >= 0)
			{
				Array.Copy(array, index + 1, array, index, size - 1 - index);
			}
			array[size - 1] = null;
			size--;
		}

		public virtual void removeAll()
		{
			for (int i = 0; i < size; i++)
			{
				array[i] = null;
			}
			size = 0;
		}

		public virtual void setAt(int index, string data)
		{
			if (index >= 0 && index < size)
			{
				array[index] = data;
			}
		}

		public virtual string getAt(int index)
		{
			return index >= 0 && index < size ? array[index] : null;
		}

		public virtual ArrayListIterator Iterator
		{
			get
			{
				return new ArrayListIterator(this);
			}
		}

		public virtual int Size
		{
			get
			{
				return size;
			}
		}


		private void increaseArraySize()
		{
			string[] newArray = new string[array.Length * 2];

			if (size >= 0)
			{
				Array.Copy(array, 0, newArray, 0, size);
			}

			array = newArray;
		}

	}

}
