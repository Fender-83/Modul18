using System.Threading.Tasks;

namespace Modul18
{
    public abstract class Command
    {
        public abstract Task Run();
    }
}