using System;

namespace Model
{
    [Node(NodeClassifyType.Decorator, "引导步骤初始化")]
    public class GuideStepInit : Node
    {
        public GuideStepInit(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            try
            {
                //if (GuideComponent.Instance.IsInit)
                //{
                //    GuideComponent.Instance.IsInit = false;
                //    foreach (var item in children)
                //    {
                //        if (!item.DoRun(behaviorTree, env))
                //        {
                //            return false;
                //        }
                //    }
                //}
                return true;
            }
            catch(Exception err)
            {
                Log.Error(err);
                return false;
            }
        }
    }
}
