using System;
using System.Collections.Generic;
using System.Text;

namespace CommanderHandbook
{
    public class AddForm : Form
    {
        public Soldier? NewSoldier { get; private set; }

        private TextBox txtLastName = new TextBox { Location = new Point(20, 40), Width = 200 };
        private TextBox txtFirstName = new TextBox { Location = new Point(20, 90), Width = 200 };
        private ComboBox cmbType = new ComboBox { Location = new Point(20, 140), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
        private Button btnSave = new Button { Text = "Зберегти", Location = new Point(20, 190), Width = 200, BackColor = Color.LightGreen };

        public AddForm()
        {
            Text = "Додати бійця";
            Size = new Size(260, 280);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            cmbType.Items.AddRange(["Офіцер", "Строковик"]);
            cmbType.SelectedIndex = 0;

            Controls.Add(new Label { Text = "Прізвище:", Location = new Point(20, 20), AutoSize = true });
            Controls.Add(txtLastName);
            Controls.Add(new Label { Text = "Ім'я:", Location = new Point(20, 70), AutoSize = true });
            Controls.Add(txtFirstName);
            Controls.Add(new Label { Text = "Категорія:", Location = new Point(20, 120), AutoSize = true });
            Controls.Add(cmbType);
            Controls.Add(btnSave);

            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Будь ласка, заповніть Прізвище та Ім'я!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbType.SelectedItem?.ToString() == "Офіцер")
            {
                NewSoldier = new Officer { LastName = txtLastName.Text, FirstName = txtFirstName.Text, Unit = "Нове поповнення", Rank = "Молодший лейтенант" };
            }
            else
            {
                NewSoldier = new Conscript { LastName = txtLastName.Text, FirstName = txtFirstName.Text, Unit = "Нове поповнення", Rank = "Рядовий", TermOfService = 12 };
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}