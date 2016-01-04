using Victors;

namespace ASF.Documents
{
    public interface idoc
    {
        string Type { get; }
        string Key { get; }
        idocEmployee Owner { get; }
        bool isCreated { get; }
        bool isChanged { get; }
        void Create();
        void Show();
        void Close();
        void Save();
        void Delete();
    }
}
