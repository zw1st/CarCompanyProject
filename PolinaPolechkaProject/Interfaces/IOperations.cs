using PolinaPolechkaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinaPolechkaProject.Interfaces;

public interface IOperations<T> where T : class
{
    IEnumerable<T> ReadAll();
    T ReadById(int id);
    void Create(T variable);
    void Update(T variable);
    void Delete(int id);
}

