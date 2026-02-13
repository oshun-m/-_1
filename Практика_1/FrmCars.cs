using System;
using System.Drawing;
using System.Windows.Forms;

namespace Практика_1
{
    public class FrmCars : Form
    {
        private TextBox txtV1 = null!;
        private TextBox txtV2 = null!;
        private TextBox txtS = null!;
        private TextBox txtT = null!;
        private TextBox txtD = null!;

        private Button btnCount = null!;
        private Button btnExit = null!;

        public FrmCars()
        {
            AutoScaleMode = AutoScaleMode.None;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Вариант №2 — Машины навстречу";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(820, 260);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            int topY = 35;
            int boxW = 140;
            int boxH = 24;
            int gapX = 25;

            int x1 = 35;
            int x2 = x1 + boxW + gapX;
            int x3 = x2 + boxW + gapX;
            int x4 = x3 + boxW + gapX;
            int x5 = x4 + boxW + gapX; 

            Controls.Add(MakeSmallLabel("V1", x1, topY - 18));
            Controls.Add(MakeSmallLabel("V2", x2, topY - 18));
            Controls.Add(MakeSmallLabel("S", x3, topY - 18));
            Controls.Add(MakeSmallLabel("T", x4, topY - 18));
            Controls.Add(MakeSmallLabel("D", x5, topY - 18));

            txtV1 = MakeTextBox("txtV1", "0", x1, topY, boxW, boxH);
            txtV2 = MakeTextBox("txtV2", "0", x2, topY, boxW, boxH);
            txtS = MakeTextBox("txtS", "0", x3, topY, boxW, boxH);
            txtT = MakeTextBox("txtT", "0", x4, topY, boxW, boxH);
            txtD = MakeTextBox("txtD", "", x5, topY, boxW, boxH);
            txtD.ReadOnly = true;

            Controls.AddRange(new Control[] { txtV1, txtV2, txtS, txtT, txtD });

            btnCount = new Button
            {
                Name = "btnCount",
                Text = "Вычислить",
                Size = new Size(170, 35),
                Location = new Point(330, 165)
            };
            btnCount.Click += btnCount_Click;

            btnExit = new Button
            {
                Name = "btnExit",
                Text = "Выход",
                Size = new Size(120, 35),
                Location = new Point(620, 165)
            };
            btnExit.Click += (s, e) => Close();

            Controls.Add(btnCount);
            Controls.Add(btnExit);

            var hint = new Label
            {
                AutoSize = true,
                Location = new Point(35, 210),
                Text = "Формула: D = | S - T*(V1+V2) |"
            };
            Controls.Add(hint);
        }

        private static Label MakeSmallLabel(string text, int x, int y)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Location = new Point(x, y)
            };
        }

        private static TextBox MakeTextBox(string name, string text, int x, int y, int w, int h)
        {
            return new TextBox
            {
                Name = name,
                Text = text,
                Size = new Size(w, h),
                Location = new Point(x, y)
            };
        }

        private void btnCount_Click(object? sender, EventArgs e)
        {
            if (!ParseUtil.TryParseDoubleFlexible(txtV1.Text, out double v1) ||
                !ParseUtil.TryParseDoubleFlexible(txtV2.Text, out double v2) ||
                !ParseUtil.TryParseDoubleFlexible(txtS.Text, out double sVal) ||
                !ParseUtil.TryParseDoubleFlexible(txtT.Text, out double tVal))
            {
                MessageBox.Show("Ошибка ввода. Проверь, что все поля — числа.",
                    "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double d = Math.Abs(sVal - tVal * (v1 + v2));
            txtD.Text = d.ToString();
        }
    }
}
