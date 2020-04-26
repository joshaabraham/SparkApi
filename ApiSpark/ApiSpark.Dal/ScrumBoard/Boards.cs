using System.Collections.Generic;


namespace ApiSpark.Dal.ScrumBoard
{

    public class Boards
    {
        public string BoardsId { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public Settings Settings { get; set; }
        public List<List> Lists { get; set; }
        public List<Card> Cards { get; set; }
        public List<Member> Members { get; set; }
        public List<Label> Labels { get; set; }
    }

}