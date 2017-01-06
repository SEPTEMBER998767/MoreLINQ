using System;
using System.IO;

var date = DateTime.UtcNow;
var version = new Version(2, 0,
    /* bld */ ((date.Year - 2000) * 12 + date.Month - 1) * 100 + date.Day,
    /* rev */ date.Hour * 100 + date.Minute);

var output = $@"
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// Generated: {date.ToString("r")}

using System.Reflection;

[assembly: AssemblyVersion(""{version.ToString(3)}.0"")]
[assembly: AssemblyFileVersion(""{version.ToString()}"")]";

Console.WriteLine(output.Trim());