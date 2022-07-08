

using System.ComponentModel.DataAnnotations.Schema;

namespace a.Core.Entities
{
    public class baseEntity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateOnly Createdate { get; set; }
        public DateOnly Updatedate { get; set; }
    }

}






