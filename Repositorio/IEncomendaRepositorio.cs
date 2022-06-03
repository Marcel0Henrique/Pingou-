using Pingou.Models;
using Refit;
namespace Pingou.Repositorio
{
    public interface IEncomendaRepositorio
    {
         [Get("/track/json?user=usuario&token=usuario&codigo={cod}")]
         Task<PacoteModel> GetPackageAsync(string cod);
    }
}