using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sismio.io.sismio.sensore
{
    public delegate void OnRisultatiGrezziDisponibili(int[] dati);

    public interface ISensore
    {
        event OnRisultatiGrezziDisponibili RicevitoriDatiSensore;

        void CicloPrincipale();

        void Ferma();
    }
}
