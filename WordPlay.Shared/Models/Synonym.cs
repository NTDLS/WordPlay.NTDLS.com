namespace WordPlay.Shared.Models
{
    public class Synonym
    {
        public string Source { get; set; }
        public string SourceLanguage { get; set; }
        public string Target { get; set; }
        public string TargetLanguage { get; set; }
        public string IsDirty { get; set; }
        public int Confidence { get; set; }
    }
}
