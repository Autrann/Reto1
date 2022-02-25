using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETO
{
	public class LinkedList
	{
		private Node head;
		private Node tail;
		private int size;

		public virtual void addAtTail(string data)
		{
			Node node = new Node(data);

			if (size == 0)
			{
				head = node;
			}
			else
			{
				tail.next = node;
				node.previous = tail;
			}

			tail = node;
			size++;
		}

		public virtual void addAtFront(string data)
		{
			Node node = new Node(data);

			if (size == 0)
			{
				tail = node;
			}
			else
			{
				head.previous = node;
			}
			node.next = head;
			head = node;

			size++;
		}

		public virtual void remove(int index)
		{
			Node node = findNode(index);

			if (node == null)
			{
				return;
			}

			if (size == 1)
			{
				head = null;
				tail = null;
			}
			else if (node == head)
			{
				head = node.next;
				if (head != null)
				{
					head.previous = null;
				}
			}
			else if (node == tail)
			{
				tail = node.previous;
				if (tail != null)
				{
					tail.next = null;
				}
			}
			else
			{
				node.previous.next = node.next;
				node.next.previous = node.previous;
			}
			size--;
		}

		public virtual void removeAll()
		{
			head = null;
			tail = null;
			size = 0;
		}

		public virtual void setAt(int index, string data)
		{
			Node node = findNode(index);

			if (node != null)
			{
				node.data = data;
			}
		}

		/// <param name="index"> 0-index </param>
		/// <returns> element at position index </returns>
		public virtual string getAt(int index)
		{
			Node node = findNode(index);

			return node == null ? null : node.data;
		}

		public virtual LinkedListIterator Iterator
		{
			get
			{
				return new LinkedListIterator(head);
			}
		}

		public virtual int Size
		{
			get
			{
				return size;
			}
		}

		private Node findNode(int index)
		{

			if (index < 0 || index >= size)
			{
				return null;
			}

			Node node = head;
			int currentIndex = 0;

			while (currentIndex != index)
			{
				currentIndex++;
				node = node.next;
			}

			return node;
		}
	}
}
