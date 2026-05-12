using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommanderHandbook
{
    public class AddForm : Form
    {
        public Soldier? NewSoldier { get; private set; }
        private Soldier? _soldierToEdit;

        private TextBox txtLastName = new() { Width = 250 };
        private TextBox txtFirstName = new() { Width = 250 };
        private TextBox txtPatronymic = new() { Width = 250 };
        private ComboBox cmbRank = new() { Width = 250, DropDownStyle = ComboBoxStyle.DropDown };
        private DateTimePicker dtpRankDate = new() { Width = 250 };
        private TextBox txtPosition = new() { Width = 250 };
        private TextBox txtUnit = new() { Width = 250 };
        private ComboBox cmbServiceForm = new() { Width = 250, DropDownStyle = ComboBoxStyle.DropDownList };
        private TextBox txtServicePeriod = new() { Width = 250 };
        private TextBox txtCivilianProf = new() { Width = 250 };
        private TextBox txtParentsAddress = new() { Width = 250 };
        private TextBox txtCharacter = new() { Width = 250, Multiline = true, Height = 60 };
        private TextBox txtAttitude = new() { Width = 250 };
        private ComboBox cmbType = new() { Width = 250, DropDownStyle = ComboBoxStyle.DropDownList };
        private Button btnSave = new() { Text = "Зберегти", Width = 250, Height = 40, BackColor = Color.LightGreen, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
        public AddForm(Soldier? editSoldier = null)
        {
            _soldierToEdit = editSoldier;


            Text = _soldierToEdit == null ? "Новий військовослужбовець" : "Редагування анкети";
            Size = new Size(350, 600);
            StartPosition = FormStartPosition.CenterParent;

            FlowLayoutPanel panel = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, Padding = new Padding(20), AutoScroll = true, WrapContents = false };

            cmbRank.Items.AddRange(new[] { "Рядовий", "Старший солдат", "Сержант", "Молодший лейтенант", "Лейтенант", "Капітан", "Майор", "Підполковник", "Полковник" });
            cmbServiceForm.Items.AddRange(new[] { "Термінова", "Контрактна", "Кадрова", "За мобілізацією" });
            cmbType.Items.AddRange(new[] { "Строковик", "Офіцер" });
            cmbType.SelectedIndex = 0;

            AddLabeledControl(panel, "Тип:", cmbType);
            AddLabeledControl(panel, "Прізвище:", txtLastName);
            AddLabeledControl(panel, "Ім'я:", txtFirstName);
            AddLabeledControl(panel, "По батькові:", txtPatronymic);
            AddLabeledControl(panel, "Звання:", cmbRank);
            AddLabeledControl(panel, "Дата звання:", dtpRankDate);
            AddLabeledControl(panel, "Посада:", txtPosition);
            AddLabeledControl(panel, "Підрозділ:", txtUnit);
            AddLabeledControl(panel, "Форма служби:", cmbServiceForm);
            AddLabeledControl(panel, "Період служби:", txtServicePeriod);
            AddLabeledControl(panel, "Цивільна професія:", txtCivilianProf);
            AddLabeledControl(panel, "Адреса батьків:", txtParentsAddress);
            AddLabeledControl(panel, "Характер:", txtCharacter);
            AddLabeledControl(panel, "Ставлення до служби:", txtAttitude);

            panel.Controls.Add(btnSave);
            Controls.Add(panel);

            btnSave.Click += BtnSave_Click;

            if (_soldierToEdit != null)
            {
                txtLastName.Text = _soldierToEdit.LastName;
                txtFirstName.Text = _soldierToEdit.FirstName;
                txtPatronymic.Text = _soldierToEdit.Patronymic;
                cmbRank.Text = _soldierToEdit.Rank;
                if (_soldierToEdit.RankDate >= dtpRankDate.MinDate && _soldierToEdit.RankDate <= dtpRankDate.MaxDate)
                    dtpRankDate.Value = _soldierToEdit.RankDate;
                txtPosition.Text = _soldierToEdit.Position;
                txtUnit.Text = _soldierToEdit.Unit;
                cmbServiceForm.Text = _soldierToEdit.ServiceForm;
                txtServicePeriod.Text = _soldierToEdit.ServicePeriod;
                txtCivilianProf.Text = _soldierToEdit.CivilianProfession;
                txtParentsAddress.Text = _soldierToEdit.ParentsAddress;
                txtCharacter.Text = _soldierToEdit.CharacterTraits;
                txtAttitude.Text = _soldierToEdit.AttitudeToService;

                cmbType.SelectedItem = _soldierToEdit is Officer ? "Офіцер" : "Строковик";
                cmbType.Enabled = false;
            }
        }

        private void AddLabeledControl(Panel p, string labelText, Control c)
        {
            p.Controls.Add(new Label { Text = labelText, AutoSize = true, Margin = new Padding(0, 10, 0, 0) });
            p.Controls.Add(c);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Введіть хоча б прізвище!");
                return;
            }

            if (_soldierToEdit == null)
            {
                if (cmbType.SelectedItem?.ToString() == "Офіцер") NewSoldier = new Officer();
                else NewSoldier = new Conscript();
            }
            else
            {
                NewSoldier = _soldierToEdit;
            }

            NewSoldier.LastName = txtLastName.Text;
            NewSoldier.FirstName = txtFirstName.Text;
            NewSoldier.Patronymic = txtPatronymic.Text;
            NewSoldier.Rank = cmbRank.Text;
            NewSoldier.RankDate = dtpRankDate.Value;
            NewSoldier.Position = txtPosition.Text;
            NewSoldier.Unit = txtUnit.Text;
            NewSoldier.ServiceForm = cmbServiceForm.Text;
            NewSoldier.ServicePeriod = txtServicePeriod.Text;
            NewSoldier.CivilianProfession = txtCivilianProf.Text;
            NewSoldier.ParentsAddress = txtParentsAddress.Text;
            NewSoldier.CharacterTraits = txtCharacter.Text;
            NewSoldier.AttitudeToService = txtAttitude.Text;

            DialogResult = DialogResult.OK;
        }
    }
}