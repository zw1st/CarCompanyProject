using PolinaPolechkaProject.Entities;
using PolinaPolechkaProject.Forms.SearchForms;
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
using Unity;

namespace PolinaPolechkaProject.Forms;

public partial class FormOwnersViewer : Form
{
    private readonly IUnityContainer _container;
    private readonly OwnerImplementation _ownerImplementation;


    public FormOwnersViewer(IUnityContainer container, OwnerImplementation ownerImplementation)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _ownerImplementation = ownerImplementation ?? throw new ArgumentNullException(nameof(ownerImplementation));

    }

    private void FormOwnersViewer_Load(object sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormOwner>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonUpd_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }
        try
        {
            var form = _container.Resolve<FormOwner>();
            form.Id = findId;
            form.ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при изменении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonDel_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }
        if (MessageBox.Show("Удалить запись?", "Удаление",
        MessageBoxButtons.YesNo) != DialogResult.Yes)
        {
            return;
        }
        try
        {
            _ownerImplementation.Delete(findId);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList(string? fullName = null, string? phone = null, string? email = null, string? adress = null) => dataGridView1.DataSource =
   _ownerImplementation.ReadAll(fullName, phone, email, adress);

    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridView1.SelectedRows.Count < 1)
        {
            MessageBox.Show("Нет выбранной записи", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
        return true;
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            var searchForm = _container.Resolve<FormSearchOwner>();


            searchForm.SearchImage += GetSearchImage;


            searchForm.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void GetSearchImage(string? fullName = null, string? phone = null, string? email = null, string? adress = null)
    {
        LoadList(fullName, phone, email, adress);
    }

    private void buttonReset_Click(object sender, EventArgs e)
    {
        LoadList();
    }
}
