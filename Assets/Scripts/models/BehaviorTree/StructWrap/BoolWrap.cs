using UnityEngine;

namespace Model
{
	public class BoolWrapAwakeSystem 
	{
	}

	public class BoolWrap: Component, IValue<bool>
	{
		private bool value;

		public void Awake(bool v)
		{
			this.value = v;
		}

		public bool Value()
		{
			return value;
		}
	}
}
