using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Toothpick_patterns
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int iterations = 0;

        private Pen tpickPen, newTpickPen;
        private Graphics graphics;

        private readonly List<Toothpick> toothpicks;
        private readonly List<Toothpick> newToothpicks;

        public Form()
        {
            InitializeComponent();


            toothpicks = new List<Toothpick>();
            newToothpicks = new List<Toothpick>();

            tpickPen = new Pen(tpickColor.BackColor);
            newTpickPen = new Pen(newTpickColor.BackColor);
            canvasPanel.BackColor = backgroundColor.BackColor;
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {

            if (toothpicks.Count == 0)
            {
                int startX = (canvasPanel.Width/2) - ((int)tpickLength.Value/2);
                int startY = canvasPanel.Height/2;
                newToothpicks.Add(new Toothpick(startX, startY, (int)tpickLength.Value, true));
                tpickLength.Enabled = false;
            }
            else
                foreach (Toothpick tpick in toothpicks)
                    if (tpick.IsNew)
                    {
                        tpick.addToOpenEnds(toothpicks, newToothpicks);
                        tpick.IsNew = false;
                    }

            btnDraw.Enabled = false;
            canvasPanel.Refresh();
        }

        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {
            if (newToothpicks.Count == 0) return;

            toothpicks.AddRange(newToothpicks);
            newToothpicks.Clear();
            graphics = e.Graphics;

                foreach (var tpick in toothpicks)
                    if (tpick.IsNew)
                        graphics.DrawLine(newTpickPen, tpick.PtA, tpick.PtB);
                    else
                        graphics.DrawLine(tpickPen, tpick.PtA, tpick.PtB);


            iterations++;
            txtIterations.Text = iterations.ToString();
            txtNumOfTpicks.Text = toothpicks.Count.ToString();
            btnDraw.Enabled = true;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            toothpicks.Clear();
            iterations = 0;
            txtIterations.Text = iterations.ToString();
            txtNumOfTpicks.Text = toothpicks.Count.ToString();
            canvasPanel.Refresh();
            tpickLength.Enabled = true;
        }

        private void TxtTpickColor_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            this.colorDialog1 = new ColorDialog();
            this.colorDialog1.Color = txtBox.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
                    txtBox.BackColor = colorDialog1.Color;

            tpickPen = new Pen(tpickColor.BackColor);
            newTpickPen = new Pen(newTpickColor.BackColor);
            canvasPanel.BackColor = backgroundColor.BackColor;
        }

    }
}
