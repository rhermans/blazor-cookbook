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
        [ReducerMethod(typeof(SetMetatagsInitializedAction))]
        public static MetatagState OnSetMetatagsInitialized(MetatagState state)
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
        [ReducerMethod]
        public static MetatagState OnSaveMetatagSuccesAction(MetatagState state, SaveMetatagSuccesAction action)
        {
            //the metatagstate contains an enumerable<T> - and this is in c# alway muttable
            //so it has no use to update the state because its already updated.
            //still searching for a descent solution to implement fluxor/redux/flux pattern
            //in truth this static method can be removed as it is now implemented.
            //BUT !!! keep this class - c# might learn how to use immutable

            return state;
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
