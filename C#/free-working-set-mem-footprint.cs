/*
 * Empty memory working set to make the app look
 * like it has less of a memory footprint.
 * 
 * --> This can cause the application to run slower.
 */
[DllImport("psapi.dll")]
static extern int EmptyWorkingSet(IntPtr hwProc);

static void MinimizeFootprint()
{
    EmptyWorkingSet(Process.GetCurrentProcess().Handle);
}