using System;
using System.Drawing;
using System.Windows.Forms;

namespace SurroundWiringCalc {
    public partial class MainForm : Form {
        public MainForm() => InitializeComponent();

        readonly static Color[] colors = new Color[] { Color.LightBlue, Color.LightGreen, Color.LightCoral, Color.LightSalmon, Color.LightGoldenrodYellow };

        int[] bestMatch;
        double bestMatchDistance;
        double bestMatchImpedance;

        void Consider(int[] plan) {
            double planImpedance = 0;
            for (int i = 0; i < plan.Length; ++i) {
                if (plan[i] == 0)
                    break;
                planImpedance += (double)speakerImpedance.Value / plan[i];
            }
            double matchDistance = Math.Abs((double)amplifierImpedance.Value - planImpedance);
            if (matchDistance < bestMatchDistance) {
                bestMatch = plan;
                bestMatchDistance = matchDistance;
                bestMatchImpedance = planImpedance;
            }
        }

        void Plan(int[] from, int place, int remaining) {
            int sum = 0;
            for (int i = 0; i < from.Length; ++i)
                sum += from[i];
            if (sum == speakerCount.Value)
                Consider(from);
            int max = remaining;
            if (place != 0 && max > from[place - 1])
                max = from[place - 1];
            for (int i = 1; i <= max; ++i) {
                int[] target = (int[])from.Clone();
                target[place] = i;
                Plan(target, place + 1, remaining - i);
            }
        }

        void Replan(object sender, EventArgs e) {
            WipeAll();
            bestMatchDistance = 100000;
            if (speakerCount.Value == 0) {
                systemImpedance.Text = "System impedance: 0 Ω";
                systemVoltage.Text = "System voltage: 0 V";
                systemCurrent.Text = "System current: 0 A";
                return;
            }
            Plan(new int[(int)speakerCount.Value], 0, (int)speakerCount.Value);
            double ampVoltage = Math.Sqrt((double)amplifierLoad.Value * bestMatchImpedance), ampCurrent = ampVoltage / bestMatchImpedance;
            systemImpedance.Text = string.Format("System impedance: {0} Ω", bestMatchImpedance.ToString("0.00"));
            systemVoltage.Text = string.Format("System voltage: {0} V", ampVoltage.ToString("0.00"));
            systemCurrent.Text = string.Format("System current: {0} A", ampCurrent.ToString("0.00"));
            wiringPlan.Visible = false;
            for (int i = 0; i < bestMatch.Length; ++i) {
                if (bestMatch[i] == 0)
                    break;
                GroupBox layer = new GroupBox {
                    Parent = wiringPlan,
                    BackColor = colors[i % colors.Length],
                    Text = string.Format("Layer {0} ({1} spk.)", i + 1, bestMatch[i]),
                    Width = 100,
                    Height = bestMatch[i] * 48 + 25,
                    Left = i * 110
                };
                double layerImpedance = (double)speakerImpedance.Value / bestMatch[i], layerVoltage = ampCurrent * layerImpedance,
                    layerCurrent = ampCurrent / bestMatch[i];
                string voltageText = string.Format("U = {0} V", layerVoltage.ToString("0.00")),
                    currentText = string.Format("I = {0} A", layerCurrent.ToString("0.00")),
                    wattageText = string.Format("P = {0} W", (layerVoltage * layerCurrent).ToString("0.00"));
                for (int j = 0; j < bestMatch[i]; ++j) {
                    Panel speaker = new Panel {
                        Parent = layer,
                        BackColor = Color.LightSlateGray,
                        Width = 80,
                        Height = 43,
                        Left = 10,
                        Top = j * 48 + 20
                    };
                    Label voltage = new Label {
                        Parent = speaker,
                        Width = 74,
                        Height = 13,
                        Left = 3,
                        Top = 2,
                        Text = voltageText
                    };
                    Label current = new Label {
                        Parent = speaker,
                        Width = 74,
                        Height = 13,
                        Left = 3,
                        Top = 15,
                        Text = currentText
                    };
                    Label wattage = new Label {
                        Parent = speaker,
                        Width = 74,
                        Height = 13,
                        Left = 3,
                        Top = 28,
                        Text = wattageText
                    };
                }
            }
            wiringPlan.Visible = true;
        }

        void WipeAll() {
            wiringPlan.Visible = false;
            foreach (Control child in wiringPlan.Controls)
                child.Dispose();
            wiringPlan.Controls.Clear();
            wiringPlan.Visible = true;
        }

        void VoidX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("http://en.sbence.hu");
    }
}