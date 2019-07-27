using FisioAvalia.Vitals.Dto;
using System.Threading.Tasks;

namespace FisioAvalia.Vitals
{
    public interface IVitalAppService
    {
        Task CreateAsync(CreateVitalInput input);
    }
}