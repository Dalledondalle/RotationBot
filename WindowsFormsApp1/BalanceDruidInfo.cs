namespace WindowsFormsApp1
{
    public class BalanceDruidInfo
    {
        public int AstralPower { get; set; }
        public int LunarEclipse { get; set; }
        public int SolarEclipse { get; set; }
        public int Eclipse 
        { 
            get {
                if (LunarEclipse == SolarEclipse) return LunarEclipse;
                if (LunarEclipse > SolarEclipse) return LunarEclipse;
                if (SolarEclipse > LunarEclipse) return SolarEclipse;
                return 0;
            } }
        public int CelestialAligment { get; set; }
        public float CastingTimeLeft { get; set; }
        public int StarfallDuration { get; set; }
        public int SunfireDuration { get; set; }
        public int MoonfireDuration { get; set; }
        public int StellarFlareDuration { get; set; }
        public int StarfireStacks { get; set; }
        public int WrathStacks { get; set; }
        public int BalanceOfAllThingsDuration { get; set; }
        public int DreambinderDuration { get; set; }
        public int DreambinderStacks { get; set; }
        public bool SingleTarget { get; set; }
        public bool DoNothing { get; set; }
        public int StarlordDuration { get; set; }
        public int StarlordStacks { get; set; }
        public int ConvokingDuration { get; set; }
        public int Moving { get; set; }
        public Tier40 Tier40 { get; set; }
        public Tier45 Tier45 { get; set; }
    }

    public enum Tier40
    {
        SoulOfTheForest,
        Starlord,
        Incarn
    }

    public enum Tier45
    {
        StellarDrift,
        TwinMoons,
        StellarFlare
    }
}