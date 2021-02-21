using UnityEngine;

namespace Model { 
	public class QuaternionWrapAwakeSystem
	{
	}

	public class QuaternionWrap: Component, IValue<Quaternion>
	{
		private Quaternion value;

		public void Awake(Quaternion v)
		{
			this.value = v;
		}

		public Quaternion Value()
		{
			return value;
		}
	}
}
