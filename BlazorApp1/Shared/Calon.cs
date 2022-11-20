namespace BlazorApp1.Shared
{
    public class Calon
    {
        private int pid1;

        public int? id { get; set; }
        public string t { get; set; }
        public string jp { get; set; }
        public int pid { get { if (pid1 == 2) return 27; return pid1; } set => pid1 = value; }
        public string s { get; set; }
        public string kid { get; set; }
        public string kt { get; set; }
        public object i { get; set; }
        public string st { get; set; }
        public DateTime mi { get; set; }
        public int? nc { get; set; }
        public int ju { get; set; }
        public int? mj { get; set; }
        public int? ut { get; set; }

        public string PartyName => pid switch
        {
            1 => "BN",
            2 => "PAS",
            3 => "DAP",
            27 => "PN",
            20 => "Bebas",
            30 => "PBDS",
            31 => "PH",
            32 => "GPS",
            36 => "Muda",
            42 => "PBM",
            54 => "Warisan",
            64 => "PKDM",
            99 => "PN + BN",
            _ => "Bebas",
        };

        public string ColorWinner => pid switch
        {
            1 => "BN",
            2 => "BN",
            27 => "PN",
            31 => "Red",
            54 => "Cyan",
            99 => "green",
            _ => "grey",
        };
    }
}
