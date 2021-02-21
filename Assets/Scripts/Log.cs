using System;

namespace Model
{
	public static class Log
	{
		public static void Warning(string msg)
		{
			UnityEngine.Debug.LogWarning(msg);
		}

		public static void Info(string msg)
		{
			UnityEngine.Debug.Log(msg);
		}
		
		public static void Error(string msg)
		{
			UnityEngine.Debug.LogError(msg);
		}

		public static void Error(Exception e)
		{
			UnityEngine.Debug.LogError(e.ToString());
		}

		public static void Debug(string msg)
		{
#if UNITY_EDITOR || DEVELOPMENT_BUILD
			UnityEngine.Debug.Log(msg);
#endif
		}

		public static void Object(object message)
		{
		}

		public static void Msg(object message, ushort opcode)
		{
#if UNITY_EDITOR
#endif
		}
	}
}