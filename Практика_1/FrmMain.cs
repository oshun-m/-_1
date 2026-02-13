using System.Drawing;
using System.Windows.Forms;

namespace Практика_1
{
    public class FrmMain : Form
    {
        private Button btnCars = null!;
        private Button btnListBox = null!;
        private Button btnMenu = null!;
        private Button btnExit = null!;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Практическая работа №1 — меню";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(520, 260);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            var title = new Label
            {
                Text = "Выбери задание:",
                AutoSize = true,
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                Location = new Point(16, 16)
            };
            Controls.Add(title);

            btnCars = new Button
            {
                Name = "btnCars",
                Text = "1) Вариант №2: Машины (навстречу друг другу)",
                Size = new Size(480, 40),
                Location = new Point(16, 55)
            };
            btnCars.Click += (s, e) => new FrmCars().ShowDialog(this);

            btnListBox = new Button
            {
                Name = "btnListBox",
                Text = "2) Цвет TextBox через ListBox (Items добавляются в Load)",
                Size = new Size(480, 40),
                Location = new Point(16, 105)
            };
            btnListBox.Click += (s, e) => new FrmListBoxColors().ShowDialog(this);

            btnMenu = new Button
            {
                Name = "btnMenu",
                Text = "3) Цвет TextBox через MenuStrip (+ Enabled=false после выбора)",
                Size = new Size(480, 40),
                Location = new Point(16, 155)
            };
            btnMenu.Click += (s, e) => new FrmMenuColors().ShowDialog(this);

            btnExit = new Button
            {
                Name = "btnExit",
                Text = "Выход",
                Size = new Size(140, 35),
                Location = new Point(356, 210)
            };
            btnExit.Click += (s, e) => Close();

            Controls.Add(btnCars);
            Controls.Add(btnListBox);
            Controls.Add(btnMenu);
            Controls.Add(btnExit);
        }
    }
}
