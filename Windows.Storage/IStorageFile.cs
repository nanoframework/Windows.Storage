//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Storage
{
    /// <summary>
    /// Represents a file. Provides information about the file and its contents, and ways to manipulate them.
    /// </summary>
    public interface IStorageFile : IStorageItem//, IInputStreamReference, IRandomAccessStreamReference
    {
        /// <summary>
        /// Gets the MIME type of the contents of the file.
        /// </summary>
        string ContentType { get; }

        /// <summary>
        /// Gets the type (file name extension) of the file.
        /// </summary>
        string FileType { get; }

        //        public IAsyncAction CopyAndReplaceAsync(IStorageFile fileToReplace);

        //        public IAsyncOperation<StorageFile> CopyAsync(IStorageFolder destinationFolder);

        //        public IAsyncOperation<StorageFile> CopyAsync(IStorageFolder destinationFolder, String desiredNewName);

        //        public IAsyncOperation<StorageFile> CopyAsync(IStorageFolder destinationFolder, String desiredNewName, NameCollisionOption option);

        //        public IAsyncAction MoveAndReplaceAsync(IStorageFile fileToReplace);

        //        public IAsyncAction MoveAsync(IStorageFolder destinationFolder);

        //        public IAsyncAction MoveAsync(IStorageFolder destinationFolder, String desiredNewName);

        //        public IAsyncAction MoveAsync(IStorageFolder destinationFolder, String desiredNewName, NameCollisionOption option);

        //        public IAsyncOperation<IRandomAccessStream> OpenAsync(FileAccessMode accessMode);

        //        public IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync();

    }
}
