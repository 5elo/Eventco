using System.ComponentModel.DataAnnotations.Schema;

namespace ECUEvents.Common
{
    public abstract class ObjectBass
    {
        [Column(Order = 0)]
        public int Id { get; set; }
        [Column(Order = 1)]
        public DateTime CreateDate { get; set; }
        [Column(Order = 2)]
        public DateTime? ModifyDate { get; set; }
        public bool Focus { get; set; }
        public bool Active { get; set; }


    }
}
