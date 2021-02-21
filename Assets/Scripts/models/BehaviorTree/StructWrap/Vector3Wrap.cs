using UnityEngine;

namespace Model
{
	public class Vector3WrapAwakeSystem
	{
	}

	public class Vector3Wrap: Component, IValue<Vector3>
	{
		private Vector3 value;

		public void Awake(Vector3 v)
		{
			this.value = v;
		}

		public Vector3 Value()
		{
			return value;
		}
	}
}
