using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinaPolechkaProject.Entities;

public class Brand
{
    public int Id { get; private set; }
    public string BrandName { get; private set;} = string.Empty;
    public string Country {  get; private set;} = string.Empty;

    public static Brand CreateBrand(int id, string brandName, string country)
    {
        return new Brand
        {
            Id = id,
            BrandName = brandName,
            Country = country
        };
    }

}
