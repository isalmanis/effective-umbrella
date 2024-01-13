using System.Globalization;

namespace Umbrella;

public static class PiHelper
{
    // Take 3. into account precision is now 8
    public static string GetPi() => Math.PI.ToString(CultureInfo.InvariantCulture)[..12];
}
