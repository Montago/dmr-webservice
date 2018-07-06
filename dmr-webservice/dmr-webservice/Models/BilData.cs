namespace dmr_webservice.Models
{
    using System;

    public class Bildata
    {
        public DMRPage1Køretøj Køretøj { get; set; }

        public DMRPage2Teknisk Teknisk { get; set; }

        public DMRPage3Syn Syn { get; set; }

        public DMRPage5Afgifter Afgifter { get; set; }

        public Bildata()
        {
            Køretøj = new DMRPage1Køretøj();
            Teknisk = new DMRPage2Teknisk();
            Syn = new DMRPage3Syn();
            Afgifter = new DMRPage5Afgifter();
        }
    }

    public class DMRPage1Køretøj
    {
        public Køretøj Køretøj { get; set; }

        public Registreringsforhold Registreringsforhold { get; set; }

        public Identifikation Identifikation { get; set; }

        public Udstyr Udstyr { get; set; }

        public DMRPage1Køretøj()
        {
            Køretøj = new Køretøj();
            Registreringsforhold = new Registreringsforhold();
            Identifikation = new Identifikation();
            Udstyr = new Udstyr();
        }
    }

    public class Køretøj
    {
        public string Stelnummer { get; set; }

        public string MærkeModel { get; set; }

        public string Art { get; set; }

        public DateTime SenesteÆndring { get; set; }

        public string EFTypeGodkendelse { get; set; }
    }

    public class Registreringsforhold
    {
        public string RegistreringsNummer { get; set; }

        public DateTime FørsteRegistrering { get; set; }

        public string Anvendelse { get; set; }

        public DateTime SenesteÆndring { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

        public string EUVariant { get; set; }

        public string EUVersion { get; set; }

        public string Kategori { get; set; }

        public string Fabrikat { get; set; }
    }

    public class Identifikation
    {
        public string Farve { get; set; }

        public int ModelÅr { get; set; }

        public bool NCAP5 { get; set; }
    }

    public class Udstyr
    {
        public int AntalAirbags { get; set; }

        public string AndetUdstyr { get; set; }
    }

    public class DMRPage2Teknisk
    {
        public Vægt Vægt { get; set; }

        public Motor Motor { get; set; }

        public Karrosseri Karrosseri { get; set; }

        public Miljø Miljø { get; set; }

        public DMRPage2Teknisk()
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

    public class DMRPage3Syn
    {
        public bool Godkendt { get; set; }

        public DateTime SynsDato { get; set; }
    }

    public class DMRPage5Afgifter
    {
        public string GrønUdligningsafgiftHyppighed { get; set; }

        public string GrønUdligningsafgiftBeløb { get; set; }

        public string GrønEjerafgiftHyppighed { get; set; }

        public string GrønEjerafgiftBeløb { get; set; }

        public string Sum { get; set; }
    }
}
