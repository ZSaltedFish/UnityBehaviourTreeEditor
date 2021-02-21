using System.Collections.Generic;

namespace Model
{
	[Node(NodeClassifyType.Composite, "资源包节点,用来配置需要下载的资源包")]
	public class AssetBundleName: Node
	{
		[NodeInput("资源包key", typeof(List<string>))]
		public string assetBundleNameListKey = BTEnvKey.AssetBundleNameListKey;

		[NodeField("资源包名")]
		private string assetBundleName;
        

        public AssetBundleName(NodeProto nodeProto): base(nodeProto)
		{
		}

		protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
		{
            List<string> assetBundleNameList = env.Get<List<string>>(assetBundleNameListKey);
			this.assetBundleName = this.assetBundleName.Trim();
			if (this.assetBundleName != "")
			{
				assetBundleNameList.Add(this.assetBundleName);
			}

			foreach (Node child in this.children)
			{
				child.DoRun(behaviorTree, env);
			}
			return true;
		}
	}
}