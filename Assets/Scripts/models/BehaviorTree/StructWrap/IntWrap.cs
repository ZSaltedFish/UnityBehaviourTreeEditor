using UnityEngine;

namespace Model
{
	public class IntWrapAwakeSystem
	{
	}

	public class IntWrap: Component, IValue<int>
	{
		private int value;

		public void Awake(int v)
		{
			this.value = v;
		}

		public int Value()
		{
			return value;
		}
	}
}
