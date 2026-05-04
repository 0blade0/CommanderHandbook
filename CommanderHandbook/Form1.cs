using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CommanderHandbook;

public partial class Form1 : Form
{
    // Створюємо менеджер, який ми описували в розділі 2
    private readonly HandbookManager _manager = new();

    public Form1()
    {
        InitializeComponent();

        // Додамо пару бійців для перевірки, поки немає вікна додавання
        SeedData();

        // Відобразимо їх у таблиці при старті
        ShowAll();
    }

    private void SeedData()
    {
        _manager.AddSoldier(new Officer { LastName = "Коваленко", FirstName = "Олексій", Rank = "Майор", Unit = "Штаб", Education = "Військова Академія" });
        _manager.AddSoldier(new Conscript { LastName = "Абраменко", FirstName = "Дмитро", Rank = "Рядовий", Unit = "1 рота", TermOfService = 12 });
        _manager.AddSoldier(new Officer { LastName = "Бондар", FirstName = "Ігор", Rank = "Капітан", Unit = "2 взвод", Education = "ХНУРЕ" });
    }

    // Метод для оновлення таблиці
    private void UpdateGrid(object data)
    {
        // dataGridView1 — перевір, як називається твоя таблиця в Properties (може бути dgvSoldiers)
        dgvSoldiers.DataSource = null;
        dgvSoldiers.DataSource = data;
    }

    private void ShowAll() => UpdateGrid(_manager.SortByAlphabet());

    // --- ОБРОБКА КНОПОК ---

    private void btnAll_Click(object sender, EventArgs e) => ShowAll();

    private void btnOfficers_Click(object sender, EventArgs e)
        => UpdateGrid(_manager.GetOfficers());

    private void btnConscripts_Click(object sender, EventArgs e)
        => UpdateGrid(_manager.GetConscripts());

    private void btnSort_Click(object sender, EventArgs e) => ShowAll();

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        // Пошук за прізвищем (LINQ запит прямо тут)
        // Перевір ім'я свого TextBox у Properties (має бути txtSearch)
    }
    // Метод для загрузки формы
    private void Form1_Load(object sender, EventArgs e)
    {
        // Пока оставляем пустым
    }

    // Метод для кнопки удаления
    private void btnDelete_Click(object sender, EventArgs e)
    {
        // Сюда позже добавим логику удаления выбранного бойца
        MessageBox.Show("Функция удаления будет реализована в следующем шаге.");
    }
}