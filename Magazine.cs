namespace universitaetsbibliothek
{
    class Magazine : Item
    {
        private readonly string _itemType;
        private string _itemIdentifier;
        private string _itemPublisher;
        
        public Magazine(string itemIdentifier, string itemPublisher)
        {
            _itemType = "Magazine";
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