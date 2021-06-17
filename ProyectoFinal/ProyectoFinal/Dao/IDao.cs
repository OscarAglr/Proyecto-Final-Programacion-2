using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Dao
{
    public interface IDao<T>
    {
        void Create(T t);
        T[] GetAll();
        void Update(T t, int index);
        bool Delete(int index);

    }
}
