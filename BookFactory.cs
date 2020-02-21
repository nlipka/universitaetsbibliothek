namespace universitaetsbibliothek
{
    class BookFactory : ItemFactory
    {
        private string _itemIdentifier;
        private string _itemPublisher;

        public BookFactory(string itemIdentifier, string itemPublisher)
        {
            _itemIdentifier = itemIdentifier;
            _itemPublisher = itemPublisher;
        }
        
        public override Item GetItem()
        {
            return new Book(_itemIdentifier, _itemPublisher);
        }
    }
}