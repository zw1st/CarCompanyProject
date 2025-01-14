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

namespace PolinaPolechkaProject.Forms;

public partial class FormOwner : Form
{
    private readonly IOperations<Owner> _ownerOperations;
    private int? _ownerId;
    public int Id
    {
        set
        {
            try
            {
                var owner = _ownerOperations.ReadById(value);
                if (owner == null)
                {
                    throw new InvalidDataException(nameof(owner));
                }

                textBoxAdress.Text = owner.Adress;
                textBoxEmail.Text = owner.Email;
                textBoxFullName.Text = owner.FullName;
                textBoxPhone.Text = owner.Phone;
                _ownerId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }


    public FormOwner(IOperations<Owner> ownerOperations)
    {
        InitializeComponent();
        _ownerOperations = ownerOperations ?? throw new ArgumentNullException(nameof(ownerOperations));
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxPhone.Text) || string.IsNullOrWhiteSpace(textBoxAdress.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }
            if (_ownerId.HasValue)
            {
                _ownerOperations.Update(CreateOwner(_ownerId.Value));
            }
            else
            {
                _ownerOperations.Create(CreateOwner(0));
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

    private Owner CreateOwner(int id)
    {
        return Entities.Owner.CreateOwner(id, textBoxFullName.Text, textBoxPhone.Text, textBoxEmail.Text, textBoxAdress.Text);
    }
}
