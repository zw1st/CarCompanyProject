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

public partial class FormSearchCarShop : Form
{
    public event Action<string?, int?, int?, int?, int?> SearchImage;


    public FormSearchCarShop()
    {
        InitializeComponent();
    }


    private void buttonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            if (numericUpDownGuaranteeFrom.Value >= numericUpDownGuaranteeTo.Value ||
                numericUpDownRatingFrom.Value >= numericUpDownRatingTo.Value)
            {
                throw new Exception("Нижняя граница должна быть меньше");
            }
            string? arg1 = CreateSearchImage().Item1 ?? string.Empty;
            int? arg2 = CreateSearchImage().Item2 ?? null;
            int? arg3 = CreateSearchImage().Item3 ?? null;
            int? arg4 = CreateSearchImage().Item4 ?? null;
            int? arg5 = CreateSearchImage().Item5 ?? null;
            SearchImage?.Invoke(arg1, arg2, arg3, arg4, arg5);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e) => Close();

    private (string?, int?, int?, int?, int?) CreateSearchImage()
    {
        return (textBoxCarShopName.Text, (int)numericUpDownRatingFrom.Value, (int)numericUpDownRatingTo.Value, (int)numericUpDownGuaranteeFrom.Value, (int)numericUpDownGuaranteeTo.Value);
    }
}
