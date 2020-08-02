namespace DarkboxPlugin
{
    using System;
    using Loupedeck;

    public class DarkboxApplication : ClientApplication
    {
        protected override String GetProcessName() => "Darkbox";

        protected override String GetBundleName() => ""; // Darkbox application does not exist on MacOS
    }
}