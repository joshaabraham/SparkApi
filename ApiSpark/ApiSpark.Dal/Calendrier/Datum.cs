namespace ApiSpark.Dal.Calendrier

{
    public class Datum
    {
        public string Start { get; set; }
        public string End { get; set; }
        public string Title { get; set; }
        public string AllDay { get; set; }
        public Color Color { get; set; }
        public Resizable Resizable { get; set; }
        public string Draggable { get; set; }
        public Meta Meta { get; set; }
    }

}