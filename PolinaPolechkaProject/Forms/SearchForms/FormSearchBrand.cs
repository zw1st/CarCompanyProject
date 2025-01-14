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

public partial class FormSearchBrand : Form
{
    public event Action<string?, string?> SearchBrand;

    public FormSearchBrand()
    {
        InitializeComponent();
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            string? brandName = CreateSearchBrand().Item1 ?? string.Empty;
            string? country = CreateSearchBrand().Item2 ?? string.Empty;
            SearchBrand?.Invoke(brandName, country);

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при поиске",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e) => Close();

    private (string?, string?) CreateSearchBrand()
    {
        return (textBoxBrandName.Text, textBoxCountry.Text);
    }
}

