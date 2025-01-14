using PolinaPolechkaProject.Entities;
using PolinaPolechkaProject.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolinaPolechkaProject.Forms;

public partial class FormCarShop : Form
{
    private readonly IOperations<CarShop> _carShopOperations;
    private int? _carShopId;
    public int Id
    {
        set
        {
            try
            {
                var shop = _carShopOperations.ReadById(value);
                if (shop == null)
                {
                    throw new InvalidDataException(nameof(shop));
                }

                textBoxCarShopName.Text = shop.ShopName;
                numericUpDownGar.Value = shop.Guarantee;
                numericUpDownRating.Value = shop.Rating;
                _carShopId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }


    public FormCarShop(IOperations<CarShop> ownerOperations)
    {
        InitializeComponent();
        _carShopOperations = ownerOperations ?? throw new ArgumentNullException(nameof(ownerOperations));
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxCarShopName.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }
            if (_carShopId.HasValue)
            {
                _carShopOperations.Update(CreateCarShop(_carShopId.Value));
            }
            else
            {
                _carShopOperations.Create(CreateCarShop(0));
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

    private CarShop CreateCarShop(int id)
    {
        return Entities.CarShop.CreateCarShop(id, textBoxCarShopName.Text, (int)numericUpDownRating.Value, (int)numericUpDownGar.Value);
    }
}
