using PolinaPolechkaProject.Entities;
using PolinaPolechkaProject.Forms.SearchForms;
using PolinaPolechkaProject.Interfaces;
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

public partial class FormCarsViewer : Form
{
    private readonly IUnityContainer _container;
    private readonly CarImplementation _carImplementation;


    public FormCarsViewer(IUnityContainer container, CarImplementation countryRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _carImplementation = countryRepository ?? throw new ArgumentNullException(nameof(countryRepository));

    }

    private void FormCars_Load(object sender, EventArgs e)
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
            _container.Resolve<FormCar>().ShowDialog();
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

            var form = _container.Resolve<FormCar>();
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
            _carImplementation.Delete(findId);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList(int? factoryId = null, int? carShopId = null, int? brandId = null, int? ownerId = null,
                                 DateTime? releaseYearMin = null, DateTime? releaseYearMax = null,
                                 int? priceMin = null, int? priceMax = null,
                                 Entities.DriveType? driveType = null, bool? isAutomatic = null)
    {
        dataGridView1.DataSource = _carImplementation.ReadAll(factoryId, carShopId, brandId, ownerId, releaseYearMin, releaseYearMax, priceMin, priceMax, driveType, isAutomatic);
        dataGridView1.Columns["OwnerId"].Visible = false;
        dataGridView1.Columns["BrandId"].Visible = false;
        dataGridView1.Columns["CarShopId"].Visible = false;
        dataGridView1.Columns["FactoryId"].Visible = false;
    }

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
            var searchForm = _container.Resolve<FormSearchCar>();


            searchForm.SearchImage += GetSearchImage;


            searchForm.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void GetSearchImage(int? factoryId = null, int? carShopId = null, int? brandId = null, int? ownerId = null,
                                 DateTime? releaseYearMin = null, DateTime? releaseYearMax = null,
                                 int? priceMin = null, int? priceMax = null,
                                 Entities.DriveType? driveType = null, bool? isAutomatic = null)
    {
        LoadList(factoryId, carShopId, brandId, ownerId, releaseYearMin, releaseYearMax, priceMin, priceMax, driveType, isAutomatic); ;
    }

    private void buttonReset_Click(object sender, EventArgs e)
    {
        LoadList();
    }
}
