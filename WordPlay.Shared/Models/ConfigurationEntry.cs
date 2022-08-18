namespace WordPlay.Shared.Models
{
    public class ConfigurationEntry
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public string AsString()
        {
            if (string.IsNullOrWhiteSpace(Value))
            {
                return string.Empty;
            }
            return Value;
        }

        public int AsInteger()
        {
            if (string.IsNullOrWhiteSpace(Value))
            {
                return 0;
            }
            return int.Parse(Value);
        }

        public bool AsBoolean()
        {
            string value = AsString();

            switch (value.ToUpper())
            {
                case "YES":
                case "TRUE":
                case "ON":
                    return true;
            }


            return AsInteger() != 0;
        }
    }
}
