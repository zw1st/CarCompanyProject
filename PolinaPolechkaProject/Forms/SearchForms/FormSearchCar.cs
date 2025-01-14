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

namespace PolinaPolechkaProject.Forms.SearchForms;

public partial class FormSearchCar : Form
{
    public event Action<int?, int?, int?, int?, DateTime?, DateTime?, int?, int?, Entities.DriveType?, bool?> SearchImage;

    public FormSearchCar(BrandImplementation brandImplementation, FactoryImplementation factoryImplementation, OwnerImplementation owner, CarShopImplementation carShopImplementation)
    {
        InitializeComponent();
        comboBoxBrand.DataSource = brandImplementation.ReadAll();
        comboBoxBrand.DisplayMember = "BrandName";
        comboBoxBrand.ValueMember = "Id";

        comboBoxCarShop.DataSource = carShopImplementation.ReadAll();
        comboBoxCarShop.DisplayMember = "ShopName";
        comboBoxCarShop.ValueMember = "Id";

        comboBoxFactory.DataSource = factoryImplementation.ReadAll();
        comboBoxFactory.DisplayMember = "Name";
        comboBoxFactory.ValueMember = "Id";

        comboBoxOwner.DataSource = owner.ReadAll();
        comboBoxOwner.DisplayMember = "FullName";
        comboBoxOwner.ValueMember = "Id";

        comboBoxDrive.DataSource = Enum.GetValues(typeof(Entities.DriveType));
    }


    private void buttonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            int? factoryId = comboBoxFactory.SelectedValue as int?;
            int? carShopId = comboBoxCarShop.SelectedValue as int?;
            int? brandId = comboBoxBrand.SelectedValue as int?;
            int? ownerId = comboBoxOwner.SelectedValue as int?;
            DateTime? releaseYearMin = dateTimePickerReleaseYearFrom.Value;
            DateTime? releaseYearMax = dateTimePickerReleaseYearTo.Value;
            int? priceMin = (int?)numericUpDownPriceFrom.Value;
            int? priceMax = (int?)numericUpDownPriceTo.Value;
            Entities.DriveType? driveType = comboBoxDrive.SelectedItem as Entities.DriveType?;
            bool? isAutomatic = checkBoxAuto.Checked;


            SearchImage?.Invoke(factoryId, carShopId, brandId, ownerId, releaseYearMin, releaseYearMax, priceMin, priceMax, driveType, isAutomatic);

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при поиске",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e) => Close();
}
