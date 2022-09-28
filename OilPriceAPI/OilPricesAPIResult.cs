namespace OilPrice_CESIProject;

public class OilPricesAPIResult
{
    public int nhits { get; set; }
    public Parameters parameters { get; set; }
    public List<Record> records { get; set; }
}
    public class Fields
    {
        public string id { get; set; }
        public string prix_id { get; set; }
        public string pop { get; set; }
        public string reg_code { get; set; }
        public string reg_name { get; set; }
        public string horaires_automate_24_24 { get; set; }
        public string com_arm_name { get; set; }
        public string adresse { get; set; }
        public string cp { get; set; }
        public string horaires { get; set; }
        public string dep_code { get; set; }
        public string ville { get; set; }
        public string epci_code { get; set; }
        public string services_service { get; set; }
        public string dep_name { get; set; }
        public string com_arm_code { get; set; }
        public string epci_name { get; set; }
        public List<double> geom { get; set; }
        public double prix_valeur { get; set; }
        public string prix_nom { get; set; }
        public DateTime prix_maj { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Parameters
    {
        public List<string> dataset { get; set; }
        public string q { get; set; }
        public int rows { get; set; }
        public int start { get; set; }
        public string format { get; set; }
        public string timezone { get; set; }
    }

    public class Record
    {
        public string datasetid { get; set; }
        public string recordid { get; set; }
        public Fields fields { get; set; }
        public Geometry geometry { get; set; }
        public DateTime? record_timestamp { get; set; }
    }
    