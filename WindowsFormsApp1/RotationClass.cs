using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    internal class RotationClass
    {
        public static string DoSingleTarget(BalanceDruidInfo druid)
        {
            if (druid.CastingTimeLeft > 0 && (druid.StarfireStacks == 1 || druid.WrathStacks == 1) && druid.StarlordDuration > 0) return "z";
            if (druid.ConvokingDuration > 0) return "";
            if (druid.BalanceOfAllThingsDuration > 0 && druid.AstralPower > 30) return "r";
            if (druid.Moving == 0)
            {                
                //If out of Eclipse
                if (druid.Eclipse == 0)
                {
                    if (druid.StarfireStacks == 2) return "2";                    
                    if (druid.CastingTimeLeft > 0 && druid.StarfireStacks == 1 && druid.AstralPower > 22) return "r";
                    if (druid.CastingTimeLeft > 0 && druid.StarfireStacks == 1) return "3";
                    if (druid.StarfireStacks == 1) return "2";

                    if (druid.WrathStacks == 2) return "3";
                    if (druid.CastingTimeLeft > 0 && druid.WrathStacks == 1 && druid.AstralPower > 24) return "r";
                    if (druid.CastingTimeLeft > 0 && druid.WrathStacks == 1) return "2";
                    if (druid.WrathStacks == 1) return "3";
                }
                //If in Eclipse
                else
                {
                    if (druid.Eclipse > 5 && druid.AstralPower > 90) return "r";
                    if (druid.SunfireDuration < 5) return "5";
                    if (druid.MoonfireDuration < 6) return "4";
                    if (druid.Tier45 == Tier45.StellarFlare && druid.StellarFlareDuration < 5) return "1";
                    if (druid.SolarEclipse > 0) return "3";
                    if (druid.LunarEclipse > 0) return "2";
                }
            }
            else
            {    
                //Do I have Stellar Drift for starters
                if (druid.Tier45 == Tier45.StellarDrift)
                {
                    //Can I cast Starfall and should I?
                    if (druid.StarfallDuration < 3 && druid.AstralPower < 50) return "f";
                    if (druid.BalanceOfAllThingsDuration > 0 && druid.AstralPower > 70) return "r";
                    if (druid.AstralPower > 90 && druid.Eclipse > 2) return "r";
                    if (druid.Eclipse > 1 && druid.SunfireDuration < 5) return "5";
                    if (druid.Eclipse > 1 && druid.MoonfireDuration < 6) return "4";
                    if (druid.StarfallDuration > 0 && druid.SolarEclipse > 0) return "3";
                    if (druid.StarfallDuration > 0 && druid.LunarEclipse > 0) return "2";
                    if (druid.StarfallDuration > 0 && druid.SolarEclipse > 0) return "3";
                    if (druid.StarfallDuration > 0 && druid.LunarEclipse > 0) return "2";
                }
                else
                {
                    if (druid.AstralPower > 95 && druid.Eclipse > 0) return "r";
                    if (druid.SunfireDuration < 5) return "5";
                    if (druid.MoonfireDuration < 6) return "4";
                    if (druid.MoonfireDuration > druid.SunfireDuration) return "5";
                    if (druid.MoonfireDuration < druid.SunfireDuration) return "4";
                }

            }

            return ""; //Nothing
        }

        public static string DoAoe(BalanceDruidInfo druid)
        {
            if (druid.AstralPower > 50 && druid.StarfallDuration < 2) return "f";
            if (druid.SunfireDuration < 5) return "5";
            //Standing Still or having starfall with stellar drift
            if (druid.Moving == 0 || (druid.StarfallDuration > 2 && druid.Tier45 == Tier45.StellarDrift))
            {
                //If Not Eclipsed
                if (druid.Eclipse == 0)
                {
                    if (druid.WrathStacks == 2) return "3";
                    if (druid.CastingTimeLeft > 0 && druid.WrathStacks == 1 && druid.AstralPower > 24) return "r";
                    if (druid.CastingTimeLeft > 0 && druid.WrathStacks == 1) return "2";
                    if (druid.WrathStacks == 1) return "3";

                    if (druid.StarfireStacks == 2) return "2";
                    if (druid.CastingTimeLeft > 0 && druid.StarfireStacks == 1 && druid.AstralPower > 22) return "r";
                    if (druid.CastingTimeLeft > 0 && druid.StarfireStacks == 1) return "3";
                    if (druid.StarfireStacks == 1) return "2";
                }
                //If in Eclipse
                else
                {
                    if (druid.StarfallDuration < 3 && druid.AstralPower > 50) return "f";
                    if (druid.Eclipse > 2 && druid.AstralPower > 90) return "r";
                    if (druid.SunfireDuration < 4) return "5";
                    if (druid.MoonfireDuration < 4 && druid.LunarEclipse > 2) return "4";                    
                    if (druid.SolarEclipse > 0) return "3";
                    if (druid.LunarEclipse > 0) return "2";
                }
            }
            //Moving and not having Starfall with stellar drift
            else
            {
                if (druid.StarfallDuration < 3 && druid.AstralPower > 50) return "f";
                if (druid.AstralPower > 95 && druid.Eclipse > 0) return "r";
                if (druid.SunfireDuration < 4) return "5";
                if (druid.MoonfireDuration < 4 && druid.SolarEclipse > 2) return "4";
                if (druid.MoonfireDuration > druid.SunfireDuration) return "5";
                if (druid.MoonfireDuration < druid.SunfireDuration) return "4";
            }

            return "";
        }

        public static BalanceDruidInfo GetValuesClass()
        {
            int x = 0;
            int y = 0;
            BalanceDruidInfo druid = new BalanceDruidInfo();
            Color AstralEclipseCasting = GetColorAt(x, y);
            Color Dots = GetColorAt(x+1, y);
            Color StarfallLunarWrathStacks = GetColorAt(x+2, y);
            Color StarlordLegendarySingleTarget = GetColorAt(x+3, y);
            Color MovingConvokingStopping = GetColorAt(x+4, y);

            //Debug.WriteLine($"R: {AstralEclipseCasting.R} G: {AstralEclipseCasting.G} B: {AstralEclipseCasting.B}");
            //Debug.WriteLine($"R: {Dots.R} G: {Dots.G} B: {Dots.B}");
            //Debug.WriteLine($"R: {StarfallLunarWrathStacks.R} G: {StarfallLunarWrathStacks.G} B: {StarfallLunarWrathStacks.B}");
            //Debug.WriteLine($"R: {StarlordLegendarySingleTarget.R} G: {StarlordLegendarySingleTarget.G} B: {StarlordLegendarySingleTarget.B}");

            druid = SetupAstralEclipseCasting(AstralEclipseCasting, druid);

            druid = SetupDots(Dots, druid);

            druid = SetupStarfallLunarWrathStacks(StarfallLunarWrathStacks, druid);

            druid = SetupStarlordLegendarySingleTarget(StarlordLegendarySingleTarget, druid);

            druid = SetupMovingConvokingStopping(MovingConvokingStopping, druid);

            return druid;
        }

        private static BalanceDruidInfo SetupMovingConvokingStopping(Color movingConvokingStopping, BalanceDruidInfo druid)
        {
            druid.Moving = movingConvokingStopping.R;
            druid.ConvokingDuration = movingConvokingStopping.G;
            if (movingConvokingStopping.B == 0) druid.DoNothing = false;
            else druid.DoNothing = true;
            return druid;
        }

        private static BalanceDruidInfo SetupStarlordLegendarySingleTarget(Color starlordLegendarySingleTarget, BalanceDruidInfo druid)
        {
            druid.StarlordStacks = GetStarlordStacks(starlordLegendarySingleTarget.R);
            druid.StarlordDuration = GetStarlordDuration(starlordLegendarySingleTarget.R);

            druid = SetupBalanceOfAllThingsAndDreambinder(starlordLegendarySingleTarget.G, druid);

            druid = SetupAoeOrSingletarget(starlordLegendarySingleTarget.B, druid);
            return druid;
        }

        private static BalanceDruidInfo SetupAoeOrSingletarget(byte b, BalanceDruidInfo druid)
        {
            if (b == 0) druid.SingleTarget = true;
            else druid.SingleTarget = false;
            return druid;
        }

        private static BalanceDruidInfo SetupBalanceOfAllThingsAndDreambinder(byte g, BalanceDruidInfo druid)
        {
            if (g < 51)
            {
                //Balance of all things
                druid.DreambinderDuration = 0;
                druid.BalanceOfAllThingsDuration = g;
            }
            else if (g > 50 && g < 101)
            {
                //Dreambinder
                druid.DreambinderDuration = g - 50;
                druid.BalanceOfAllThingsDuration = 0;
            }
            return druid;
        }

        private static int GetStarlordDuration(byte r)
        {
            if (r <= 50) return r;
            if (r <= 100) return r - 50;
            if (r <= 150) return r - 100;
            return r;
        }

        private static int GetStarlordStacks(byte r)
        {
            if (r == 0) return 0;
            if (r < 51) return 1;
            if (r < 101) return 2;
            if (r < 151) return 3;
            return 0;
        }

        private static BalanceDruidInfo SetupStarfallLunarWrathStacks(Color starfallLunarWrathStacks, BalanceDruidInfo druid)
        {
            druid.StarfallDuration = starfallLunarWrathStacks.R;
            druid.StarfireStacks = starfallLunarWrathStacks.G;
            druid.WrathStacks = starfallLunarWrathStacks.B;
            return druid;
        }

        private static BalanceDruidInfo SetupDots(Color dots, BalanceDruidInfo druid)
        {
            druid.SunfireDuration = dots.R;
            druid.MoonfireDuration = dots.G;
            druid.StellarFlareDuration = dots.B;

            return druid;
        }

        private static BalanceDruidInfo SetupAstralEclipseCasting(Color AstralEclipseCasting, BalanceDruidInfo druid)
        {
            druid.AstralPower = AstralEclipseCasting.R;
            druid = CalculateEclipse(AstralEclipseCasting.G, druid);
            druid = CalculateRemaningCasttime(AstralEclipseCasting.B, druid);

            return druid;
        }

        private static BalanceDruidInfo CalculateRemaningCasttime(int b, BalanceDruidInfo druid)
        {
            druid.CastingTimeLeft = b * 100;
            druid.CastingTimeLeft = druid.CastingTimeLeft / 100;
            return druid;
        }

        private static BalanceDruidInfo CalculateEclipse(int color, BalanceDruidInfo druid)
        {
            if (color == 0)
            {
                druid.LunarEclipse = 0;
                druid.SolarEclipse = 0;
                druid.CelestialAligment = 0;
            }
            else if (color <= 69)
            {
                druid.LunarEclipse = color;
                druid.SolarEclipse = 0;
                druid.CelestialAligment = 0;
            }
            else if (color <= 139)
            {
                druid.LunarEclipse = 0;
                druid.SolarEclipse = color - 69;
                druid.CelestialAligment = 0;
            }
            else if (color <= 209)
            {
                druid.LunarEclipse = color - 139;
                druid.SolarEclipse = color - 139;
                druid.CelestialAligment = color - 139;
            }
            return druid;
        }



        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        public static Color GetColorAt(int x, int y)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int)GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }
    }
}