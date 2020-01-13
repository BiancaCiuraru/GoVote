using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using static FrontendClient.Pages.Login;

namespace FrontendClient.Shared.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        private readonly string apiUrlLogin = "https://localhost:44380/api/login";

        public async Task<Response> Login(string cnp)
        {
            var request = new Dictionary<string, string>();
            request["cnp"] = cnp;
            var response = await _httpClient.PostJsonAsync<Response>(apiUrlLogin, request);

            if (!response.succes)
            {
                return response;
            }
 
            await _localStorage.SetItemAsync("authToken", response.Token);
            if (response.citizen.VotedFor.ToString() == "00000000-0000-0000-0000-000000000000")
                await _localStorage.SetItemAsync("voted", false);
            else
                await _localStorage.SetItemAsync("voted", true);
            await _localStorage.SetItemAsync("citizenid", response.citizen.ID);
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(cnp,response.citizen.VotedFor.ToString());
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", response.Token);

            return response;
        }

        public async Task<bool> LoggedIn()
        {
            return await _localStorage.ContainKeyAsync("authToken");
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            await _localStorage.RemoveItemAsync("voted");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task Vote()
        {
            await _localStorage.SetItemAsync("voted", true);
        }

        public async Task<bool> HasVoted()
        {
            return await _localStorage.GetItemAsync<bool>("voted");
            
        }

        public async Task<string> GetCitizenId()
        {
            return await _localStorage.GetItemAsync<string>("citizenid");
        }
    }
}
