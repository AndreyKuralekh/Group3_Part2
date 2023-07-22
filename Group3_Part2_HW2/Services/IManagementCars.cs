using System.Xml.Linq;

namespace HW2_Cars_Controller
{
    public interface IManagementCars
    {
        public static async Task<string> GetCarName()
        {
            await Task.Delay(0);

            return "";
        }
        public async Task<string> GetCarEngine()
        {
            await Task.Delay(0);
            return "";
        }
        public async Task<int> GetCarAge()
        {
            await Task.Delay(0);
            return 0;
        }
    }
}
