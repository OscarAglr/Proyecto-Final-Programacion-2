using ProyectoFinal.Dao;
using ProyectoFinal.poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DaoImplement
{
    public class AnualidadesDaoImpl : IDao<Anualidad>
    {

        public Anualidad[] anualidades;

        public void Create(Anualidad t)
        {
            if (anualidades == null)
            {
                anualidades = new Anualidad[1];
                anualidades[0] = t;
                return;
            }
            Anualidad[] tmp = new Anualidad[anualidades.Length + 1];
            Array.Copy(anualidades, tmp, anualidades.Length);
            tmp[anualidades.Length] = t;
            anualidades = tmp;
        }

        public bool Delete(int index)
        {
            if (anualidades == null)
            {
                return true;
            }

            if (index < 0 || index >= anualidades.Length)
            {
                throw new IndexOutOfRangeException($"El indice {index} esta fuera de rango.");
            }

            if (anualidades.Length == 1 && index == 0)
            {
                anualidades = null;
                return true;
            }

            Anualidad[] tmp = new Anualidad[anualidades.Length - 1];
            if (index == anualidades.Length - 1)
            {
                Array.Copy(anualidades, 0, tmp, 0, tmp.Length);
                anualidades = tmp;
                return true;
            }

            if (index == 0)
            {
                Array.Copy(anualidades, index + 1, tmp, 0, tmp.Length);
                anualidades = tmp;
                return true;
            }

            Array.Copy(anualidades, 0, tmp, 0, index);
            Array.Copy(anualidades, index + 1, tmp, index, tmp.Length - index);
            anualidades = tmp;

            return true;
        }
        public Anualidad[] GetAll()
        {
            return anualidades;
        }

        public void Update(Anualidad t, int index)
        {
            throw new NotImplementedException();
        }
    }
}
