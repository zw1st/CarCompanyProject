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

public partial class FormSearchFactory : Form
{
    public event Action<string?, string?, DateTime?, DateTime?> SearchImage;


    public FormSearchFactory()
    {
        InitializeComponent();
    }


    private void buttonSearch_Click(object sender, EventArgs e)
    {
        
        try
        {
            if (dateTimePickerFrom.Value >= dateTimePickerTo.Value)
            {
                throw new Exception("Дата начала должна быть раньше даты окончания");
            }
            string? arg1 = CreateSearchImage().Item1 ?? string.Empty;
            string? arg2 = CreateSearchImage().Item2 ?? string.Empty;
            DateTime? arg3 = CreateSearchImage().Item3 ?? DateTime.Now;
            DateTime? arg4 = CreateSearchImage().Item4 ?? DateTime.Now;
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

    private (string?, string?, DateTime?, DateTime?) CreateSearchImage()
    {
        return (textBoxFactoryName.Text, textBoxAdress.Text, dateTimePickerFrom.Value, dateTimePickerTo.Value);
    }
}

