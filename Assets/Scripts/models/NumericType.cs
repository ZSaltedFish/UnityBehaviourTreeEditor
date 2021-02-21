namespace Model
{
	/// <summary>
	/// 
	/// </summary>
	public enum NumericType
	{
		/// <summary>
		/// -------------用户属性
		/// </summary>

		/// <summary>
		/// 玩家性别
		/// </summary>
		user_sex = 8001,
		/// <summary>
		/// 等级
		/// </summary>
		user_level = 8002,
		/// <summary>
		/// 经验
		/// </summary>
		user_exp = 8003,
		/// <summary>
		/// vip
		/// </summary>
		user_vip = 8004,
		/// <summary>
		/// 金钱
		/// </summary>
		user_money = 8005,
		/// <summary>
		/// 金钱
		/// </summary>
		user_diamon = 8006,
		/// <summary>
		/// 点券
		/// </summary>
		user_ticket = 8007,
		/// <summary>
		/// 昵称
		/// </summary>
		user_nick_name = 8008,
		/// <summary>
		/// 当前段位
		/// </summary>
		user_now_rank = 8101,
		/// <summary>
		/// 段位星星
		/// </summary>
		user_rank_star = 8102,
		/// <summary>
		/// 魅力值
		/// </summary>
		user_charm = 8103,
		/// <summary>
		/// VIP结束时间 (秒)
		/// </summary>
		vip_end_time = 8105,
		/// <summary>
		/// SVIP结束时间 (秒)
		/// </summary>
		svip_end_time = 8106,
		/// <summary>
		/// 玩家状态 1离线 2在线 3游戏中
		/// </summary>
		user_state = 8107,
		/// <summary>
		/// 头像框
		/// </summary>
		user_face_frame = 8108,
		/// <summary>
		/// 最高段位
		/// </summary>
		user_highest_rank = 8109,
		/// <summary>
		/// 成就点数
		/// </summary>
		user_achieve_point = 8110,
		/// <summary>
		/// 最高星数
		/// </summary>
		user_highest_star = 8111,
		/// <summary>
		/// 球员数量
		/// </summary>
		user_hero_num = 8112,
		/// <summary>
		/// 时装数量
		/// </summary>
		user_skin_num = 8113,
		/// <summary>
		/// 新手指引进度
		/// </summary>
		user_guide = 8114,
		/// <summary>
		/// 角色创建时间
		/// </summary>
		user_create_time = 8116,
		/// <summary>
		/// 历史充值金额  默认0
		/// </summary>
		user_history_recharge = 8117,
		/// <summary>
		/// 工会id      默认0
		/// </summary>
		user_party_id = 8118,
		/// <summary>
		/// 球员主形象 默认为3个初始球员中id最小的球员
		/// </summary>
		user_hero_main_image = 8119,
		/// <summary>
		/// 禁言结束时间戳s
		/// </summary>
		user_banned_time = 8120,
		/// <summary>
		/// 封停结束时间戳s
		/// </summary>
		user_closure_time = 8121,
		/// <summary>
		/// 排行榜每日免费赠送次数
		/// </summary>
		give_num_day = 8201,
		/// <summary>
		/// 新手状态标记 0未完成, 1已完成, 2可跳过
		/// </summary>
		guide_flag = 8202,
		/// <summary>
		/// 用户设置
		/// </summary>
		user_options = 8205,
		/// <summary>
		/// 奖励经验
		/// </summary>
		user_add_exp = 8501,
		/// <summary>
		/// 奖励金钱
		/// </summary>
		user_add_money = 8502,
		/// <summary>
		/// user_level_max_exp			= 8503,
		/// </summary>

		/// <summary>
		/// ---------------------------英雄属性
		/// </summary>

		/// <summary>
		/// 球员进攻
		/// </summary>
		hero_attack_v = 9001,
		/// <summary>
		/// 防守
		/// </summary>
		hero_defend_v = 9002,
		/// <summary>
		/// 速度
		/// </summary>
		hero_speed_v = 9003,
		/// <summary>
		/// 力量
		/// </summary>
		hero_power_v = 9004,
		/// <summary>
		/// 技术
		/// </summary>
		hero_skill_v = 9005,
		/// <summary>
		/// 守门
		/// </summary>
		hero_goalkeep_v = 9006,
		/// <summary>
		/// 球员评分
		/// </summary>
		hero_positionScore = 9010,
		/// <summary>
		/// 等级
		/// </summary>
		hero_level = 9051,
		/// <summary>
		/// 经验
		/// </summary>
		hero_exp = 9052,
		/// <summary>
		/// 状态
		/// </summary>
		hero_state = 9053,
		/// <summary>
		/// 当前使用的皮肤id
		/// </summary>
		use_skin_id = 9054,
		/// <summary>
		/// 球员品质
		/// </summary>
		hero_quality = 9055,
		/// <summary>
		/// 射门
		/// </summary>
		hero_shoot = 9101,
		/// <summary>
		/// 远射
		/// </summary>
		hero_longshoot = 9102,
		/// <summary>
		/// 速度
		/// </summary>
		hero_speed = 9103,
		/// <summary>
		/// 脚下力量/力量
		/// </summary>
		hero_power = 9104,
		/// <summary>
		/// 抢断
		/// </summary>
		hero_steals = 9105,
		/// <summary>
		/// 对抗
		/// </summary>
		hero_combat = 9106,
		/// <summary>
		/// 铲球
		/// </summary>
		hero_tackle = 9107,
		/// <summary>
		/// 争抢
		/// </summary>
		hero_rob = 9108,
		/// <summary>
		/// 带球
		/// </summary>
		hero_dribbled = 9109,
		/// <summary>
		/// 传球
		/// </summary>
		hero_pass = 9110,
		/// <summary>
		/// 敏捷
		/// </summary>
		hero_agility = 9111,
		/// <summary>
		/// 领袖
		/// </summary>
		hero_leader = 9112,
		/// <summary>
		/// 射门命中率增加
		/// </summary>
		extra_shoot_rate = 9131,
		/// <summary>
		/// 远射命中率增加
		/// </summary>
		extra_longshoot_rate = 9132,
		/// <summary>
		/// 带球速度增加
		/// </summary>
		extra_dribbled_speed_rate = 9133,
		/// <summary>
		/// 移动速度增加
		/// </summary>
		extra_move_speed_rate = 9134,
		/// <summary>
		/// 抢断成功率增加
		/// </summary>
		extra_steals_rate = 9135,
		/// <summary>
		/// 铲球成功率增加
		/// </summary>
		extra_tackle_rate = 9136,
		/// <summary>
		/// 拦截球成功率
		/// </summary>
		extra_stop_ball_rate = 9137,
		/// <summary>
		/// 防抢断几率
		/// </summary>
		extra_def_steals_rate = 9138,
		/// <summary>
		/// 传球命中率增加
		/// </summary>
		extra_pass_rate = 9139,
		/// <summary>
		/// 防铲球几率
		/// </summary>
		extra_def_tackle_rate = 9140,
		/// <summary>
		/// 领袖属性增加
		/// </summary>
		extra_leader_rate = 9141,
		/// <summary>
		/// 防撞倒几率   客户端格子
		/// </summary>
		extra_def_collision_rate = 9142,
		/// <summary>
		/// 身高
		/// </summary>
		hero_height = 9171,
		/// <summary>
		/// 体重
		/// </summary>
		hero_weight = 9172,
		/// <summary>
		/// 惯用脚
		/// </summary>
		hero_heavy = 9173,
		/// <summary>
		/// 位置
		/// </summary>
		hero_position = 9174,
		/// <summary>
		/// 宽度
		/// </summary>
		hero_width = 9175,
		/// <summary>
		/// 射门次数
		/// </summary>
		hero_sta_shoot_num = 9201,
		/// <summary>
		/// 正常进球
		/// </summary>
		hero_sta_goal_sta = 9202,
		/// <summary>
		/// 乌龙球
		/// </summary>
		hero_sta_own_goal = 9203,
		/// <summary>
		/// 抄截抢断次数
		/// </summary>
		hero_sta_steals = 9204,
		/// <summary>
		/// 成功抢断
		/// </summary>
		hero_sta_steal_suc = 9205,
		/// <summary>
		/// 传球次数
		/// </summary>
		hero_sta_pass_num = 9206,
		/// <summary>
		/// 成功传球
		/// </summary>
		hero_sta_pass_suc = 9207,
		/// <summary>
		/// 传球成功率
		/// </summary>
		hero_sta_pass_rate = 9208,
		/// <summary>
		/// 控球时间
		/// </summary>
		hero_sta_control_time = 9209,
		/// <summary>
		/// 控球率 
		/// </summary>
		hero_sta_control_rate = 9210,
		/// <summary>
		/// 队伍控球率
		/// </summary>
		hero_sta_ctrl_time_team = 9211,
		/// <summary>
		/// mvp
		/// </summary>
		hero_sta_mvp = 9212,
		/// <summary>
		/// 触球次数
		/// </summary>
		hero_sta_touch_ball_num = 9213,
		/// <summary>
		/// 技术分技巧积分
		/// </summary>
		hero_sta_tec_score = 9214,
		/// <summary>
		/// 本场球员评分
		/// </summary>
		hero_sta_score = 9215,
		/// <summary>
		/// 助攻
		/// </summary>
		hero_sta_assists = 9216,
		/// <summary>
		/// 释放必杀技次数
		/// </summary>
		hero_sta_finial_skill_num = 9217,
		/// <summary>
		/// 技能使用次数
		/// </summary>
		hero_skill_use_num = 9221,
		/// <summary>
		/// 技能成功使用次数
		/// </summary>
		hero_skill_suc_num = 9222,
		/// <summary>
		/// 技能4连次数
		/// </summary>
		hero_skill_four_num = 9223,
		/// <summary>
		/// 技能4连次数
		/// </summary>
		hero_skill_max_num = 9224,
		/// <summary>
		/// 必杀技使用次数
		/// </summary>
		hero_unique_skill_num = 9225,
		/// <summary>
		/// 守门员扑救次数
		/// </summary>
		hero_goalkeeper_num = 9226,
		/// <summary>
		/// 守门员成功扑救次数
		/// </summary>
		hero_goalkeeper_suc = 9227,
		/// <summary>
		/// 必杀技使用间隔CD
		/// </summary>
		hero_unique_skill_cd = 9228,
		/// <summary>
		/// 队伍控球率
		/// </summary>
		group_control_rate = 9231,
		/// <summary>
		/// 队伍射门次数
		/// </summary>
		group_shoot_num = 9232,
		/// <summary>
		/// 队伍传球成功率
		/// </summary>
		group_pass_rate = 9233,
		/// <summary>
		/// 队伍成功抢断次数
		/// </summary>
		group_steal_suc = 9234,
		/// <summary>
		/// 队伍释放必杀技次数
		/// </summary>
		group_finial_skill_num = 9235,
		/// <summary>
		/// 队伍技术分  技巧总分
		/// </summary>
		group_tec_score = 9236,
		/// <summary>
		/// 奖励经验
		/// </summary>
		hero_add_exp = 9301,
		/// <summary>
		/// hero_level_max_exp				= 9302,
		/// </summary>

		/// <summary>
		/// -----------train_camp_lev---------9321~9399  训练营
		/// </summary>

		/// <summary>
		/// 射门
		/// </summary>
		train_shoot = 9321,
		/// <summary>
		/// 远射
		/// </summary>
		train_longshoot = 9322,
		/// <summary>
		/// 速度
		/// </summary>
		train_speed = 9323,
		/// <summary>
		/// 脚下力量/力量
		/// </summary>
		train_power = 9324,
		/// <summary>
		/// 抢断
		/// </summary>
		train_steals = 9325,
		/// <summary>
		/// 对抗
		/// </summary>
		train_combat = 9326,
		/// <summary>
		/// 铲球
		/// </summary>
		train_tackle = 9327,
		/// <summary>
		/// 争抢
		/// </summary>
		train_rob = 9328,
		/// <summary>
		/// 带球
		/// </summary>
		train_dribbled = 9329,
		/// <summary>
		/// 传球
		/// </summary>
		train_pass = 9330,
		/// <summary>
		/// 敏捷
		/// </summary>
		train_agility = 9331,
		/// <summary>
		/// 领袖
		/// </summary>
		train_leader = 9332,
		/// <summary>
		/// 射门命中率增加
		/// </summary>
		train_shoot_rate = 9351,
		/// <summary>
		/// 远射命中率增加
		/// </summary>
		train_longshoot_rate = 9352,
		/// <summary>
		/// 带球速度增加
		/// </summary>
		train_dribbled_speed_rate = 9353,
		/// <summary>
		/// 移动速度增加
		/// </summary>
		train_move_speed_rate = 9354,
		/// <summary>
		/// 抢断成功率增加
		/// </summary>
		train_steals_rate = 9355,
		/// <summary>
		/// 铲球成功率增加
		/// </summary>
		train_tackle_rate = 9356,
		/// <summary>
		/// 拦截球成功率
		/// </summary>
		train_stop_ball_rate = 9357,
		/// <summary>
		/// 防抢断几率
		/// </summary>
		train_def_steals_rate = 9358,
		/// <summary>
		/// 传球命中率增加
		/// </summary>
		train_pass_rate = 9359,
		/// <summary>
		/// 防铲球几率
		/// </summary>
		train_def_tackle_rate = 9360,
		/// <summary>
		/// 领袖属性增加
		/// </summary>
		train_leader_rate = 9361,
		/// <summary>
		/// 防撞倒几率  格子id
		/// </summary>
		train_def_collision_rate = 9362,
		/// <summary>
		/// --------------------------------------------------------------
		/// </summary>

		/// <summary>
		/// 我方队伍分数
		/// </summary>
		client_my_team_score = 0,
		/// <summary>
		/// 对方队伍分数
		/// </summary>
		client_enemy_team_score = 1,
		/// <summary>
		/// 玩家赠送魅力价格
		/// </summary>
		client_user_charm_pay = 2,
		/// <summary>
		/// 标志玩家VIP过期Flag
		/// </summary>
		client_vip_expire_flag = 3,
		/// <summary>
		/// 我方球队必杀技能量条
		/// </summary>
		client_my_team_energy = 4,
		/// <summary>
		/// 敌方球队必杀技能量条
		/// </summary>
		client_enemy_team_energy = 5,
		/// <summary>
		/// 新的好友聊天信息
		/// </summary>
		client_friend_communication_flag = 6,
		/// <summary>
		/// 新手引导当前步骤
		/// </summary>
		client_guide_step = 7,
		/// <summary>
		/// 球队升级标记
		/// </summary>
		client_team_level_up_flag = 8,
		/// <summary>
		/// 球队升级界面弹出标记
		/// </summary>
		client_team_level_up_panel_flag = 9,
		/// <summary>
		/// Reward界面弹出标记
		/// </summary>
		client_reward_panel_flag = 10,
		/// <summary>
		/// 邮件
		/// </summary>
		NEW_MAIL = 100,
		/// <summary>
		/// 系统邮件
		/// </summary>
		NEW_MAIL_SYS = 101,
		/// <summary>
		/// 标志玩家是否已经所有训练营都满级
		/// </summary>
		client_user_camps_full = 200,
		/// <summary>
		/// 每日活动红点
		/// </summary>
		client_daily_mission_point = 400,
		/// <summary>
		/// 成就界面红点
		/// </summary>
		client_achievement_point = 500,
		/// <summary>
		/// 球员养成界面红点
		/// </summary>
		client_player_upgrade_point = 600,
	}
}
