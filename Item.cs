namespace universitaetsbibliothek
{
    abstract class Item
    {
        public abstract string ItemType { get; }
        public abstract string ItemIdendifier { get; set; }
        public abstract string ItemPublisher { get; set; }
    }
}