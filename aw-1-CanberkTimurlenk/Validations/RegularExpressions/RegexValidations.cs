namespace aw_1_CanberkTimurlenk.Validations.RegularExpressions;
public static class RegexValidations
{
    // The numbers should start with a plus sign, followed by the country code and national number.
    public const string Phone = @"^\+(?:[0-9] ?){6,14}[0-9]$";
}
