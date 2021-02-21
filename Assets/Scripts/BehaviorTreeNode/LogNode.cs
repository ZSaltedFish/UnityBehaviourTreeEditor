using System;

namespace Model
{
    [Node(NodeClassifyType.Action, "打印")]
    public class LogNode : Node
    {
        [NodeField("数据")]
        public string LogData;

        public LogNode(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
#if UNITY_EDITOR
	        Log.Debug(LogData);
#endif
			return true;
        }
    }
}
