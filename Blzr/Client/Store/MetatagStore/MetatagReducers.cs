using Fluxor;

namespace Blzr.Client.Store.MetatagStore
{
    public class MetatagReducers
    {
        
        //SetLoadingAction
        [ReducerMethod]
        public static MetatagState OnSetLoading(MetatagState state, SetLoadingAction action)
        {
            return state with
            {
                Loading = action._loading
            };
        }

        //SetInitializedAction
        [ReducerMethod(typeof(SetInitializedAction))]
        public static MetatagState OnSetInitialized(MetatagState state)
        {
            return state with
            {
                Initialized = true
            };
        }

        //SetMetatagsLoadedAction
        [ReducerMethod]
        public static MetatagState OnSetMetatagsLoadedAction(MetatagState state, SetMetatagsLoadedAction action)
        {
            return state with
            {
                Metatags = action.metatags
            };
        }


        //SaveMetatagSuccesAction
        public static MetatagState OnSaveMetatagSuccesAction(MetatagState state, SaveMetatagSuccesAction action)
        {
            var metatags = state.Metatags;
            var metatag = metatags.First(x => x.Id == action.metatag.Id);
            metatag = action.metatag;

            return state with
            {
                Metatags = metatags
            };
        }

        public static MetatagState OnAddMetatagSuccesAction(MetatagState state, AddMetatagSuccesAction action)
        {
            var metatags = state.Metatags.ToList();
            metatags.Add(action.metatag);

            return state with
            {
                Metatags = metatags
            };
        }








    }
}
