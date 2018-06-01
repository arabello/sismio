using System.Net;

namespace Sismio.io.sismio.stazione
{
    public interface IStazione
    {
        string Nome { get; }
        string Locazione { get; }
        IPAddress IndirizzoDiRete { get; }
        int Porta { get; }
        string ImprontaChiavePubblica { get; }
    }
}