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
        //        public FileAttributes Attributes { get; }

        //        public DateTimeOffset DateCreated { get; }

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

        //        public IAsyncAction RenameAsync(String desiredName);

        //        public IAsyncAction RenameAsync(String desiredName, NameCollisionOption option);

    }
}
