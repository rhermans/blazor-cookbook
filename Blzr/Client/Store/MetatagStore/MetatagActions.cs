using Blzr.Shared;

namespace Blzr.Client.Store.MetatagStore
{


    public class LoadMetatagsAction { }

    public class SetMetatagsLoadedAction
    {
        public IEnumerable<Metatag> metatags { get; }

        public SetMetatagsLoadedAction(IEnumerable<Metatag> metatags)
        {
            this.metatags = metatags;
        }
    }

    public class SetLoadingAction
    {
        public bool _loading { get; }

        public SetLoadingAction(bool loading)
        {
            _loading = loading;
        }
    }
    public class SetMetatagsInitializedAction
    {
    }

    public class SaveMetatagAction
    {
        public Metatag metatag { get; }

        public SaveMetatagAction(Metatag metatag)
        {
            this.metatag = metatag;
        }
    }
    public class SaveMetatagSuccesAction
    {
        public Metatag metatag { get; }

        public SaveMetatagSuccesAction(Metatag metatag)
        {
            this.metatag = metatag;
        }
    }

    public class SaveMetatagErrorAction
    {

    }

    public class AddMetatagAction { }
    public class AddMetatagSuccesAction
    {
        public Metatag metatag { get; }

        public AddMetatagSuccesAction(Metatag metatag)
        {
            this.metatag = metatag;
        }
    }
    public class AddMetatagErrorAction { }


}

