using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebASPAppNFT.Entities
{
    public class Navigate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Href { get; set; }

        public int Order { get; set; }

        public string Relation {  get; set; }

        [DefaultValue(null)]
        [ForeignKey("Id")]
        public int? Parent_Id { get; set; }

        public ICollection<Navigate> Childs { get; set;}
    }
}
