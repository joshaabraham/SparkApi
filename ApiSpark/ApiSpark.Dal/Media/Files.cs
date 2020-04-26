
namespace ApiSpark.Dal.Media
{
    public class File
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Owner { get; set; }
        public string Size { get; set; }
        public string Modified { get; set; }
        public string Opened { get; set; }
        public string Created { get; set; }
        public string Extention { get; set; }
        public string Location { get; set; }
        public bool Offline { get; set; }
    }
}