using FisioAvalia.Evolutions.Dto;
using System.Threading.Tasks;

namespace FisioAvalia.Evolutions
{
    public interface IEvolutionAppService
    {
        Task CreateAsync(CreateEvolutionInput input);
    }
}