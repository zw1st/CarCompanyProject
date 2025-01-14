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

public partial class FormBrandViewer : Form
{
    private readonly IUnityContainer _container;
    private readonly BrandImplementation _brandImplementation;

    public FormBrandViewer(IUnityContainer container, BrandImplementation brandImplementation)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _brandImplementation = brandImplementation ?? throw new ArgumentNullException(nameof(brandImplementation));
    }

    private void FormBrandsViewer_Load(object sender, EventArgs e)
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
            _container.Resolve<FormBrand>().ShowDialog();
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
            var form = _container.Resolve<FormBrand>();
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
            _brandImplementation.Delete(findId);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList(string? brandName = null, string? country = null) => dataGridView1.DataSource =
        _brandImplementation.ReadAll(brandName, country);

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
            var searchForm = _container.Resolve<FormSearchBrand>();

            // Подписываемся на событие перед открытием формы
            searchForm.SearchBrand += GetSearchBrand;

            // Открываем форму как диалог
            searchForm.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void GetSearchBrand(string? brandName = null, string? country = null)
    {
        LoadList(brandName, country);
    }

    private void buttonReset_Click(object sender, EventArgs e)
    {
        LoadList();
    }
}