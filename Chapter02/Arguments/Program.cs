using static System.Console;
namespace Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} arguments.");

            foreach(string arg in args)
            {
                WriteLine(arg);
            }

            if (args.Length<3)
            {
                WriteLine("You must specify two colors and a cursors size, e.g.");
                WriteLine("dotnet run red yellow 50");
                return; //stop running
            }

            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase: true);

            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[1],
                ignoreCase: true);


            try
            { 
                CursorSize = int.Parse(args[2]);
            
            }

            catch (PlatformNotSupportedException)
            {
                WriteLine("The current platform doest not support changing the size of the cursor.");
            }

            //Another way to handle differences in operating systems is to use the OperatingSystem class in
            //the System namespace, as shown in the following code:

            if (OperatingSystem.IsWindows())
            {
                // execute code that only works on Windows
            }
            else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
            {
                // execute code that only works on Windows 10 or later
            }
            else if (OperatingSystem.IsIOSVersionAtLeast(major: 14, minor: 5))
            {
                // execute code that only works on iOS 14.5 or later
            }
            else if (OperatingSystem.IsBrowser())
            {
                // execute code that only works in the browser with Blazor
            }

            //You can then write statements that will compile only for the specified platforms, as shown in
            //the following code:

            #if NET6_0_ANDROID
            //compile statements that only works on Android
            #elif NET_6_0_IOS
            //compile statments that only works on iOS
            #else
            //compile statements that work everywhere else
            #endif

        }
    }
}