using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Timer timer;

        public Form1()
        {
            InitializeComponent();
            Tier40.Items.Add("Soul Of The Forest");
            Tier40.Items.Add("Starlord");
            Tier40.Items.Add("Incarn");

            Tier45.Items.Add("Stellar Drift");
            Tier45.Items.Add("Twin Moons");
            Tier45.Items.Add("Stellar Flare");

            Tier40.SelectedIndex = 0;
            Tier45.SelectedIndex = 0;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = new Random().Next(10, 100);
            var s = RotationClass.GetValuesClass();
            AstralPower.Text = s.AstralPower.ToString();
            LunarEclipseDuration.Text = s.LunarEclipse.ToString();
            SolarEclipseDuration.Text = s.SolarEclipse.ToString();
            CelestialDuration.Text = s.CelestialAligment.ToString();
            CastTimeLeft.Text = s.CastingTimeLeft.ToString();
            StarfallDuration.Text = s.StarfallDuration.ToString();
            SunfireDuration.Text = s.SunfireDuration.ToString();
            MoonfireDuration.Text = s.MoonfireDuration.ToString();
            StellarFlareDuration.Text = s.StellarFlareDuration.ToString();
            StarfireStacks.Text = s.StarfireStacks.ToString();
            WrathStacks.Text = s.WrathStacks.ToString();
            BalanceOfAllThingsDuration.Text = s.BalanceOfAllThingsDuration.ToString();
            DreambinderDuration.Text = s.DreambinderDuration.ToString();
            StarlordDuration.Text = s.StarlordDuration.ToString();
            StarlordStacks.Text = s.StarlordStacks.ToString();
            Moving.Text = s.Moving.ToString();

            if (Tier40.SelectedIndex == 0) s.Tier40 = WindowsFormsApp1.Tier40.SoulOfTheForest;
            else if (Tier40.SelectedIndex == 1) s.Tier40 = WindowsFormsApp1.Tier40.Starlord;
            else s.Tier40 = WindowsFormsApp1.Tier40.Incarn;

            if (Tier45.SelectedIndex == 0) s.Tier45 = WindowsFormsApp1.Tier45.StellarDrift;
            else if (Tier45.SelectedIndex == 1) s.Tier45 = WindowsFormsApp1.Tier45.TwinMoons;
            else s.Tier45 = WindowsFormsApp1.Tier45.StellarFlare;

            if(s.DoNothing == true)
            {
                DoNothing.ForeColor = Color.Red;
                DoNothing.Text = "Stopped";
            }
            else
            {
                DoNothing.ForeColor = Color.Green;
                DoNothing.Text = "Running";
            }

            if (s.ConvokingDuration > 0)
            {
                IsConvoking.Visible = true;
                return;
            }
            else
            { 
                IsConvoking.Visible = false;
            }


            
            string keybind = "";
            if (s.SingleTarget == true)
            {
                DoSingleTarget.Text = "Doing Single Target Rotation";
                keybind = RotationClass.DoSingleTarget(s);
            }
            else
            {
                DoSingleTarget.Text = "Doing AoE Rotation";
                keybind = RotationClass.DoAoe(s);
            }
            if (s.DoNothing == true) return;
            SendKeys.Send(keybind);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            // Everytime timer ticks, timer_Tick will be called
            timer.Interval = new Random().Next(10, 100);            // Timer will tick every 50 second  
            timer.Enabled = true;
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
