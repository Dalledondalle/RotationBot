
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Stop = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DoSingleTarget = new System.Windows.Forms.Label();
            this.DoNothing = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BalanceOfAllThingsDuration = new System.Windows.Forms.Label();
            this.AstralPower = new System.Windows.Forms.Label();
            this.LunarEclipseDuration = new System.Windows.Forms.Label();
            this.SolarEclipseDuration = new System.Windows.Forms.Label();
            this.CelestialDuration = new System.Windows.Forms.Label();
            this.CastTimeLeft = new System.Windows.Forms.Label();
            this.StarfallDuration = new System.Windows.Forms.Label();
            this.SunfireDuration = new System.Windows.Forms.Label();
            this.MoonfireDuration = new System.Windows.Forms.Label();
            this.StellarFlareDuration = new System.Windows.Forms.Label();
            this.StarfireStacks = new System.Windows.Forms.Label();
            this.WrathStacks = new System.Windows.Forms.Label();
            this.DreambinderDuration = new System.Windows.Forms.Label();
            this.StarlordDuration = new System.Windows.Forms.Label();
            this.StarlordStacks = new System.Windows.Forms.Label();
            this.IsConvoking = new System.Windows.Forms.Label();
            this.Tier40 = new System.Windows.Forms.ComboBox();
            this.Tier45 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Moving = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(646, 373);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(142, 32);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(646, 411);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(142, 27);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(33, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Astral";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lunar Eclipse Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Solar Eclipse Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Celestial Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CastTime Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Starfall Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sunfire Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Moonfire Duration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Stellar Flare Duration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Starfire Stacks";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Wrath Stacks";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Balance Of All Things Duration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Dreambinder Duration";
            // 
            // DoSingleTarget
            // 
            this.DoSingleTarget.AutoSize = true;
            this.DoSingleTarget.Location = new System.Drawing.Point(664, 331);
            this.DoSingleTarget.Name = "DoSingleTarget";
            this.DoSingleTarget.Size = new System.Drawing.Size(87, 13);
            this.DoSingleTarget.TabIndex = 15;
            this.DoSingleTarget.Text = "Do Single Target";
            // 
            // DoNothing
            // 
            this.DoNothing.AutoSize = true;
            this.DoNothing.Location = new System.Drawing.Point(664, 344);
            this.DoNothing.Name = "DoNothing";
            this.DoNothing.Size = new System.Drawing.Size(61, 13);
            this.DoNothing.TabIndex = 16;
            this.DoNothing.Text = "Do Nothing";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Starlord Duration";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 354);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Starlord Stacks";
            // 
            // BalanceOfAllThingsDuration
            // 
            this.BalanceOfAllThingsDuration.AutoSize = true;
            this.BalanceOfAllThingsDuration.Location = new System.Drawing.Point(170, 283);
            this.BalanceOfAllThingsDuration.Name = "BalanceOfAllThingsDuration";
            this.BalanceOfAllThingsDuration.Size = new System.Drawing.Size(33, 13);
            this.BalanceOfAllThingsDuration.TabIndex = 19;
            this.BalanceOfAllThingsDuration.Text = "Astral";
            // 
            // AstralPower
            // 
            this.AstralPower.AutoSize = true;
            this.AstralPower.Location = new System.Drawing.Point(170, 9);
            this.AstralPower.Name = "AstralPower";
            this.AstralPower.Size = new System.Drawing.Size(33, 13);
            this.AstralPower.TabIndex = 20;
            this.AstralPower.Text = "Astral";
            // 
            // LunarEclipseDuration
            // 
            this.LunarEclipseDuration.AutoSize = true;
            this.LunarEclipseDuration.Location = new System.Drawing.Point(170, 34);
            this.LunarEclipseDuration.Name = "LunarEclipseDuration";
            this.LunarEclipseDuration.Size = new System.Drawing.Size(33, 13);
            this.LunarEclipseDuration.TabIndex = 21;
            this.LunarEclipseDuration.Text = "Astral";
            // 
            // SolarEclipseDuration
            // 
            this.SolarEclipseDuration.AutoSize = true;
            this.SolarEclipseDuration.Location = new System.Drawing.Point(170, 58);
            this.SolarEclipseDuration.Name = "SolarEclipseDuration";
            this.SolarEclipseDuration.Size = new System.Drawing.Size(33, 13);
            this.SolarEclipseDuration.TabIndex = 22;
            this.SolarEclipseDuration.Text = "Astral";
            // 
            // CelestialDuration
            // 
            this.CelestialDuration.AutoSize = true;
            this.CelestialDuration.Location = new System.Drawing.Point(170, 84);
            this.CelestialDuration.Name = "CelestialDuration";
            this.CelestialDuration.Size = new System.Drawing.Size(33, 13);
            this.CelestialDuration.TabIndex = 23;
            this.CelestialDuration.Text = "Astral";
            // 
            // CastTimeLeft
            // 
            this.CastTimeLeft.AutoSize = true;
            this.CastTimeLeft.Location = new System.Drawing.Point(170, 111);
            this.CastTimeLeft.Name = "CastTimeLeft";
            this.CastTimeLeft.Size = new System.Drawing.Size(33, 13);
            this.CastTimeLeft.TabIndex = 24;
            this.CastTimeLeft.Text = "Astral";
            // 
            // StarfallDuration
            // 
            this.StarfallDuration.AutoSize = true;
            this.StarfallDuration.Location = new System.Drawing.Point(170, 136);
            this.StarfallDuration.Name = "StarfallDuration";
            this.StarfallDuration.Size = new System.Drawing.Size(33, 13);
            this.StarfallDuration.TabIndex = 25;
            this.StarfallDuration.Text = "Astral";
            // 
            // SunfireDuration
            // 
            this.SunfireDuration.AutoSize = true;
            this.SunfireDuration.Location = new System.Drawing.Point(170, 161);
            this.SunfireDuration.Name = "SunfireDuration";
            this.SunfireDuration.Size = new System.Drawing.Size(33, 13);
            this.SunfireDuration.TabIndex = 26;
            this.SunfireDuration.Text = "Astral";
            // 
            // MoonfireDuration
            // 
            this.MoonfireDuration.AutoSize = true;
            this.MoonfireDuration.Location = new System.Drawing.Point(170, 187);
            this.MoonfireDuration.Name = "MoonfireDuration";
            this.MoonfireDuration.Size = new System.Drawing.Size(33, 13);
            this.MoonfireDuration.TabIndex = 27;
            this.MoonfireDuration.Text = "Astral";
            // 
            // StellarFlareDuration
            // 
            this.StellarFlareDuration.AutoSize = true;
            this.StellarFlareDuration.Location = new System.Drawing.Point(170, 213);
            this.StellarFlareDuration.Name = "StellarFlareDuration";
            this.StellarFlareDuration.Size = new System.Drawing.Size(33, 13);
            this.StellarFlareDuration.TabIndex = 28;
            this.StellarFlareDuration.Text = "Astral";
            // 
            // StarfireStacks
            // 
            this.StarfireStacks.AutoSize = true;
            this.StarfireStacks.Location = new System.Drawing.Point(170, 236);
            this.StarfireStacks.Name = "StarfireStacks";
            this.StarfireStacks.Size = new System.Drawing.Size(33, 13);
            this.StarfireStacks.TabIndex = 29;
            this.StarfireStacks.Text = "Astral";
            // 
            // WrathStacks
            // 
            this.WrathStacks.AutoSize = true;
            this.WrathStacks.Location = new System.Drawing.Point(170, 260);
            this.WrathStacks.Name = "WrathStacks";
            this.WrathStacks.Size = new System.Drawing.Size(33, 13);
            this.WrathStacks.TabIndex = 30;
            this.WrathStacks.Text = "Astral";
            // 
            // DreambinderDuration
            // 
            this.DreambinderDuration.AutoSize = true;
            this.DreambinderDuration.Location = new System.Drawing.Point(170, 306);
            this.DreambinderDuration.Name = "DreambinderDuration";
            this.DreambinderDuration.Size = new System.Drawing.Size(33, 13);
            this.DreambinderDuration.TabIndex = 31;
            this.DreambinderDuration.Text = "Astral";
            // 
            // StarlordDuration
            // 
            this.StarlordDuration.AutoSize = true;
            this.StarlordDuration.Location = new System.Drawing.Point(170, 331);
            this.StarlordDuration.Name = "StarlordDuration";
            this.StarlordDuration.Size = new System.Drawing.Size(33, 13);
            this.StarlordDuration.TabIndex = 32;
            this.StarlordDuration.Text = "Astral";
            // 
            // StarlordStacks
            // 
            this.StarlordStacks.AutoSize = true;
            this.StarlordStacks.Location = new System.Drawing.Point(170, 354);
            this.StarlordStacks.Name = "StarlordStacks";
            this.StarlordStacks.Size = new System.Drawing.Size(33, 13);
            this.StarlordStacks.TabIndex = 33;
            this.StarlordStacks.Text = "Astral";
            // 
            // IsConvoking
            // 
            this.IsConvoking.AutoSize = true;
            this.IsConvoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsConvoking.ForeColor = System.Drawing.Color.Lime;
            this.IsConvoking.Location = new System.Drawing.Point(65, 137);
            this.IsConvoking.Name = "IsConvoking";
            this.IsConvoking.Size = new System.Drawing.Size(686, 76);
            this.IsConvoking.TabIndex = 34;
            this.IsConvoking.Text = "CONVOOOOKEEE!!!";
            this.IsConvoking.Visible = false;
            // 
            // Tier40
            // 
            this.Tier40.FormattingEnabled = true;
            this.Tier40.Location = new System.Drawing.Point(389, 31);
            this.Tier40.Name = "Tier40";
            this.Tier40.Size = new System.Drawing.Size(121, 21);
            this.Tier40.TabIndex = 35;
            // 
            // Tier45
            // 
            this.Tier45.FormattingEnabled = true;
            this.Tier45.Location = new System.Drawing.Point(516, 31);
            this.Tier45.Name = "Tier45";
            this.Tier45.Size = new System.Drawing.Size(121, 21);
            this.Tier45.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Moving";
            // 
            // Moving
            // 
            this.Moving.AutoSize = true;
            this.Moving.Location = new System.Drawing.Point(170, 373);
            this.Moving.Name = "Moving";
            this.Moving.Size = new System.Drawing.Size(33, 13);
            this.Moving.TabIndex = 38;
            this.Moving.Text = "Astral";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Moving);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Tier45);
            this.Controls.Add(this.Tier40);
            this.Controls.Add(this.IsConvoking);
            this.Controls.Add(this.StarlordStacks);
            this.Controls.Add(this.StarlordDuration);
            this.Controls.Add(this.DreambinderDuration);
            this.Controls.Add(this.WrathStacks);
            this.Controls.Add(this.StarfireStacks);
            this.Controls.Add(this.StellarFlareDuration);
            this.Controls.Add(this.MoonfireDuration);
            this.Controls.Add(this.SunfireDuration);
            this.Controls.Add(this.StarfallDuration);
            this.Controls.Add(this.CastTimeLeft);
            this.Controls.Add(this.CelestialDuration);
            this.Controls.Add(this.SolarEclipseDuration);
            this.Controls.Add(this.LunarEclipseDuration);
            this.Controls.Add(this.AstralPower);
            this.Controls.Add(this.BalanceOfAllThingsDuration);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DoNothing);
            this.Controls.Add(this.DoSingleTarget);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label DoSingleTarget;
        private System.Windows.Forms.Label DoNothing;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label BalanceOfAllThingsDuration;
        private System.Windows.Forms.Label AstralPower;
        private System.Windows.Forms.Label LunarEclipseDuration;
        private System.Windows.Forms.Label SolarEclipseDuration;
        private System.Windows.Forms.Label CelestialDuration;
        private System.Windows.Forms.Label CastTimeLeft;
        private System.Windows.Forms.Label StarfallDuration;
        private System.Windows.Forms.Label SunfireDuration;
        private System.Windows.Forms.Label MoonfireDuration;
        private System.Windows.Forms.Label StellarFlareDuration;
        private System.Windows.Forms.Label StarfireStacks;
        private System.Windows.Forms.Label WrathStacks;
        private System.Windows.Forms.Label DreambinderDuration;
        private System.Windows.Forms.Label StarlordDuration;
        private System.Windows.Forms.Label StarlordStacks;
        private System.Windows.Forms.Label IsConvoking;
        private System.Windows.Forms.ComboBox Tier40;
        private System.Windows.Forms.ComboBox Tier45;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Moving;
    }
}

