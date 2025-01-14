using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinaPolechkaProject.Interfaces.Implementations;

public class ConnectionString : IConnectionString
{
    string IConnectionString.ConnectionString => "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=postgres2";

}
