using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinaPolechkaProject.Entities;

public class Car
{
    public int Id { get; private set; }

    public int FactoryId { get; private set; }
    public string Factory { get; private set; } = string.Empty;

    public int CarShopId { get; private set; }
    public string CarShop { get; private set; } = string.Empty;

    public int BrandId { get; private set; }
    public string Brand { get; private set; } = string.Empty;


    public int OwnerId { get; private set; }
    public string Owner { get; private set; } = string.Empty;


    public DateTime ReleaseYear { get; private set; }
    public int Price { get; private set; }
    public DriveType DriveType { get; private set; }
    public bool IsAutomatic { get; private set; }

    public static Car CreateCar(int id, int factoryId, int carShopId, int brandId, int ownerId, DateTime releaseYear, int price, DriveType driveType, bool isAutomatic)
    {
        return new Car
        {
            Id = id,
            FactoryId = factoryId,
            CarShopId = carShopId,
            BrandId = brandId,
            OwnerId = ownerId,
            ReleaseYear = releaseYear,
            Price = price,
            DriveType = driveType,
            IsAutomatic = isAutomatic
        };
    }
}
