using System;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
	public class BTEnv: Component
	{
		public Dictionary<string, object> Values
		{
			get
			{
				return values;
			}
		}

		public readonly Dictionary<string, object> values = new Dictionary<string, object>();

		public readonly HashSet<Component> disposers = new HashSet<Component>();

		public void CopyTo(BTEnv env)
		{
			foreach (KeyValuePair<string, object> keyValuePair in this.values)
			{
				env.values.Add(keyValuePair.Key, keyValuePair.Value);
			}

			foreach (Component disposer in this.disposers)
			{
				env.disposers.Add(disposer);
			}
		}

		public T Get<T>(string key)
		{
			if (!this.values.ContainsKey(key))
			{
				return default(T);
			}
			
			object value = values[key];
			try
			{
				if (typeof (T).IsClass)
				{
					return (T) value;
				}

				IValue<T> iValue = (IValue<T>) value;
				return iValue.Value();
			}
			catch (InvalidCastException e)
			{
				throw new Exception($"不能把{value.GetType()}转换为{typeof (T)}", e);
			}
 		}
		
		public bool ContainKey(string key)
		{
			return this.values.ContainsKey(key);
		}

		public void Add(string key, object value)
		{
			if (value is bool)
			{
				throw new Exception("请使用AddBool添加到env，避免gc");
			}
			this.values[key] = value;
		}
	}
}