using Blzr.Client.Services;
using Blzr.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Blzr.Client.Store.UserStore;
using Fluxor;


namespace Blzr.Client.Pages
{
    public partial class Users
    {
        private IEnumerable<User> users => userState.Value.Users;
        private bool loading => userState.Value.Loading;

        [Inject]
        public IDispatcher dispatcher { get; set; }

        [Inject ]
        public IState<UserState> userState { get; set; }

        [Inject]
        public IUserService UserService { get; set; }

        protected override async Task OnInitializedAsync()
        {
           if (userState.Value.Initialized==false)
           {
               await LoadUsers();
               dispatcher.Dispatch(new UserStore_SetInitializedAction());
           }

           await base.OnInitializedAsync();
        }

        private async Task LoadUsers()
        {
            dispatcher.Dispatch((new UserStore_SetLoadingAction(true)));
            var users = await UserService.GetUsers();
            dispatcher.Dispatch(new UserStore_SetUsersAction(users));
            dispatcher.Dispatch(new UserStore_SetLoadingAction(false));


        }

    }
}
