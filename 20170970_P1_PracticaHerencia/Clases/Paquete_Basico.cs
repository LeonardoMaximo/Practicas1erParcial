using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.Clases
{
    class Paquete_Basico : Servicio
    {

        private int cant_extra;
        
        public Paquete_Basico()
        {
            cant_extra = 0;
        }
        public Paquete_Basico(int Pq1, int Pq2, int cant_extra)
            : base(Pq1, Pq2)
        {
            this.cant_extra = cant_extra;
        }
        public int costo_servicio()
        {
            int total = 0;
            if (cant_extra>30)
            {
                int resta = cant_extra - 30;
                int mul = resta * 30;
                total = mul + 600;
                return total;
            }
            else
            {
                return Get_Pq1();
            }
        }
    }
}
