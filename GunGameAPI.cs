using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Capabilities;
using CounterStrikeSharp.API.Core.Plugin;

public interface IAPI
{
    event Action<WinnerEventArgs> KnifeStealEvent;
    event Action<KillEventArgs> KillEvent;
    event Action<WinnerEventArgs> WinnerEvent;
    event Action<LevelChangeEventArgs> LevelChangeEvent;
    event Action<PointChangeEventArgs> PointChangeEvent;
    event Action<WeaponFragEventArgs> WeaponFragEvent;
    event Action RestartEvent;
    public int GetMaxLevel();
    public int GetPlayerLevel(int slot);
    public int GetMaxCurrentLevel();
    public bool IsWarmupInProgress();
}
public class WinnerEventArgs : EventArgs
{
    public int Winner { get; }
    public int Looser { get; }
    public WinnerEventArgs(int winner, int looser)
    {
        Winner = winner;
        Looser = looser;
    }
}
public class KillEventArgs : EventArgs
{
    public bool Result { get; set; }
    public int Killer { get; }
    public int Victim { get; }
    public string Weapon { get; }
    public bool TeamKill { get; }
    public KillEventArgs(int killer, int victim, string weapon, bool teamkill)
    {
        Killer = killer;
        Victim = victim;
        Weapon = weapon;
        TeamKill = teamkill;
        Result = true;
    }
}
public class LevelChangeEventArgs : EventArgs
{
    public int Killer { get; }
    public int Level { get; }
    public int Difference { get; }
    public bool KnifeSteal { get; }
    public bool LastLevel { get; }
    public bool Knife { get; }
    public int Victim { get; }
    public bool Result { get; set; }
    public LevelChangeEventArgs(int killer, int level, int difference, bool knifesteal, bool lastlevel, bool knife, int victim)
    {
        Killer = killer;
        Level = level;
        Difference = difference;
        KnifeSteal = knifesteal;
        LastLevel = lastlevel;
        Knife = knife;
        Victim = victim;
        Result = true;
    }
}
public class PointChangeEventArgs : EventArgs
{
    public int Killer { get; }
    public int Kills { get; }
    public int Victim { get; }
    public bool Result { get; set; }
    public PointChangeEventArgs(int killer, int kills, int victim)
    {
        Killer = killer;
        Kills = kills;
        Victim = victim;
        Result = true;
    }
}
public class WeaponFragEventArgs : EventArgs
{
    public int Killer { get; }
    public string Weapon { get; }
    public bool Result { get; set; }
    public WeaponFragEventArgs(int killer, string weapon)
    {
        Killer = killer;
        Weapon = weapon;
        Result = true;
    }
}