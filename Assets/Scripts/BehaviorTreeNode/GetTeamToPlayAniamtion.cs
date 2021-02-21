using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public enum TeamType
    {
        TeamMate,
        Enemy
    }

    [Node(NodeClassifyType.Action, "获取一方球员，播放指定动作")]
    public class GetTeamToPlayAniamtion : Node
    {
        [NodeField("指定的队伍", TeamType.TeamMate)]
        public TeamType AcceptTeamType;
        [NodeField("动作名称", "")]
        public string Animation;

        public GetTeamToPlayAniamtion(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Actor[] actors = ActorHelper.GetAllActor();
            //Actor myActor = ActorHelper.MyActor();

            //List<Unit> unitIds = new List<Unit>();
            //foreach (Actor actor in actors)
            //{
            //    switch (AcceptTeamType)
            //    {
            //        case TeamType.Enemy:
            //            if (myActor.Team != actor.Team)
            //            {
            //                foreach (Unit unit in actor.GetAll())
            //                {
            //                    unitIds.Add(unit);
            //                }
            //            }
            //            break;
            //        case TeamType.TeamMate:
            //            if (myActor.Team == actor.Team)
            //            {
            //                foreach (Unit unit in actor.GetAll())
            //                {
            //                    unitIds.Add(unit);
            //                }
            //            }
            //            break;
            //    }
            //}

            //foreach (Unit unit in unitIds)
            //{
            //    unit.GetComponent<AnimatorComponent>().SetTrigger(Animation);
            //}

            return true;
        }
    }
}
