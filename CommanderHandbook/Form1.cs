using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CommanderHandbook;

public partial class Form1 : Form
{
    private readonly HandbookManager _manager = new();

    public Form1()
    {
        InitializeComponent();
        txtSearch.TextChanged += txtSearch_TextChanged;

        SeedData();

        ShowAll();
    }

    private void SeedData()
    {
        _manager.AddSoldier(new Officer { LastName = "Коноваленко", FirstName = "Олексій", Patronymic = "Іванович", Rank = "Майор", Unit = "Штаб", Education = "Військова академія", ServiceYears = 10 });
        _manager.AddSoldier(new Officer { LastName = "Бондаренко", FirstName = "Ігор", Patronymic = "Петрович", Rank = "Капітан", Unit = "2 взвод", Education = "НАСВ", ServiceYears = 5 });
        _manager.AddSoldier(new Officer { LastName = "Шевченко", FirstName = "Андрій", Patronymic = "Миколайович", Rank = "Лейтенант", Unit = "1 рота", Education = "ХНУПС", ServiceYears = 1 });
        _manager.AddSoldier(new Officer { LastName = "Коваленко", FirstName = "Сергій", Patronymic = "Олександрович", Rank = "Підполковник", Unit = "Штаб", Education = "НАСВ", ServiceYears = 15 });
        _manager.AddSoldier(new Officer { LastName = "Бойко", FirstName = "Василь", Patronymic = "Володимирович", Rank = "Капітан", Unit = "3 рота", Education = "ЖВІ", ServiceYears = 8 });
        _manager.AddSoldier(new Officer { LastName = "Ткаченко", FirstName = "Михайло", Patronymic = "Сергійович", Rank = "Старший лейтенант", Unit = "2 рота", Education = "Військова академія", ServiceYears = 3 });
        _manager.AddSoldier(new Officer { LastName = "Кравченко", FirstName = "Олександр", Patronymic = "Вікторович", Rank = "Майор", Unit = "1 батальйон", Education = "НАСВ", ServiceYears = 12 });
        _manager.AddSoldier(new Officer { LastName = "Олійник", FirstName = "Дмитро", Patronymic = "Анатолійович", Rank = "Лейтенант", Unit = "Взвод зв'язку", Education = "ВІТІ", ServiceYears = 2 });
        _manager.AddSoldier(new Officer { LastName = "Макаренко", FirstName = "Роман", Patronymic = "Ігорович", Rank = "Капітан", Unit = "1 батальйон", Education = "ХНУПС", ServiceYears = 6 });
        _manager.AddSoldier(new Officer { LastName = "Тимошенко", FirstName = "Юрій", Patronymic = "Павлович", Rank = "Старший лейтенант", Unit = "3 рота", Education = "ВІТІ", ServiceYears = 4 });
        _manager.AddSoldier(new Officer { LastName = "Романенко", FirstName = "Олег", Patronymic = "Борисович", Rank = "Полковник", Unit = "Штаб бригади", Education = "НУОУ", ServiceYears = 20 });
        _manager.AddSoldier(new Officer { LastName = "Іщенко", FirstName = "Віталій", Patronymic = "Сергійович", Rank = "Лейтенант", Unit = "2 взвод", Education = "ЖВІ", ServiceYears = 1 });
        _manager.AddSoldier(new Officer { LastName = "Марченко", FirstName = "Денис", Patronymic = "Валерійович", Rank = "Майор", Unit = "Артилерійський дивізіон", Education = "НАСВ", ServiceYears = 11 });
        _manager.AddSoldier(new Officer { LastName = "Даниленко", FirstName = "Максим", Patronymic = "Олегович", Rank = "Капітан", Unit = "Взвод розвідки", Education = "Військова академія", ServiceYears = 7 });
        _manager.AddSoldier(new Officer { LastName = "Кузьменко", FirstName = "Антон", Patronymic = "Вікторович", Rank = "Молодший лейтенант", Unit = "1 рота", Education = "ХНУПС", ServiceYears = 1 });
        _manager.AddSoldier(new Officer { LastName = "Павлюк", FirstName = "Сергій", Patronymic = "Степанович", Rank = "Підполковник", Unit = "Штаб", Education = "НУОУ", ServiceYears = 16 });
        _manager.AddSoldier(new Officer { LastName = "Білоус", FirstName = "Руслан", Patronymic = "Григорович", Rank = "Майор", Unit = "Штаб", Education = "НАСВ", ServiceYears = 14 });
        _manager.AddSoldier(new Officer { LastName = "Гончаренко", FirstName = "Вадим", Patronymic = "Едуардович", Rank = "Лейтенант", Unit = "2 рота", Education = "ВІТІ", ServiceYears = 2 });

        _manager.AddSoldier(new Conscript { LastName = "Аваров", FirstName = "Дмитро", Patronymic = "Олегович", Rank = "Рядовий", Unit = "1 рота", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Мельник", FirstName = "Євген", Patronymic = "Андрійович", Rank = "Старший солдат", Unit = "2 рота", TermOfService = 18 });
        _manager.AddSoldier(new Conscript { LastName = "Волошин", FirstName = "Максим", Patronymic = "Ігорович", Rank = "Рядовий", Unit = "1 взвод", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Григоренко", FirstName = "Віктор", Patronymic = "Степанович", Rank = "Сержант", Unit = "3 рота", TermOfService = 24 });
        _manager.AddSoldier(new Conscript { LastName = "Лисенко", FirstName = "Роман", Patronymic = "Юрійович", Rank = "Рядовий", Unit = "1 батальйон", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Савченко", FirstName = "Павло", Patronymic = "Тарасович", Rank = "Старший солдат", Unit = "Взвод забезпечення", TermOfService = 18 });
        _manager.AddSoldier(new Conscript { LastName = "Мороз", FirstName = "Денис", Patronymic = "Васильович", Rank = "Рядовий", Unit = "2 рота", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Литвин", FirstName = "Олег", Patronymic = "Богданович", Rank = "Рядовий", Unit = "3 взвод", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Харченко", FirstName = "Юрій", Patronymic = "Михайлович", Rank = "Молодший сержант", Unit = "1 рота", TermOfService = 24 });
        _manager.AddSoldier(new Conscript { LastName = "Петренко", FirstName = "Богдан", Patronymic = "Віталійович", Rank = "Рядовий", Unit = "2 взвод", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Сидоренко", FirstName = "Тарас", Patronymic = "Григорович", Rank = "Старший солдат", Unit = "3 рота", TermOfService = 18 });
        _manager.AddSoldier(new Conscript { LastName = "Павленко", FirstName = "Володимир", Patronymic = "Олексійович", Rank = "Рядовий", Unit = "Взвод зв'язку", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Козак", FirstName = "Тарас", Patronymic = "Володимирович", Rank = "Рядовий", Unit = "1 рота", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Руденко", FirstName = "Микола", Patronymic = "Петрович", Rank = "Старший солдат", Unit = "2 рота", TermOfService = 18 });
        _manager.AddSoldier(new Conscript { LastName = "Клименко", FirstName = "Владислав", Patronymic = "Юрійович", Rank = "Рядовий", Unit = "3 рота", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Панченко", FirstName = "Артем", Patronymic = "Сергійович", Rank = "Рядовий", Unit = "1 взвод", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Левченко", FirstName = "Богдан", Patronymic = "Максимович", Rank = "Молодший сержант", Unit = "2 взвод", TermOfService = 24 });
        _manager.AddSoldier(new Conscript { LastName = "Степаненко", FirstName = "Євген", Patronymic = "Іванович", Rank = "Рядовий", Unit = "3 взвод", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Савчук", FirstName = "Олександр", Patronymic = "Дмитрович", Rank = "Старший солдат", Unit = "Взвод зв'язку", TermOfService = 18 });
        _manager.AddSoldier(new Conscript { LastName = "Грицюк", FirstName = "Михайло", Patronymic = "Васильович", Rank = "Рядовий", Unit = "Взвод забезпечення", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Прокопенко", FirstName = "Ігор", Patronymic = "Валерійович", Rank = "Сержант", Unit = "1 рота", TermOfService = 24 });
        _manager.AddSoldier(new Conscript { LastName = "Федоренко", FirstName = "Віктор", Patronymic = "Миколайович", Rank = "Рядовий", Unit = "2 рота", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Корнієнко", FirstName = "Станіслав", Patronymic = "Борисович", Rank = "Рядовий", Unit = "Взвод розвідки", TermOfService = 12 });
        _manager.AddSoldier(new Conscript { LastName = "Тарасенко", FirstName = "Марк", Patronymic = "Ігорович", Rank = "Старший солдат", Unit = "1 рота", TermOfService = 18 });
    }

    private void UpdateGrid(object data)
    {
        dgvSoldiers.DataSource = null;
        dgvSoldiers.DataSource = data;
    }

    private void ShowAll() => UpdateGrid(_manager.SortByAlphabet());

    private void btnAll_Click(object sender, EventArgs e) => ShowAll();

    private void btnOfficers_Click(object sender, EventArgs e)
        => UpdateGrid(_manager.GetOfficers());

    private void btnConscripts_Click(object sender, EventArgs e)
        => UpdateGrid(_manager.GetConscripts());

    private void btnSort_Click(object sender, EventArgs e) => ShowAll();

    private void txtSearch_TextChanged(object? sender, EventArgs e)
    {
        UpdateGrid(_manager.SearchByLastName(txtSearch.Text));
    }
    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvSoldiers.CurrentRow?.DataBoundItem is Soldier selectedSoldier)
        {
            _manager.DeleteSoldier(selectedSoldier);
            ShowAll();
        }else
        {
            MessageBox.Show("Спочатку виберіть бійця у таблиці!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using var addForm = new AddForm();

        if (addForm.ShowDialog() == DialogResult.OK && addForm.NewSoldier != null)
        {
            _manager.AddSoldier(addForm.NewSoldier);
            ShowAll();
        }
    }
}