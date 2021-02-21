namespace Model
{
    [Node(NodeClassifyType.Action, "还原材质球")]
    public class RestoreMaterial : Node
    {
        [NodeInput("需求BUFF", typeof(Buff))]
        public string SrcBuff;

        public RestoreMaterial(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Buff buff = env.Get<Buff>(SrcBuff);
            //Unit target = buff.Target;
            //UnitMaterialComponent comp = target.GetComponent<UnitMaterialComponent>();
            //comp.RemoveMaterial(buff.Id);
            return true;
        }
    }
}
