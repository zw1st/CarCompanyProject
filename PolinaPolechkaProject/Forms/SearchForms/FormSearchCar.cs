using PolinaPolechkaProject.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PolinaPolechkaProject.Forms.SearchForms;

public partial class FormSearchCar : Form
{
    public event Action<string?, string?, string?, string?, DateTime?, DateTime?, int?, int?, Entities.DriveType, bool?> SearchImage;

    public FormSearchCar(BrandImplementation brandImplementation, FactoryImplementation factoryImplementation, OwnerImplementation owner, CarShopImplementation carShopImplementation)
    {
        InitializeComponent();
        comboBoxDrive.DataSource = Enum.GetValues(typeof(Entities.DriveType));
        comboBoxAuto.DataSource = Enum.GetValues(typeof(Entities.AutoType));
    }


    private void buttonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            string? factoryId = textBoxFactory.Text;
            string? brandId = textBoxBrand.Text;
            string? ownerId = textBoxOwner.Text;
            string? carShopId = textBoxCarShop.Text;


            DateTime? releaseYearMin = dateTimePickerReleaseYearFrom.Value;
            DateTime? releaseYearMax = dateTimePickerReleaseYearTo.Value;

            int? priceMin = (int)numericUpDownPriceFrom.Value;
            int? priceMax = (int)numericUpDownPriceTo.Value;

            Entities.DriveType driveType = (Entities.DriveType)comboBoxDrive.SelectedItem;
            bool? isAutomatic = null;
            if (comboBoxAuto.SelectedItem != null) // Проверяем, что выбранный элемент не null
            {
                if ((AutoType)comboBoxAuto.SelectedItem == AutoType.Auto)
                {
                    isAutomatic = true;
                }
                else if ((AutoType)comboBoxAuto.SelectedItem == AutoType.NotAuto)
                {
                    isAutomatic = false;
                }
                else
                {
                    isAutomatic = null; // Если выбрано что-то другое, оставляем null
                }
            }


            SearchImage?.Invoke(factoryId, carShopId, brandId, ownerId, releaseYearMin, releaseYearMax, priceMin, priceMax, (Entities.DriveType)driveType, isAutomatic);

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
