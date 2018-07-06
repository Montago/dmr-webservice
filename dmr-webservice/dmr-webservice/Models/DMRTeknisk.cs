#pragma warning disable 1591

namespace dmr_webservice.Models
{
    public class DMRTeknisk
    {
        public Vægt Vægt { get; set; }

        public Motor Motor { get; set; }

        public Karrosseri Karrosseri { get; set; }

        public Miljø Miljø { get; set; }

        public DMRTeknisk()
        {
            Vægt = new Vægt();
            Motor = new Motor();
            Karrosseri = new Karrosseri();
            Miljø = new Miljø();
        }
    }

    public class Vægt
    {
        public int TekniskTotalvægt { get; set; }

        public int Totalvægt { get; set; }

        public int Minimum { get; set; }

        public int Vogntogsvægt { get; set; }
    }

    public class Motor
    {
        public string Mærkning { get; set; }

        public string Drivkraft { get; set; }

        public double Brændstofforbrug { get; set; }

        public double MaksHastighed { get; set; }

        public double Slagvolumen { get; set; }

        public double Effekt { get; set; }

        public int Cylindre { get; set; }
    }

    public class Karrosseri
    {
        public string Karrosseritype { get; set; }

        public int AntalDøre { get; set; }

        public string FælgeDæk { get; set; }

        public int AntalSidepladser { get; set; }
    }

    public class Miljø
    {
        public double CO2 { get; set; }

        public bool Partikelfilter { get; set; }

        public string Euronorm { get; set; }
    }
}
