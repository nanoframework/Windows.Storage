//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;
using System.Runtime.CompilerServices;

namespace Windows.Storage
{
    /// <summary>
    /// Manages folders and their contents and provides information about them.
    /// </summary>
    public sealed class StorageFolder : IStorageFolder//, IStorageFolder2, IStorageItem, IStorageItem2, IStorageItemProperties, IStorageItemProperties2, IStorageItemPropertiesWithProvider, IStorageFolderQueryOperations
    {
        #region constants

        private const string s_RemovableStorageDevicesName = "Removable Storage Devices";
        private const string s_RemovableStorageDevicesDisplayType = "System Folder";

        #endregion

        #region backing and internal fields

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly KnownFolderId _knownFolderId;

        #pragma warning disable 0649
        // this field is set in native code
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly DateTime _dateCreated;
        #pragma warning restore 0649

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly string _name;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly string _path;

        #endregion

        /// <summary>
        /// Gets the attributes of the current folder.
        /// </summary>
        public FileAttributes Attributes => FileAttributes.Directory;

        /// <summary>
        /// Gets the date and time that the current folder was created.
        /// </summary>
        /// <remarks>
        /// This is the nanoFrameowrk equivalent of UWP DateCreated of type DateTimeOffset.
        /// </remarks>
        public DateTime DateCreated => _dateCreated;

        ///// <summary>
        ///// Gets the user-friendly name of the current folder.
        ///// </summary>
        //public string DisplayName => _displayName;

        ///// <summary>
        ///// Gets the user-friendly description of the type of the folder; for example, JPEG image.
        ///// </summary>
        //public string DisplayType => _displayType;

        ///// <summary>
        ///// Gets an identifier for the current folder. This ID is unique for the query result or StorageFolder that contains the current folder or file group, and can be used to distinguish between items that have the same name.
        ///// </summary>
        //public string FolderRelativeId => _folderRelativeId;

        /// <summary>
        /// Gets the name of the current folder.
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// Gets the full path of the current folder in the file system, if the path is available.
        /// </summary>
        public string Path => _path;

        //        /// <summary>
        //        /// Gets an object that provides access to the content-related properties of the current folder.
        //        /// </summary>
        //        public StorageItemContentProperties Properties { get; }

        //        /// <summary>
        //        /// Gets the StorageProvider object that contains info about the service that stores the current folder.
        //        /// </summary>
        //        public StorageProvider Provider { get; }

        internal StorageFolder(KnownFolderId folderId)
        {
            // currently there is only support for removable devices
            if (folderId != KnownFolderId.RemovableDevices)
            {
                throw new NotSupportedException();
            }

            _knownFolderId = folderId;
            _name = s_RemovableStorageDevicesName;
            _path = "";
        }

        //        public bool AreQueryOptionsSupported(QueryOptions queryOptions)
        //        { }

        //        public IAsyncOperation<StorageFile> CreateFileAsync(String desiredName)
        //        { }

        //        public StorageFileQueryResult CreateFileQuery()
        //        { }

        //        public StorageFileQueryResult CreateFileQuery(CommonFileQuery query)
        //        { }

        //        public StorageFileQueryResult CreateFileQueryWithOptions(QueryOptions queryOptions)
        //        { }

        //        public IAsyncOperation<StorageFolder> CreateFolderAsync(String desiredName)
        //        { }

        //        public IAsyncOperation<StorageFolder> CreateFolderAsync(String desiredName, CreationCollisionOption options)
        //        { }

        //        public StorageFolderQueryResult CreateFolderQuery()
        //        { }

        //        public StorageFolderQueryResult CreateFolderQuery(CommonFolderQuery query)
        //        { }

        //        public StorageFolderQueryResult CreateFolderQueryWithOptions(QueryOptions queryOptions)
        //        { }

        //        public StorageItemQueryResult CreateItemQuery()
        //        { }

        //        public StorageItemQueryResult CreateItemQueryWithOptions(QueryOptions queryOptions)
        //        { }

