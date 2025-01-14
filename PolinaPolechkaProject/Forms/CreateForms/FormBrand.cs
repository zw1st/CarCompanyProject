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

public partial class FormBrand : Form
{
    private readonly IOperations<Brand> _brandOperations;
    private int? _brandId;

    public int Id
    {
        set
        {
            try
            {
                var brand = _brandOperations.ReadById(value);
                if (brand == null)
                {
                    throw new InvalidDataException(nameof(brand));
                }

                textBoxBrandName.Text = brand.BrandName;
                textBoxCountry.Text = brand.Country;
                _brandId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

    public FormBrand(IOperations<Brand> brandOperations)
    {
        InitializeComponent();
        _brandOperations = brandOperations ?? throw new ArgumentNullException(nameof(brandOperations));
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxBrandName.Text) || string.IsNullOrWhiteSpace(textBoxCountry.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }
            if (_brandId.HasValue)
            {
                _brandOperations.Update(CreateBrand(_brandId.Value));
            }
            else
            {
                _brandOperations.Create(CreateBrand(0));
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

    private Brand CreateBrand(int id)
    {
        return Brand.CreateBrand(id, textBoxBrandName.Text, textBoxCountry.Text);
    }

}

