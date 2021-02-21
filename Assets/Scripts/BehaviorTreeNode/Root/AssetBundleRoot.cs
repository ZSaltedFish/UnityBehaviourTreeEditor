using System.Collections.Generic;

namespace Model
{
	[Node(NodeClassifyType.Root, "AssetBundle Root")]
	public class AssetBundleRoot : Node
	{
		[NodeOutput("UnitId", typeof(List<string>), BTEnvKey.AssetBundleNameListKey)]
		public string AssetBundleNameListKey;

		public AssetBundleRoot(NodeProto nodeProto): base(nodeProto)
		{
		}

		protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
		{
			foreach (Node child in this.children)
			{
				child.DoRun(behaviorTree, env);
			}
			return true;
		}
	}
}