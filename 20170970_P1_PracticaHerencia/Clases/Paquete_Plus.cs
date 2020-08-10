using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.Clases
{
    public class Paquete_Plus:Servicio
    {
        private int payaso_extra;
        private int botarga_extra;
        private int regalo_extra;
        public Paquete_Plus()
        {
            payaso_extra = 0;
            botarga_extra = 0;
            regalo_extra = 0;
        }
        public Paquete_Plus(int Pq1, int Pq2, int payaso_extra, int botarga_extra, int regalo_extra)
            :base(Pq1, Pq2)
        {
            this.payaso_extra = payaso_extra;
            this.botarga_extra = botarga_extra;
            this.regalo_extra = regalo_extra;
        }
        public int Resultado()
        {
            int resPE;
            int resBE;
            int resRE;
            int res = 0;
            resPE = payaso_extra * 200;
            resBE = botarga_extra * 200;
            resRE = regalo_extra * 30;
            res = Get_Pq2() + resPE + resBE + resRE;
            return res;
        }
    }
}
