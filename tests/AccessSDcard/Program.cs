using System;
using System.Threading;
using Windows.Storage;

namespace AccessSDcard
{
    public class Program
    {
        public static void Main()
        {
            // Get the logical root folder for all removable storage devices
            StorageFolder externalDevices = Windows.Storage.KnownFolders.RemovableDevices;

            // list all removable storage devices
            var removableDevices = externalDevices.GetFolders();

            // get folders on SDCard (which should be the 1st device)
            var foldersInSDcard = removableDevices[0].GetFolders();

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
