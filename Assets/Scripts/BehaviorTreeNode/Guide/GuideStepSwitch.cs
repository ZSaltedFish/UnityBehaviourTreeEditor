using System;

namespace Model
{
    [Node(NodeClassifyType.Decorator, "新手引导步骤选择器")]
    public class GuideStepSwitch : Node
    {
        public GuideStepSwitch(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            try
            {
                //NumericComponent num = SceneHelper.Scene.GetComponent<NumericComponent>();
                //int step = GuideComponent.Instance.CurGuideStep % GuideComponent.STEP_NUMBER;
                //children[step].DoRun(behaviorTree, env);
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
