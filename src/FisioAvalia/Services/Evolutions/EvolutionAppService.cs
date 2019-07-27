using System.Threading.Tasks;
using FisioAvalia.Evolutions;
using FisioAvalia.Evolutions.Dto;
using Xamarin.Forms;

[assembly: Dependency(typeof(EvolutionAppService))]
namespace FisioAvalia.Evolutions
{
    public class EvolutionAppService : IEvolutionAppService
    {
        public async Task CreateAsync(CreateEvolutionInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}