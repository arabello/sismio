using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sismio.io.sismio.stazione
{
    public class Stazione: IStazione
    {
        public string Nome { get; }
        public string Locazione { get; }
        public IPAddress IndirizzoDiRete { get; }
        public int Porta { get; }
        public string ImprontaChiavePubblica { get; }
        public long Id { get; set; }

        public Stazione(string nome, string locazione, IPAddress indirizzoDiRete, int porta, string improntaChiavePubblica)
        {
            Nome = nome;
            Locazione = locazione;
            IndirizzoDiRete = indirizzoDiRete;
            Porta = porta;
            ImprontaChiavePubblica = improntaChiavePubblica;
        }
    }
}
