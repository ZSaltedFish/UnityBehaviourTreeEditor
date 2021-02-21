using UnityEngine;

namespace Model
{
	public interface IValue<out T>
	{
		T Value();
	}
}
