using UnityEngine;

namespace Server
{
    public class BaseType { }
    public class Vector3 : BaseType { }
    public class Object : BaseType { }
    public class Table : BaseType { }
    public class Actor : Object { }
    public class Unit : Object { }
    public class Ball : Object { }
    public class Goal : Object { }
    public class Spell : BaseType { }
    public class Skill : Spell { }
    public class Buff : Spell { }
    public class Args { }
    public class List { }

    public enum eForceReturn
    {
        None,
        True,
        False,
    }

    public enum eGameStatus
    {
        Init, //初始化
        Mate, //匹配准备阶段
        Sel, //选英雄阶段
        Load, //客户端加载阶段
        Play,//播放
        CD,//准备开球
        Run,//比赛阶段
        Extra,//加时阶段
        End //结算阶段
    }

    public enum eOperator
    {
        GT, // >
        GE, // >=
        LT, // <
        LE, // <=
        EQ, // ==
        NOT // !=
    }

    public enum eGoalType
    {
        None,
        Offensive,//进攻
        Defence,//防守
        Friend,//我方
        Enemy//敌方
    }

    public enum eAttr
    {
        cd_rob,//(unit,ball)球不可被抢

        //pass_target,//(ball)传球目标ID, 0为没有传球目标(设置后队友不会来抢球)
        owner_id,//(ball)控制者ID
        //direct_shoot, //(ball)直接进门(必杀)
        is_shoot,//(ball)是否射门
        cant_stop,//(ball)不能被停止(必杀)
        is_fly,//(ball)是否空中球
        is_roll,//(ball)地面球，处于滚地阶段
        run_catch, //(ball) 直塞球，传球目标跑去接球

        self_id,//(unit)本id
        ball_id,//(unit)控球id
        area_position,//(unit)场上位置(前中后卫)
        group_id,//(unit)组ID,P1 or P2
        is_move, //(unit)是否移动中
        run_flag,//(unit)执行行为树标志 0不执行,1为执行

        //skill_on, //(unit) 是否施放技能中
        // burstspeed, //--unit 爆发速度

        fix_speed, //--unit 固定速度
        haste, //--unit 加速值(实际做用)
        mul_speed,//--unit 速度加成
        lock_face,//unit 球员移动锁方向
        anger,//unit 必杀技怒气值
        god,//unit 无敌状态
        across,//unit 穿越(技能用，穿越人)
        is_follow,//unit 是否盯人
        no_action,//unit 不可发操作指令(可移动)

        finial_score,//actor 必杀分数
        ai_offen_defen_statue, //攻防转换状态
        ai_role,
    }

    public enum eSkillAttr
    {
        finial_consume,//必杀消耗
        ball_owner,//是否需要控球(0不限，1是,2否)
        hit_type,//攻击类型 1踉跄，2击倒，3击飞，4浮空
        hit_body,//攻击身体位置 1头，2胸，3腰，4腿
        hit_effect,//攻击特效 1拳脚，2钝器，3利器，4能量
        auto_aim_dis,//辅助瞄准(距离,0不自动)
        auto_aim_ang,//辅助瞄准(角度,0不自动)
    }

    public enum eUAction
    {
        //Sway,
        Shoot,//射门
        Rob,//抢球
        PassPos,//传球到位置
        PassDir,//传球到方向
        PassTarget,//传球到球员
        NoticeSpeed,//通知速度变更
    }

    public enum eOperType
    {
        None,
        NoZero, //非零
        Shoot,  //射门
        Pass,   //传球
        Trace,  //追球
        Tech,  //技巧
        Sneer, //嘲讽
        Tackle, //铲球
        Final //必杀
    }

    public enum eSkillBase
    {
        skill_pass,
        skill_air_pass,
        skill_shoot,
        skill_shootmove,
        skill_runshoot,
        skill_air_shoot,
        skill_rob,
        skill_capture,
        skill_capture_left,
        skill_capture_right,
        skill_jump_left,
        skill_jump_right,
        skill_air_capture,
        skill_cross,
        skill_tackle,
        skill_final,
        //skill_turn_left,
        //skill_turn_right,
        //skill_turn_back_left,
        //skill_turn_back_right,
        skill_dodge,
        //skill_push,
        skill_striked, //被撞击
        skill_panic, //踉跄
        skill_float, //浮空
        skill_flown, //击飞
    }

    //1射门，2传球, 3换人, 4技巧(进攻), 5技巧(防守), 6盯防(抢球) ,7必杀
    public enum eButtonCD
    {
        SHOOT,// --射门 1
        PASS, //--传球 2
        SWITCH, //--铲球 3
        TECH_ATK, //--技巧进攻 4
        TECH_DEF, //--技巧防守 5
        RAB,// 抢球
        FINIAL,//必杀

    }

    //AIbuff类型
    public enum eAIBuff
    {
        a_strategy_time,//进攻策略时间
        d_strategy_time,//防守策略时间
        a_to_d_time, //由转攻守响应时间
        d_to_a_time,//由守转攻响应时间
        a_move_time, //进攻跑位调整响应时间
        d_move_time, //防守跑位调整响应时间
        move_ball_time,//带球变向响应时间
        use_skill_time,//使用技能反射时间
        cd_tackle, //铲球cd
        cd_rob,// 抢球cd
        cd_pass, //传球cd
        cd_start_ball //开球cd
    }

    //AI属性类型
    public enum eAIAttr
    {
      
        push_dis, //前插距离
        dis_to_egoal, //离对方球门的距离
        dis_to_baller, //无球人和带球人之间的距离
        defence_dis ,//盯防范围
        longshoot_dis, //远射距离
        skill_dis, //技能触发范围
        pass_rate, //传球频率
        shoot_rate, //射门频率
        skill_rate, //技能施放频率
        defence_rate ,//盯防频率
        tackle_rate, //铲球频率
        rob_rate, //抢球频率
        surround_num, //围抢球员人数
        is_final, //必杀技开关
        is_skill_card, //能卡技能开关
        is_can_skill, //是否使用放技能
    }

   
}
                              
