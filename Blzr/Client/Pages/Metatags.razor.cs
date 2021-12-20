using Microsoft.AspNetCore.Components;
using Blzr.Client.Store.MetatagStore;
using Blzr.Shared;
using Fluxor;
using MudBlazor;
using SetInitializedAction = Blzr.Client.Store.UserStore.SetInitializedAction;

namespace Blzr.Client.Pages
{
    public partial class Metatags 
    {
        private IEnumerable<Metatag> metatags => metatagState.Value.Metatags;
        private bool loading => metatagState.Value.Loading;

        [Inject] public IDispatcher dispatcher { get; set; }

        [Inject] public IState<MetatagState> metatagState { get; set; }

        [Inject] private ISnackbar Snackbar { get; set; }

        protected override void OnInitialized()
        {
            if (metatagState.Value.Initialized == false)
            {
                LoadMetatags();
                dispatcher.Dispatch(new SetInitializedAction());
            }

            SubscribeToAction<LoadMetatagsAction>(ShowMetatagsLoaded);
            base.OnInitialized();
        }

        private void LoadMetatags()
        {
            dispatcher.Dispatch(new LoadMetatagsAction());
        }

        private void ShowMetatagsLoaded(LoadMetatagsAction action)
        {
            Snackbar.Configuration.SnackbarVariant = Variant.Outlined;
            Snackbar.Configuration.MaxDisplayedSnackbars = 10;
            Snackbar.Add($"Users are reloaded", Severity.Info);
        }
    }
}
