using System.Collections.Generic;


namespace ApiSpark.Dal.ContenuTextuel
{
    public class Todo
    {
        public string TodoId { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public string StartDate { get; set; }
        public object DueDate { get; set; }
        public bool Completed { get; set; }
        public bool Starred { get; set; }
        public bool Important { get; set; }
        public bool Deleted { get; set; }
        public List<Tag> Tags { get; set; }

        public List<Filter> Filters { get; set; }
    }

}