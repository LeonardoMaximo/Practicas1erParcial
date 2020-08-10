using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.Clases
{
    public class Servicio
    {
        private int Pq1;
        private int Pq2;
        public Servicio() {
            Pq1 = 0;
        }
        public Servicio(int Pq1,int Pq2)
        {
            this.Pq1 = Pq1;
            this.Pq2 = Pq2;
        }

        public int Get_Pq1()
        {
            return Pq1 = 600;
        }
        public void Set_Pq1(int x)
        {
            Pq1 = x;
        }
        public int Get_Pq2()
        {
            return Pq2 = 1000;
        }
        public void Set_Pq2(int x)
        {
            Pq2 = x;
        }
    }
}
