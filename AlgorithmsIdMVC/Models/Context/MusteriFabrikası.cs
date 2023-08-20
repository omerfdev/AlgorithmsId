namespace AlgorithmsIdMVC.Models.Context
{
    public class MusteriFabrikası
    {
        private static MusteriFabrikası _fabrika;
        public List<Musteri> Musteriler { get; set; }
        public MusteriFabrikası()
        {
            Musteriler = new List<Musteri>();
        }
        public static MusteriFabrikası FabrikayıGetir
        {
            get
            {
                if (_fabrika == null)
                {
                    _fabrika = new MusteriFabrikası();
                }
                return _fabrika;
            }
        }
    }
}
