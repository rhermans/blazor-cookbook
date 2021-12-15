using Fluxor;

namespace Blzr.Client.Store.Counter
{
    public static class CounterReducer
    {
        [ReducerMethod]
        public static CounterState OnAddCounter(CounterState state, AddCounter action)
        {
            // TS :> { ... state, Count; state.Count +1 }
            return state with
            {
                Count = state.Count + 1
            };
        }
    }
}