        //        public IAsyncAction DeleteAsync()
        //        { }

        //        public IAsyncAction DeleteAsync(StorageDeleteOption option)
        //        { }

        //        public IAsyncOperation<BasicProperties> GetBasicPropertiesAsync()
        //        { }

        //        public IAsyncOperation<StorageFile> GetFileAsync(String name)
        //        { }

        //        public IAsyncOperation<IReadOnlyList<StorageFile>> GetFilesAsync()
        //        { }

        //        public IAsyncOperation<IReadOnlyList<StorageFile>> GetFilesAsync(CommonFileQuery query)
        //        { }

        //        public IAsyncOperation<IReadOnlyList<StorageFile>> GetFilesAsync(CommonFileQuery query, UInt32 startIndex, UInt32 maxItemsToRetrieve)
        //        { }

        //        public IAsyncOperation<StorageFolder> GetFolderAsync(String name)
        //        { }

        //        public static IAsyncOperation<StorageFolder> GetFolderFromPathAsync(String path)
        //        { }

        //        public IAsyncOperation<IReadOnlyList<StorageFolder>> GetFoldersAsync()
        //        { }

        /// <summary>
        /// Gets the subfolders in the current folder.
        /// </summary>
        /// <returns> 
        /// When this method completes successfully, it returns a list of the subfolders in the current folder. The list is of type StorageFolder.
        /// Each folder in the list is represented by a StorageFolder object.
        ///</returns>
        ///<remarks>
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be GetFoldersAsync().
        ///</remarks>
        public StorageFolder[] GetFolders()
        {
            // is this a call for a known folder ID
            // RemovableDevices
            // nothing else is implemented, no need to check as this doesn't get pass the constructor StorageFolder(KnownFolderId folderId)
            if (_knownFolderId == KnownFolderId.RemovableDevices)
            {
                return GetRemovableStorageFoldersNative();
            }

            // regular get folders
            return GetStorageFoldersNative();
        }


        //        public IAsyncOperation<IReadOnlyList<StorageFolder>> GetFoldersAsync(CommonFolderQuery query)
        //        { }

        //        public IAsyncOperation<IReadOnlyList<StorageFolder>> GetFoldersAsync(CommonFolderQuery query, UInt32 startIndex, UInt32 maxItemsToRetrieve)
        //        { }

        //        public IAsyncOperation<IndexedState> GetIndexedStateAsync()
        //        { }

        //        public IAsyncOperation<IStorageItem> GetItemAsync(String name)
        //        { }

        //        public IAsyncOperation<IReadOnlyList<IStorageItem>> GetItemsAsync()
        //        { }

        //        public IAsyncOperation<IReadOnlyList<IStorageItem>> GetItemsAsync(UInt32 startIndex, UInt32 maxItemsToRetrieve)
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

        //        public bool IsCommonFileQuerySupported(CommonFileQuery query)
        //        { }

        //        public bool IsCommonFolderQuerySupported(CommonFolderQuery query)
        //        { }

        //        public bool IsEqual(IStorageItem item)
        //        { }

        //        public bool IsOfType(StorageItemTypes type)
        //        { }

        //        public IAsyncAction RenameAsync(String desiredName)
        //        { }

        //        public IAsyncAction RenameAsync(String desiredName, NameCollisionOption option)
        //        { }

        //        public StorageLibraryChangeTracker TryGetChangeTracker()
        //        { }

        //        public IAsyncOperation<IStorageItem> TryGetItemAsync(String name)
        //        { }

        #region Native calls 

        [System.Diagnostics.DebuggerStepThrough]
        [System.Diagnostics.DebuggerHidden]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern StorageFolder[] GetRemovableStorageFoldersNative();

        [System.Diagnostics.DebuggerStepThrough]
        [System.Diagnostics.DebuggerHidden]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern StorageFolder[] GetStorageFoldersNative();

        #endregion

    }
}
