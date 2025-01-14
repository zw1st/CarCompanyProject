using PolinaPolechkaProject.Forms.SearchForms;
using PolinaPolechkaProject.Interfaces.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PolinaPolechkaProject.Forms.Tables;

public partial class FormFactoryViewer : Form
{
    private readonly IUnityContainer _container;
    private readonly FactoryImplementation _factoryImplementation;


    public FormFactoryViewer(IUnityContainer container, FactoryImplementation factoryImplementation)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _factoryImplementation = factoryImplementation ?? throw new ArgumentNullException(nameof(factoryImplementation));

    }

    private void FormFactoryViewer_Load(object sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormFactory>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonUpd_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }
        try
        {
            var form = _container.Resolve<FormFactory>();
            form.Id = findId;
            form.ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при изменении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonDel_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }
        if (MessageBox.Show("Удалить запись?", "Удаление",
        MessageBoxButtons.YesNo) != DialogResult.Yes)
        {
            return;
        }
        try
        {
            _factoryImplementation.Delete(findId);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList(string? Name = null, string? Adress = null, DateTime? dateFrom = null, DateTime? dateTo = null) => dataGridView1.DataSource =
   _factoryImplementation.ReadAll(Name, Adress, dateFrom, dateTo);

    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridView1.SelectedRows.Count < 1)
        {
            MessageBox.Show("Нет выбранной записи", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
        return true;
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            var searchForm = _container.Resolve<FormSearchFactory>();

            // Подписываемся на событие перед открытием формы
            searchForm.SearchImage += GetSearchImage;

            // Открываем форму как диалог
            searchForm.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void GetSearchImage(string? FactoryName = null, string? adress = null, DateTime? dateFrom = null, DateTime? dateTo = null)
    {
        LoadList(FactoryName, adress, dateFrom, dateTo);
    }

    private void buttonReset_Click(object sender, EventArgs e)
    {
        LoadList();
    }
}
