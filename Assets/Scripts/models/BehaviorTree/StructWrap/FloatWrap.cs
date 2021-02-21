using UnityEngine;

namespace Model
{
	public class FloatWrapAwakeSystem
	{
	}

	public class FloatWrap: Component, IValue<float>
	{
		private float value;

		public void Awake(float v)
		{
			this.value = v;
		}

		public float Value()
		{
			return value;
		}
	}
}
