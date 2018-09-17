////
//// Copyright (c) 2018 The nanoFramework project contributors
//// See LICENSE file in the project root for full license information.
////

//using System;

//namespace Windows.Storage
//{
//    /// <summary>
//    /// Represents a file. Provides information about the file and its content, and ways to manipulate them.
//    /// </summary>
//    public sealed class StorageFile : IStorageFile, IStorageFile2, IStorageFilePropertiesWithAvailability, IStorageItem, IStorageItem2, IStorageItemProperties, IStorageItemProperties2, IStorageItemPropertiesWithProvider, IInputStreamReference, IRandomAccessStreamReference
//    {
//        public FileAttributes Attributes { get; }

//        public string ContentType { get; }

//        public DateTimeOffset DateCreated { get; }

//        public string DisplayName { get; }

//        public string DisplayType { get; }

//        public string FileType { get; }

//        public string FolderRelativeId { get; }

//        public bool IsAvailable { get; }

//        public string Name { get; }

//        public string Path { get; }

//        public StorageItemContentProperties Properties { get; }

//        public StorageProvider Provider { get; }

//        public IAsyncAction CopyAndReplaceAsync(IStorageFile fileToReplace)
//        { }

//        public IAsyncOperation<StorageFile> CopyAsync(IStorageFolder destinationFolder)
//        { }

//        public IAsyncOperation<StorageFile> CopyAsync(IStorageFolder destinationFolder, String desiredNewName)
//        { }

//        public IAsyncOperation<StorageFile> CopyAsync(IStorageFolder destinationFolder, String desiredNewName, NameCollisionOption option)
//        { }

//        public static IAsyncOperation<StorageFile> CreateStreamedFileAsync(String displayNameWithExtension, StreamedFileDataRequestedHandler dataRequested, IRandomAccessStreamReference thumbnail)
//        { }

//        public static IAsyncOperation<StorageFile> CreateStreamedFileFromUriAsync(String displayNameWithExtension, Uri uri, IRandomAccessStreamReference thumbnail)
//        { }

//        public IAsyncAction DeleteAsync()
//        { }

//        public IAsyncAction DeleteAsync(StorageDeleteOption option)
//        { }

//        public IAsyncOperation<BasicProperties> GetBasicPropertiesAsync()
//        { }

//        public static IAsyncOperation<StorageFile> GetFileFromApplicationUriAsync(Uri uri)
//        { }

//        public static IAsyncOperation<StorageFile> GetFileFromPathAsync(String path)
//        { }

//        public IAsyncOperation<StorageFolder> GetParentAsync()
//        { }

//        public IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(ThumbnailMode mode)
//        { }

//        public IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(ThumbnailMode mode, UInt32 requestedSize)
//        { }

//        public IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(ThumbnailMode mode, UInt32 requestedSize, ThumbnailOptions options)
//        { }

//        public IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(ThumbnailMode mode)
//        { }

//        public IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(ThumbnailMode mode, UInt32 requestedSize)
//        { }

//        public IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(ThumbnailMode mode, UInt32 requestedSize, ThumbnailOptions options)
//        { }

//        public bool IsEqual(IStorageItem item)
//        { }

//        public bool IsOfType(StorageItemTypes type)
//        { }

//        public IAsyncAction MoveAndReplaceAsync(IStorageFile fileToReplace)
//        { }

//        public IAsyncAction MoveAsync(IStorageFolder destinationFolder)
//        { }

//        public IAsyncAction MoveAsync(IStorageFolder destinationFolder, String desiredNewName)
//        { }

//        public IAsyncAction MoveAsync(IStorageFolder destinationFolder, String desiredNewName, NameCollisionOption option)
//        { }

//        public IAsyncOperation<IRandomAccessStream> OpenAsync(FileAccessMode accessMode)
//        { }

//        public IAsyncOperation<IRandomAccessStream> OpenAsync(FileAccessMode accessMode, StorageOpenOptions options)
//        { }

//        public IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync()
//        { }

//        public IAsyncOperation<IInputStream> OpenSequentialReadAsync()
//        { }

//        public IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync()
//        { }

//        public IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync(StorageOpenOptions options)
//        { }

//        public IAsyncAction RenameAsync(String desiredName)
//        { }

//        public IAsyncAction RenameAsync(String desiredName, NameCollisionOption option)
//        { }

//        public static IAsyncOperation<StorageFile> ReplaceWithStreamedFileAsync(IStorageFile fileToReplace, StreamedFileDataRequestedHandler dataRequested, IRandomAccessStreamReference thumbnail)
//        { }

//        public static IAsyncOperation<StorageFile> ReplaceWithStreamedFileFromUriAsync(IStorageFile fileToReplace, Uri uri, IRandomAccessStreamReference thumbnail)
//        { }
//    }
//}
