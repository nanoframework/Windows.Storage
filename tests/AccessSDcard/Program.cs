using System;
using System.Threading;
using Windows.Storage;

namespace AccessSDcard
{
    public class Program
    {
        public static void Main()
        {
            // need to wait for the drives to be enumrated
            Thread.Sleep(3000);

            // Get the logical root folder for all removable storage devices
            StorageFolder externalDevices = Windows.Storage.KnownFolders.RemovableDevices;

            // list all removable storage devices
            var removableDevices = externalDevices.GetFolders();

            if (removableDevices.Length > 0)
            {
                // get folders on 1st removable device
                var foldersInDevice = removableDevices[0].GetFolders();

                // get files on the root of the 1st removable device
                var filesInDevice = removableDevices[0].GetFiles();
            }

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
