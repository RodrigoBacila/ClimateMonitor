using System.Text.RegularExpressions;

namespace ClimateMonitor.Services;

public class VersionSemanticsValidatorService
{
    public bool ValidateVersionSemantics(string versionSemantics) => Regex.IsMatch(versionSemantics, "^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.(0|[1-9]\\d*)(?:-((?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-\r\n]*)(?:\\.(?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\\+([0-9a-zA-Z-]+(?:\\.[0-9a\u0002zA-Z-]+)*))?$");
}
