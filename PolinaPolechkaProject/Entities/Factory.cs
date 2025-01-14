using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinaPolechkaProject.Entities;

public class Factory
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Adress { get; private set; } = string.Empty;
    public DateTime FoundationDate { get; private set; }

    public static Factory CreateFactory(int id, string name, string adress, DateTime foundationDate)
    {
        return new Factory
        {
            Id = id,
            Name = name,
            Adress = adress,
            FoundationDate = foundationDate
        };
    }

}
