using System.Drawing;
using System.Windows.Forms;

namespace Практика_1
{
    public class FrmMenuColors : Form
    {
        private TextBox txt = null!;
        private MenuStrip menuStrip1 = null!;
        private Button btnExit = null!;

        public FrmMenuColors()
        {
            AutoScaleMode = AutoScaleMode.None;

            InitializeComponent();
            BuildMenu(); 
        }

        private void InitializeComponent()
        {
            Text = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(820, 260);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            menuStrip1 = new MenuStrip
            {
                Name = "menuStrip1",
                Dock = DockStyle.Top
            };
            Controls.Add(menuStrip1);

            txt = new TextBox
            {
                Name = "txt",
                Text = "проверь цвет",
                Size = new Size(520, 24),
                Location = new Point(150, 170)
            };
            Controls.Add(txt);

            btnExit = new Button
            {
                Name = "btnExit",
                Text = "Выход",
                Size = new Size(120, 35),
                Location = new Point(650, 165)
            };
            btnExit.Click += (s, e) => Close();
            Controls.Add(btnExit);
        }

        private void BuildMenu()
        {
            menuStrip1.Items.Clear();

            var colorMenu = new ToolStripMenuItem("Цвет");

            var blackItem = new ToolStripMenuItem("Черный");
            var redItem = new ToolStripMenuItem("Красный");
            var blueItem = new ToolStripMenuItem("Синий");
            var greenItem = new ToolStripMenuItem("Зеленый");

            blackItem.Click += (s, e) => ApplyColor(Color.Black, Color.White, blackItem);
            redItem.Click += (s, e) => ApplyColor(Color.Red, Color.White, redItem);
            blueItem.Click += (s, e) => ApplyColor(Color.Blue, Color.White, blueItem);
            greenItem.Click += (s, e) => ApplyColor(Color.Green, Color.White, greenItem);

            colorMenu.DropDownItems.Add(blackItem);
            colorMenu.DropDownItems.Add(redItem);
            colorMenu.DropDownItems.Add(blueItem);
            colorMenu.DropDownItems.Add(greenItem);

            menuStrip1.Items.Add(colorMenu);
        }

        private void ApplyColor(Color back, Color fore, ToolStripMenuItem clickedItem)
        {
            txt.BackColor = back;
            txt.ForeColor = fore;
            clickedItem.Enabled = false; // по заданию
        }
    }
}
