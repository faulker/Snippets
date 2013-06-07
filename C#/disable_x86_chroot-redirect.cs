/*
 * Disable redirect to 32bit chroot.
 * This will make it so when an application is called from with in
 * the program it runs it as if you clicked start->run and typed the
 * application name it and doesn't look in the %windir%\SysWOW64 dir.
 */
[DllImport("kernel32.dll", SetLastError = true)]
public static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);

static IntPtr ptr = new IntPtr();
bool isWow64FsRedirectionDisabled = Wow64DisableWow64FsRedirection(ref ptr);