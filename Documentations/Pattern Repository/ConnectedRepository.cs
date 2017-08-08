namespace Whatever
{
    public class ConnectedRepository
    {
        protected readonly string ConnexionString;

        protected ConnectedRepository(string connexionString)
        {
            ConnexionString = connexionString;
        }
    }
}