using System.Threading.Tasks;

namespace _36Kr.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}