

using Domain.Enums;
using ECUEvents.Common;
using System.ComponentModel.DataAnnotations;

namespace ECUEvents.Enums
{
    public class LookupBase:ObjectBass
    {
        [Required(ErrorMessageResourceName = "Required"), MaxLength((int)EnumHelper.EnumDataTypesLength.ISD_Name)]
        public string Name { get; set; } = String.Empty;


        [MaxLength((int)EnumHelper.EnumDataTypesLength.ISD_Description)]
        public string? Description { get; set; }


        

    }
}
