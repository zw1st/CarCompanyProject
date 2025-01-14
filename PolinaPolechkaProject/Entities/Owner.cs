using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinaPolechkaProject.Entities;

public class Owner
{
    public int Id { get;  private set; }
    public string FullName { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Adress { get; private set; } = string.Empty;

    public static Owner CreateOwner(int id, string fullname, string phone, string email, string adress)
    {
        return new Owner { Id = id, FullName = fullname, Phone = phone, Email = email, Adress = adress };
    }
}
