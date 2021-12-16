using Blzr.Client.Services;
using Blzr.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Blzr.Client.Store.UserStore;
using Fluxor;
using MudBlazor;


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
        private ISnackbar Snackbar  {get; set; }

    

        protected override  void OnInitialized()
        {
           if (userState.Value.Initialized==false)
           {
               LoadUsers();
               dispatcher.Dispatch(new SetInitializedAction());
               
           }

           SubscribeToAction<LoadUsersAction>(ShowUsersLoaded);
           base.OnInitialized();
            
        }

        private void LoadUsers()
        {
            dispatcher.Dispatch(new LoadUsersAction());
        }

        private void ShowUsersLoaded(LoadUsersAction action)
        {
            Snackbar.Configuration.SnackbarVariant = Variant.Outlined;
            Snackbar.Configuration.MaxDisplayedSnackbars = 10;
            Snackbar.Add($"Users are reloaded", Severity.Info);
        }

    }
}
