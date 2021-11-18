using Blzr.Client.Services;
using Blzr.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blzr.Client.Pages
{
    public partial class Users
    {
        public List<User> AllUsers { get; set; }

        [Inject]
        public IUserService UserService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AllUsers =  (await UserService.GetUsers()).ToList();
        }
    }
}
