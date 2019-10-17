//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Storage
{
    /// <summary>
    /// Manipulates storage items (files and folders) and their contents, and provides information about them.
    /// </summary>
    public interface IStorageItem
    {
        /// <summary>
        /// Gets the attributes of a file.
        /// </summary>
        /// <value>
        /// The file attributes.
        /// </value>
        FileAttributes Attributes { get; }

        /// <summary>
        /// Gets the date and time that the current folder was created.
        /// </summary>
        /// <remarks>
        /// This is the nanoFrameowrk equivalent of UWP DateCreated of type DateTimeOffset.
        /// </remarks>
        DateTime DateCreated { get; }

        /// <summary>
        /// Gets the name of the item including the file name extension if there is one.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the full file-system path of the item, if the item has a path.
        /// </summary>
        string Path { get; }

        //        public IAsyncAction DeleteAsync();

        //        public IAsyncAction DeleteAsync(StorageDeleteOption option);

        //        public IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();

        //        public bool IsOfType(StorageItemTypes type);


        /// <summary>
        /// Renames the current item.
        /// </summary>
        /// <param name="desiredName">The desired, new name of the item.</param>
        void Rename(String desiredName);

        //        public IAsyncAction RenameAsync(String desiredName, NameCollisionOption option);

    }
}
