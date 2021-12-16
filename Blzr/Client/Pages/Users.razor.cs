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

        //[Inject]
        //public IUserService UserService { get; set; }

        protected override  void OnInitialized()
        {
           if (userState.Value.Initialized==false)
           {
               LoadUsers();
               dispatcher.Dispatch(new UserStore_SetInitializedAction());
               
           }

            base.OnInitialized();
        }

        private void LoadUsers()
        {
            dispatcher.Dispatch(new UserStore_LoadUsersAction());
        }

    }
}
