//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;
using System.Runtime.CompilerServices;

namespace Windows.Storage
{
    /// <summary>
    /// Represents a file. Provides information about the file and its content, and ways to manipulate them.
    /// </summary>
    public sealed class StorageFile : IStorageFile//, IStorageFile2, IStorageFilePropertiesWithAvailability, IStorageItem, IStorageItem2, IStorageItemProperties, IStorageItemProperties2, IStorageItemPropertiesWithProvider, IInputStreamReference, IRandomAccessStreamReference
    {
        #region backing and internal fields

#pragma warning disable 0649

        // this field is set in native code
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly DateTime _dateCreated;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _name;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _path;

#pragma warning restore 0649

        #endregion

        /// <summary>
        /// Gets the attributes of a file.
        /// </summary>
        /// <value>
        /// The file attributes.
        /// </value>
        public FileAttributes Attributes => FileAttributes.Normal;

        /// <summary>
        /// Gets the MIME type of the contents of the file.
        /// </summary>
        ///<remarks>
        /// This property is not available in nanoFramework.
        ///</remarks>
        public string ContentType => "";

        /// <summary>
        /// Gets the date and time that the current folder was created.
        /// </summary>
        /// <remarks>
        /// This is the nanoFrameowrk equivalent of UWP DateCreated of type DateTimeOffset.
        /// </remarks>
        public DateTime DateCreated => _dateCreated;

        /// <summary>
        /// Gets the user-friendly name of the current folder.
        /// </summary>
        ///<remarks>
        /// This property is not available in nanoFramework.
        ///</remarks>
        public string DisplayName => "";

        /// <summary>
        /// Gets the user-friendly description of the type of the folder; for example, JPEG image.
        /// </summary>
        ///<remarks>
        /// This property is not available in nanoFramework.
        ///</remarks>
        public string DisplayType => "";

        /// <summary>
        /// Gets the type (file name extension) of the file.
        /// </summary>
        public string FileType
        {
            get
            {
                if(_name != null)
                {
                    var dotIndex = _name.LastIndexOf('.');

                    return _name.Substring(dotIndex + 1, _name.Length - dotIndex - 1);
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// Gets an identifier for the file. This ID is unique for the query result or <see cref="StorageFolder"/> that contains the file and can be used to distinguish between items that have the same name.
        /// </summary>
        ///<remarks>
        /// This property is not available in nanoFramework.
        ///</remarks>
        public string FolderRelativeId => "";

        /// <summary>
        /// Indicates if the file is local, is cached locally, or can be downloaded.
        /// </summary>
        /// <value>
        /// True if the file is local, is cached locally, or can be downloaded. Otherwise, false.
        /// </value>
        ///<remarks>
        /// This property is always true in nanoFramework.
        ///</remarks>
        public bool IsAvailable => true;

        /// <summary>
        /// Gets the name of the file including the file name extension.
        /// </summary>
        /// <value>
        /// The name of the file including the file name extension.
        /// </value>
        public string Name => _name;

        /// <summary>
        /// Gets the full file-system path of the current file, if the file has a path.
        /// </summary>
        public string Path => _path;

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

        /// <summary>
        /// Gets a StorageFile object to represent the file at the specified path.
        /// </summary>
        /// <param name="path">The path of the file to get a StorageFile to represent.</param>
        /// <returns>Returns the file as a StorageFile.</returns>
        ///<remarks>
        ///
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be GetFileFromPathAsync(String).
        ///</remarks>
        public static StorageFile GetFileFromPath(String path)
        {
            StorageFile file = new StorageFile();

            CheckFileNative(path);

            file._path = path;

            return file;
        }

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


        [System.Diagnostics.DebuggerStepThrough]
        [System.Diagnostics.DebuggerHidden]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern void CheckFileNative(string filePath);

    }
}
