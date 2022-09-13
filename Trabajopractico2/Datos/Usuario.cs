using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajopractico2.Modelo;

namespace Trabajopractico2.Datos
{
    public class Usuario
    {
        List<Usuariomodelo> lista = new List<Usuariomodelo>();

        public void Guardar (Usuariomodelo modelo)
        {
            lista.Add(modelo); 
        }

        public List <Usuariomodelo> Consultar() {
            return lista;
        }
    }
}
