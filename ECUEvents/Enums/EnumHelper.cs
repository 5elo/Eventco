using System.ComponentModel;

namespace Domain.Enums
{
  public static class EnumHelper
  {
    public enum StatusCodeEnum
    {
      // Custom Status Code 
      [Description("Something went wrong can't create {0}")]
      CreationFailed = 1,
      [Description("Something went wrong can't Delete {0}")]
      DeleteFailed = 2,
      [Description("Something went wrong can't Update {0}")]
      UpdateFailed = 3,
      [Description("Email is not confirmed")]
      EmailIsNotConfirmed = 4,
      [Description("Invalid File Extension")]
      InvalidFileExtension = 5,
      [Description("Validation Failed")]
      ValidationFailed = 6,
      [Description("Lookup value is locked")]
      LoockupValueLocked = 7,

      // Pre defined status code
      [Description("Request Completed Successfully")]
      Success = 200,
      [Description("Something went wrong please try again")]
      InternalServerError = 500,
      [Description("Not Found")]
      NotFound = 404,
      [Description("Unauthorized")]
      Unauthorized = 401,
    }

    public enum EnumErrorMessage
    {
      UsernameExist,
      EmailExist,
      InvalidEmail,
      InvalidUrl,
      NameRequired,
      NameMaxLen,
      NameExist,
      DescMaxLen,
      RoleUsed,
      IndicatorUnitExist,
      InvalidFileExtension
        }


    public enum EnumDataTypesLength
    {
      ISD_Notes = 4000, ISD_abbreviation = 16, ISD_Attachment = 128, ISD_Name = 255, ISD_Description = 2048, ISD_Email = 255, ISD_Address = 1000, ISD_Fax = 64, ISD_File = 255, ISD_Guid = 36, ISD_Html = 4000, ISD_LookupName = 64, ISD_ObjectName = 64, ISD_Password = 100, ISD_Phone = 64,
      ISD_Text1024 = 1024, ISD_Text16 = 16, ISD_Text128 = 128, ISD_Text2048 = 2048, ISD_Text255 = 255, ISD_Text32 = 32, ISD_Text4000 = 4000, ISD_Text512 = 512, ISD_Url = 512, ISD_Xml = 4000
    };
  }
}
