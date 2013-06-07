/*
 * If you need to refresh the internet settings like the proxy then use the fallowing.
 *
 * -- BUG --
 * This will only work once then the application has to be restarted.
 */

using System.Runtime.InteropServices;

private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
private const int INTERNET_OPTION_REFRESH = 37;

[DllImport("wininet.dll", SetLastError = true, CharSet = CharSet.Auto)]
public static extern bool InternetSetOption(
    IntPtr hInternet,
    int dwOption,
    IntPtr lpBuffer,
    int dwBufferLength
);

internal static void Notify_OptionsSettingsChanges()
{
    InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
    InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
}