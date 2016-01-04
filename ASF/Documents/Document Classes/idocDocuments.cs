using Victors;

namespace ASF.Documents
{
    public class idocDocument : idoc
    {
        protected virtual void Constructor(string key, FBClient client, string type)
        {
            Type = type;
            Key = key;
            Client = client;
            Load();
        }
        
        public idocDocument(string key, FBClient client, string type)
        {
            Constructor(key, client, type);
        }
        public idocDocument(int key, FBClient client, string type)
        {
            Constructor(key.ToString(), client, type);
        }
        public idocDocument(FBClient client, string type)
        {
            Constructor("", client, type);
        }

        public string Type { get; protected set; }
        public string Key { get; protected set; }
        public idocEmployee Owner { get; protected set; }

        public FBClient Client { get; private set; }
        
        virtual public void Load() { }

        virtual public bool isCreated { get; protected set; }
        virtual public bool isChanged { get; protected set; }

        virtual public void Create() { }
        virtual public void Show() { }
        virtual public void Close() { }
        virtual public void Save() { }
        virtual public void Delete() { }
    }


}