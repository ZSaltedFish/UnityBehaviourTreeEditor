namespace Model
{
    [Node(NodeClassifyType.Condition, "我方比分减去敌方比分")]
    public class ScoreCompare : Node
    {
        [NodeOutput("result", typeof(int))]
        public string ResultKey;
        
        public ScoreCompare(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //NumericComponent nComp = SceneHelper.Scene.GetComponent<NumericComponent>();
            //int myScore = nComp.GetAsInt(NumericType.client_my_team_score);
            //int enemyScore = nComp.GetAsInt(NumericType.client_enemy_team_score);
            //env.Add(this.ResultKey, myScore - enemyScore);
            return true;
        }
    }
}
