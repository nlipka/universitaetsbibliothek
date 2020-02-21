namespace universitaetsbibliothek
{
    class MagazineFactory : ItemFactory
    {
        private string _itemIdentifier;
        private string _itemPublisher;

        public MagazineFactory(string itemIdentifier, string itemPublisher)
        {
            _itemIdentifier = itemIdentifier;
            _itemPublisher = itemPublisher;
        }
        
        public override Item GetItem()
        {
            return new Magazine(_itemIdentifier, _itemPublisher);
        }
    }
}