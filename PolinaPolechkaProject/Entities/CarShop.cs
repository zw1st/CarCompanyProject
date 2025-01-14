using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinaPolechkaProject.Entities;

public class CarShop
{
    public int Id { get; private set; }
    public string ShopName { get; private set; } = string.Empty;
    public int Rating { get; private set; }
    public int Guarantee { get; private set; }
    public static CarShop CreateCarShop(int id, string shopName, int rating, int guarantee)
    {
        return new CarShop
        {
            Id = id,
            ShopName = shopName,
            Rating = rating,
            Guarantee = guarantee
        };
    }

}
