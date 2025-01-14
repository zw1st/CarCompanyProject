using PolinaPolechkaProject.Entities;
using PolinaPolechkaProject.Interfaces;
using PolinaPolechkaProject.Interfaces.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriveType = PolinaPolechkaProject.Entities.DriveType;

namespace PolinaPolechkaProject.Forms;

public partial class FormCar : Form
{
    private readonly IOperations<Car> _carOperations;
    private int? _carId;
    public int Id
    {
        set
        {
            try
            {
                var car = _carOperations.ReadById(value);
                if (car == null)
                {
                    throw new InvalidDataException(nameof(car));
                }
                if (comboBoxBrand.DataSource == null || comboBoxCarShop.DataSource == null ||
                    comboBoxDrive.DataSource == null || comboBoxFactory.DataSource == null ||
                    comboBoxOwner.DataSource == null)
                {
                    throw new InvalidOperationException("Источники данных для комбобоксов не установлены.");
                }
                comboBoxBrand.SelectedValue = car.BrandId;
                comboBoxCarShop.SelectedValue = car.CarShopId;
                comboBoxFactory.SelectedValue = car.FactoryId;
                comboBoxOwner.SelectedValue = car.OwnerId;




                numericUpDownPrice.Value = car.Price;
                dateTimePickerReleaseYear.Value = car.ReleaseYear;
                checkBoxAuto.Checked = car.IsAutomatic;

                _carId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }


    public FormCar(IOperations<Car> carOperations, OwnerImplementation ownerImplementation, BrandImplementation brandImplementation, FactoryImplementation fact,
        CarShopImplementation carShopImplementation)
    {
        InitializeComponent();

        comboBoxBrand.DataSource = brandImplementation.ReadAll();
        comboBoxBrand.DisplayMember = "BrandName";
        comboBoxBrand.ValueMember = "Id";

        comboBoxOwner.DataSource = ownerImplementation.ReadAll();
        comboBoxOwner.DisplayMember = "FullName"; 
        comboBoxOwner.ValueMember = "Id";

        comboBoxFactory.DataSource = fact.ReadAll();
        comboBoxFactory.DisplayMember = "Name";
        comboBoxFactory.ValueMember = "Id";

        comboBoxCarShop.DataSource = carShopImplementation.ReadAll();
        comboBoxCarShop.DisplayMember = "ShopName";
        comboBoxCarShop.ValueMember = "Id";

        comboBoxDrive.DataSource = Enum.GetValues(typeof(DriveType));

        _carOperations = carOperations ?? throw new ArgumentNullException(nameof(carOperations));
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            //if ()
            //{
            //    throw new Exception("Имеются незаполненные поля");
            //}
            if (_carId.HasValue)
            {
                _carOperations.Update(CreateCar(_carId.Value));
            }
            else
            {
                _carOperations.Create(CreateCar(0));
            }
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e) => Close();

    private Car CreateCar(int id)
    {
        return Car.CreateCar(id, (int)comboBoxFactory.SelectedValue!, (int)comboBoxCarShop.SelectedValue!, (int)comboBoxBrand.SelectedValue!, (int)comboBoxOwner.SelectedValue!, dateTimePickerReleaseYear.Value, (int)numericUpDownPrice.Value, (DriveType)comboBoxDrive.SelectedValue, checkBoxAuto.Checked);
    }
}
