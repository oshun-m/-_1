using System.Drawing;
using System.Windows.Forms;

namespace Практика_1
{
    public class FrmListBoxColors : Form
    {
        private TextBox txt = null!;
        private ListBox lst = null!;
        private Button btnExit = null!;

        public FrmListBoxColors()
        {
            AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            Load += FrmListBoxColors_Load;
        }

        private void InitializeComponent()
        {
            Text = "ListBox and Colors";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(520, 260);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            lst = new ListBox
            {
                Name = "lst",
                Size = new Size(200, 120),
                Location = new Point(20, 20)
            };
            lst.SelectedIndexChanged += lst_SelectedIndexChanged;

            txt = new TextBox
            {
                Name = "txt",
                Size = new Size(180, 24),
                Location = new Point(20, 175)
            };

            btnExit = new Button
            {
                Name = "btnExit",
                Text = "Выход",
                Size = new Size(120, 35),
                Location = new Point(360, 170)
            };
            btnExit.Click += (s, e) => Close();

            Controls.Add(lst);
            Controls.Add(txt);
            Controls.Add(btnExit);
        }

        private void FrmListBoxColors_Load(object? sender, System.EventArgs e)
        {
            lst.Items.Clear();
            lst.Items.Add("черный");
            lst.Items.Add("красный");
            lst.Items.Add("синий");
            lst.Items.Add("зеленый");
        }

        private void lst_SelectedIndexChanged(object? sender, System.EventArgs e)
        {
            if (lst.SelectedItem == null) return;

            string item = lst.SelectedItem.ToString()!;

            if (item == "черный")
            {
                txt.BackColor = Color.Black;
                txt.ForeColor = Color.White;
            }
            else if (item == "красный")
            {
                txt.BackColor = Color.Red;
                txt.ForeColor = Color.White;
            }
            else if (item == "синий")
            {
                txt.BackColor = Color.Blue;
                txt.ForeColor = Color.White;
            }
            else if (item == "зеленый")
            {
                txt.BackColor = Color.Green;
                txt.ForeColor = Color.White;
            }
        }
    }
}
