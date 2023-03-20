
namespace Oppgave_uke_2
{
    internal class Common
    {
        public static void NotAllowed(string msg)
        {
            Console.WriteLine(msg + "\nTrykk en tast for å fortsette . . .");
            Console.ReadKey();
        }
    }
}
