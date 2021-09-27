using Library;

namespace Program
{
    class Programs
    {
        static void Main(string[] args)
        {
            Singleton<Greeter>.Instance.SayHiToTheWorld();
        }
    }
}
