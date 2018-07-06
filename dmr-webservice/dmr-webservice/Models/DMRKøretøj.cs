#pragma warning disable 1591

namespace dmr_webservice.Models
{
    using System;

    public class DMRKøretøj
    {
        public Køretøj Køretøj { get; set; }

        public Registreringsforhold Registreringsforhold { get; set; }

        public Identifikation Identifikation { get; set; }

        public Udstyr Udstyr { get; set; }

        public DMRKøretøj()
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
}
