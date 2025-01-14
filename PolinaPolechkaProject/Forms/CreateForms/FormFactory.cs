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

public partial class FormFactory : Form
{
    private readonly IOperations<Factory> _factoryOperations;
    private int? _factoryId;
    public int Id
    {
        set
        {
            try
            {
                var owner = _factoryOperations.ReadById(value);
                if (owner == null)
                {
                    throw new InvalidDataException(nameof(owner));
                }

                textBoxAdress.Text = owner.Adress;
                textBoxFactoryName.Text = owner.Name;
                dateTimePickerFoundationYear.Value = owner.FoundationDate;
                _factoryId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }


    public FormFactory(IOperations<Factory> factoryOperations)
    {
        InitializeComponent();
        _factoryOperations = factoryOperations ?? throw new ArgumentNullException(nameof(factoryOperations));
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxAdress.Text) || string.IsNullOrWhiteSpace(textBoxFactoryName.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }
            if (_factoryId.HasValue)
            {
                _factoryOperations.Update(CreateFactory(_factoryId.Value));
            }
            else
            {
                _factoryOperations.Create(CreateFactory(0));
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

    private Factory CreateFactory(int id)
    {
        return Factory.CreateFactory(id, textBoxFactoryName.Text, textBoxAdress.Text, dateTimePickerFoundationYear.Value);
    }
}
