namespace LeMaiApi.Models
{
    public class WHBambooInput
    {
        public string code { get; set; }
        public string reason { get; set; }
        public string epod { get; set; }
        public string status { get; set; }
    }
    public class WHBambooWeightInput
    {
        public string code { get; set; }
        public double length { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
    }
}
