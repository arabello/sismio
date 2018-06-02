namespace Sismio.io.sismio.utente
{
    public interface IUtente
    {
        string Nome { get; }
        string Cognome { get; }
        string Email { get; }
        string Username { get; }
        string HashPass { get; }
        string SaltPass { get; }
        bool LoginRemoto { get; }

        bool PuoModificareUtenti();
        bool PuoModificareSorgenti();
        bool PuoModificareStazioni();
    }
}