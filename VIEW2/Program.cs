using CONTROLLER;

namespace VIEW2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ClientADO cl = new ClientADO();
            var clients = cl.Listclient(); // R�cup�rer la liste des clients

            foreach (var client in clients)
            {
                Console.WriteLine(client); // Afficher chaque client
            }
        }
    }
}