using Undsf.Gwent.Core.Entity;

namespace Undsf.Gwent.Core.Service
{
    public interface IGameService
    {
        Game Create(Player red, Player blue);
    }
}