using System.Threading.Tasks;
using static FrontendClient.Pages.Login;

namespace FrontendClient.Shared.Services
{
    interface IAuthService
    {
        Task<Response> Login(string cnp);
        Task Logout();
        Task<bool> LoggedIn();
        Task<bool> HasVoted();
        Task Vote();
        Task<string> GetCitizenId();
    }
}
