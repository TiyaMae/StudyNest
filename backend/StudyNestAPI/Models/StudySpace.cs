namespace StudyNestAPI.Models;

    public class StudySpace {
        public int ID {get; set;}
        public string Name {get; set;} = "";
        public string Address {get; set;} = "";
        public double Latitude {get; set;}
        public double Longitude {get; set;}
        public string PriceRange {get; set;} = "";
        public string Wifi {get; set;} ="";
        public string Outlets {get; set;} = "";
        public string Hours {get; set;} = "";
        public string NoiseLevel {get; set;} = "";
        public bool Open24Hours {get; set;}
        public double Rating {get; set;}
        public string ImageUrl {get; set;} = "";
    }
