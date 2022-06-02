using Exiled.API.Interfaces;
using NukeLock.Configs;
using System.Collections.Generic;
using System.ComponentModel;

namespace NukeLock
{
    public sealed class Config : IConfig
    {
        [Description("是否应启用插件？")]
        public bool IsEnabled { get; set; } = true;

        [Description("弹头应该在回合开始时武装起来吗？")]
        public bool WarheadAutoArmed { get; set; } = true;

        [Description("弹头应该在回合开始时锁定吗？")]
        public bool WarheadCancelable { get; set; } = false;

        [Description("玩家被辐射致死时的死亡信息")]
        public string RadiationDeathReason { get; set; } = "Died by Radiation";

        [Description("之后，弹头引爆时应开始辐射。（-1=禁用）")]
        public float RadiationDelay { get; set; } = 120f;

        [Description("弹头引爆时显示的信息。（空=禁用）")]
        public string RadiationWarningMessage { get; set; } = "<color=red>阿尔法弹头已经引爆，2分钟后会发生辐射</color>";

        [Description("发生辐射时显示的消息。（Empty=禁用）")]
        public string RadiationBeginMessage { get; set; } = "<color=red>辐射现在已经到达地表区域</color>";

        [Description("弹头引爆后，所有玩家都会受到辐射伤害的间隔时间。")]
        public int RadiationInterval { get; set; } = 5;

        [Description("The Damage dealth to players after each radiation_interval")]
        public float RadiationDamage { get; set; } = 2;

        [Description("弹头应在什么时间后自动启动且不能停止（-1=禁用)")]
        public int AutoNuke { get; set; } = 900;

        [Description("在什么时间后，应该在地图上播放永久性广播，告知自动核武器将被激活？ %COUNTDOWN% 将替换为激活autonuke之前的剩余时间")]
        public int AutoNukePermaBroadcastTimer { get; set; } = 30;
        public string AutoNukePermaBroadcastMessage { get; set; } = "<color=red>阿尔法弹头紧急引爆程序将在 %COUNTDOWN% 秒后启动</color>";

        [Description("当玩家在无法停止的情况下试图禁用核武器时，提示应该显示多长时间？（-1=禁用）")]
        public int HintTime { get; set; } = 3;

        [Description("当玩家试图在无法停止的情况下禁用核武器时，应该显示什么提示？")]
        public string HintMessage { get; set; } = "<color=red>无法禁用此核弹</color>";

        [Description("当AutoNuke启动时，广播应该播放多长时间？（-1=禁用）")]
        public ushort DetonationBroadcastTime { get; set; } = 3;

        [Description("当AutoNuke启动时，应该播放什么广播？")]
        public string DetonationBroadcastMessage { get; set; } = "<color=red>阿尔法弹头引爆序列启动， <b>这个弹头无法阻止</b></color>";

        [Description("是否会向所有玩家播放广播，告知弹头爆炸还剩多少秒。")]
        public bool WarheadDetonationTimer { get; set; } = true;

        [Description("显示消息，告诉玩家弹头爆炸还剩多少秒。 %COUNTDOWN% 将替换为秒，直到弹头引爆")]
        public string WarheadDetonationMessage { get; set; } = "<color=red>阿尔法弹头在倒数</color> <color=orange>%COUNTDOWN% 后引爆</color>";

        [Description("弹头引爆时是否会禁用团队重生。")]
        public bool WarheadDisablesTeamRespawn { get; set; } = true;

        [Description("当弹头启动时，弹头应该是什么颜色。(Putting one to -1 will disable it)")]
        public Colors WarheadColor { get; set; } = new Colors();

        [Description("卡西的消息应该在什么时候播出？ (Empty = Disabled)")]
        public Dictionary<int, string> CassieWarnings { get; set; } = new Dictionary<int, string>
        {
            { 600, "Attention, all personnel, The Alpha Warhead Emergency Detonation Sequence will be started in TMinus 10 Minutes" },
            { 300, "Danger, The Alpha Warhead Emergency Detonation Sequence will be started in TMinus 5 Minutes" },
            { 120, "Danger, The Alpha Warhead Emergency Detonation Sequence will be started in TMinus 2 Minutes" },
            { 30, "Danger, The Alpha Warhead Emergency Detonation Sequence will be started in TMinus 30 Seconds" }
        };
    }
}
