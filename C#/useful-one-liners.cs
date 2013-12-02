// Get Running application directory.
System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

// Change System Time
//http://msdn.microsoft.com/en-us/library/microsoft.visualbasic.dateandtime.timeofday(v=vs.100).aspx
Microsoft.VisualBasic.DateAndTime.TimeOfDay = DateTime;

// Check if string is in a string
//http://stackoverflow.com/questions/444798/case-insensitive-containsstring
string1.ToLower().Contains(string2.ToLower())
