using System.ComponentModel;

namespace WebASPAppNFT.Entities
{
    public class Option
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string Relation {  get; set; } = string.Empty;

        public int Order { get; set; }
        [DefaultValue(false)]
        public bool IsSystem { get; set; }

    }
}
