using System.Threading.Tasks;
using FisioAvalia.Vitals;
using FisioAvalia.Vitals.Dto;
using Xamarin.Forms;

[assembly: Dependency(typeof(VitalAppService))]
namespace FisioAvalia.Vitals
{
    public class VitalAppService : IVitalAppService
    {
        public Task CreateAsync(CreateVitalInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}