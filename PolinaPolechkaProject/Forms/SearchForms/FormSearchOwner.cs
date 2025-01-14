using PolinaPolechkaProject.Entities;
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

public partial class FormSearchOwner : Form
{
    public event Action<string?, string?, string?, string?> SearchImage;


    public FormSearchOwner()
    {
        InitializeComponent();
    }


    private void buttonSearch_Click(object sender, EventArgs e)
    {

        try
        {
            string? arg1 = CreateSearchImage().Item1 ?? string.Empty;
            string? arg2 = CreateSearchImage().Item2 ?? string.Empty;
            string? arg3 = CreateSearchImage().Item3 ?? string.Empty;
            string? arg4 = CreateSearchImage().Item4 ?? string.Empty;
            SearchImage?.Invoke(arg1, arg2, arg3, arg4);
            
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e) => Close();

    private (string?, string?, string?, string?) CreateSearchImage()
    {
        return (textBoxSubName.Text, textBoxSubPhone.Text, textBoxSubEmail.Text, textBoxSubAdress.Text);
    }
}
