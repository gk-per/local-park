using System.Threading.Tasks;
using BlazorServer.Models;
using Orleans;

namespace BlazorServer
{
    /// <summary>
    /// Interface to a specific instance of a game with its own status and list of players.
    /// </summary>
    public interface IGameGrain : IGrainWithGuidKey
    {
        Task UpdateGameStatusAsync(GameStatus status);
        Task ObserveGameUpdatesAsync(IGameObserver observer);
        Task UnobserveGameUpdatesAsync(IGameObserver observer);
    }
}
