using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryKomutu
{
	internal class MyDictionary<K,V>
	{
		K[] keys;
		V[] values;

		public MyDictionary()
		{
			keys = new K[0];
			values = new V[0];
		}
		public void Add(K key, V value)
		{
			K[] tempArrayKey = keys;
			V[] tempArrayValue = values;

			keys = new K[keys.Length + 1];
			values = new V[values.Length + 1];

			for (int i = 0; i < tempArrayKey.Length; i++)
			{
				keys[i] = tempArrayKey[i];
			}
			keys[keys.Length - 1] = key;
			for (int i = 0; i < tempArrayValue.Length; i++)
			{
				values[i] = tempArrayValue[i];
			}
			values[values.Length - 1] = value;
		}

		public K[] Keys
		{
			get { return keys; }
		}
		public V[] Values
		{
			get
			{
				return values;
			}
		}
	}
}
