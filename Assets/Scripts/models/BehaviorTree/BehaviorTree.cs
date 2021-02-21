using System;
using System.Collections.Generic;

namespace Model
{
	public class BehaviorTree
	{
		public long Id;
		public int GameObjectId;
		public List<long> PathList = new List<long>();
		private readonly Node node;

		public string Discription { get; }

		public BehaviorTree(long id, Node node, string name)
		{
            Id = id;
	 		this.node = node;
            Discription = name;
		}

		public bool Run(BTEnv env)
		{
			try
			{
				this.PathList.Clear();
				env.Add(BTEnvKey.NodePath, this.PathList);
				bool ret = this.node.DoRun(this, env);
				//Game.EventSystem.Run(EventIdType.BehaviorTreeRunTreeEvent, this);
				return ret;
			}
			catch (Exception e)
			{
				string source = env.Get<string>(BTEnvKey.BTSource) ?? "";
				Log.Error($"树运行出错, 树名: {this.Discription} 来源: {source}" + e);
				return false;
			}
		}
	}
}