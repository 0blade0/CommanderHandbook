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

        SeedData();

        ShowAll();
    }

    private void SeedData()
    {
        _manager.AddSoldier(new Officer { LastName = "Коноваленко", FirstName = "Олексій", Rank = "Майор", Unit = "Штаб", Education = "Військова Академія" });
        _manager.AddSoldier(new Conscript { LastName = "Аваров", FirstName = "Дмитро", Rank = "Рядовий", Unit = "1 рота", TermOfService = 12 });
        _manager.AddSoldier(new Officer { LastName = "Бондаренко", FirstName = "Ігор", Rank = "Капітан", Unit = "2 взвод", Education = "ХНУРЕ" });
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

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
  
    }
    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Функція видалення буде реалізована в наступному кроці.");
    }
}