namespace Sismio.io.sismio.events
{
    public class TagFilter: IEventFilter
    {
        private string Tag;

        public TagFilter(string tag)
        {
            Tag = tag;
        }

        public bool Filter(Event evnt)
        {
            return evnt.Tag.Equals(Tag);
        }
    }
}