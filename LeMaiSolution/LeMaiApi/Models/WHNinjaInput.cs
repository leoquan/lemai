using System;

namespace LeMaiApi.Models
{
    public class NinjaNewMeasurements
    {
        public double width { get; set; }
        public double height { get; set; }
        public double length { get; set; }
        public string size { get; set; }
        public double volumetric_weight { get; set; }
        public double measured_weight { get; set; }
    }

    public class NinjaPod
    {
        public string type { get; set; }
        public string name { get; set; }
        public string identity_number { get; set; }
        public string contact { get; set; }
        public string uri { get; set; }
        public bool left_in_safe_place { get; set; }
    }

    public class NinjaPreviousMeasurements
    {
        public double width { get; set; }
        public double height { get; set; }
        public double length { get; set; }
        public string size { get; set; }
        public double volumetric_weight { get; set; }
        public double measured_weight { get; set; }
    }

    public class WHNinjaInput
    {
        public int shipper_id { get; set; }
        public string status { get; set; }
        public string shipper_ref_no { get; set; }
        public string tracking_ref_no { get; set; }
        public string shipper_order_ref_no { get; set; }
        public DateTime timestamp { get; set; }
        public string id { get; set; }
        public string previous_status { get; set; }
        public string tracking_id { get; set; }
        public string comments { get; set; }
        public string previous_size { get; set; }
        public string new_size { get; set; }
        public string previous_weight { get; set; }
        public string new_weight { get; set; }
        public NinjaPreviousMeasurements previous_measurements { get; set; }
        public NinjaNewMeasurements new_measurements { get; set; }
        public NinjaPod pod { get; set; }
    }
}
