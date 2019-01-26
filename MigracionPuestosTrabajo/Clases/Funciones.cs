using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigracionPuestosTrabajo.Clases
{
    class Funciones
    {
        public void InsertarCabecera(Data.PuestosTrabajo puestosTrabajo)
        {
            using (var modelo = new Data.PerfilesModel())
            {
                modelo.PuestosTrabajoes.Add(puestosTrabajo);
                modelo.SaveChanges();
            }
        }

        
    }
}
