using System.Collections.Generic;


namespace ApiSpark.Dal.ScrumBoard
{
    public class List
    {
        public string ListId { get; set; }
        public string Name { get; set; }
        public List<string> IdCards { get; set; }
    }

}