namespace fnPostDatabase
{
    public class MovieRequest
    {
        public string id { get { return Guid.NewGuid().ToString(); } }
        public string title { get; set; }
        public string year { get; set; }
        public string video{ get; set; }
        public string thumb { get; set; }

        public string duration { get; set; }
        public string director { get; set; }
        public string cast { get; set; }
        public string description{ get; set; }
    }
}
