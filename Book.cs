namespace universitaetsbibliothek
{
    class Book : Item
    {
        private readonly string _itemType;
        private string _itemIdentifier;
        private string _itemPublisher;
        
        public Book(string itemIdentifier, string itemPublisher)
        {
            _itemType = "Book";
            _itemIdentifier = itemIdentifier;
            _itemPublisher = itemPublisher;
        }

        public override string ItemType => _itemType;

        public override string ItemIdendifier
        {
            get => _itemIdentifier;
            set => _itemIdentifier = value;
        }

        public override string ItemPublisher
        {
            get => _itemPublisher;
            set => _itemPublisher = value;
        }
    }
}