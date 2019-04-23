//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;
using System.Runtime.CompilerServices;
using Windows.Storage.Search;

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
        private const string s_InternalStorageDevicesName = "Internal Storage Devices";

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
        private string _name;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _path;

        #endregion

        /// <summary>
        /// Gets the attributes of the current folder.
        /// </summary>
        /// <value>
        /// The attributes of the current folder.
        /// </value>
        public FileAttributes Attributes => FileAttributes.Directory;

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
        /// Gets the user-friendly description of the type of the folder.
        /// </summary>
        ///<remarks>
        /// This property is not available in nanoFramework.
        ///</remarks>
        public string DisplayType => "";

        /// <summary>
        /// Gets an identifier for the current folder. This ID is unique for the query result or <see cref="StorageFolder"/> that contains the current folder or file group, and can be used to distinguish between items that have the same name.
        /// </summary>
        ///<remarks>
        /// This property is not available in nanoFramework.
        ///</remarks>
        public string FolderRelativeId => "";

        /// <summary>
        /// Gets the name of the current folder.
        /// </summary>
        /// <value>
        /// The name of the current folder.
        /// </value>
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
            // and internal storage devices
            if (folderId == KnownFolderId.RemovableDevices)
            {
                _name = s_RemovableStorageDevicesName;
            }
            else if (folderId == KnownFolderId.InternalDevices)
            {
                _name = s_InternalStorageDevicesName;
            }
            else
            {
                throw new NotSupportedException();
            }

            _knownFolderId = folderId;
            _path = "";
        }

        //        public bool AreQueryOptionsSupported(QueryOptions queryOptions)
        //        { }

        /// <summary>
        /// Creates a new file with the specified name in the current folder.
        /// </summary>
        /// <param name="desiredName">The name of the new file to create in the current folder.</param>
        /// <returns>When this method completes, it returns a <see cref="StorageFile"/> that represents the new file.</returns>
        ///<remarks>
        /// This method uses the FailIfExists value from the <see cref="CreationCollisionOption"/> enumeration by default. That is, this method raises an exception if a subfolder with the same name already exists in the current folder. If you want to handle a folder name collision in a different way, call the <see cref="CreateFile(string, CreationCollisionOption)"/> method.
        ///
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be CreateFileAsync(String).
        ///</remarks>
        public StorageFile CreateFile(String desiredName)
        {
            return CreateFile(desiredName, CreationCollisionOption.FailIfExists);
        }

        /// <summary>
        /// Creates a new file with the specified name in the current folder.
        /// </summary>
        /// <param name="desiredName">The name of the new file to create in the current folder.</param>
        /// <param name="options">One of the enumeration values that determines how to handle the collision if a file with the specified desiredName already exists in the current folder.</param>
        /// <returns>When this method completes, it returns a <see cref="StorageFile"/> that represents the new file.</returns>
        ///<remarks>
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be CreateFileAsync(String, CreationCollisionOption).
        ///</remarks>
        public StorageFile CreateFile(String desiredName, CreationCollisionOption options)
        {
            return CreateFileNative(desiredName, (UInt32)options);
        }

        //        public StorageFileQueryResult CreateFileQuery()
        //        { }

        //        public StorageFileQueryResult CreateFileQuery(CommonFileQuery query)
        //        { }

        //        public StorageFileQueryResult CreateFileQueryWithOptions(QueryOptions queryOptions)
        //        { }

        /// <summary>
        /// Creates a new subfolder with the specified name in the current folder.
        /// </summary>
        /// <param name="desiredName">The name of the new subfolder to create in the current folder.</param>
        /// <returns>
        /// When this method completes, it returns a <see cref="StorageFolder"/> that represents the new subfolder.
        /// </returns>
        ///<remarks>
        /// This method uses the FailIfExists value from the <see cref="CreationCollisionOption"/> enumeration by default. That is, this method raises an exception if a subfolder with the same name already exists in the current folder. If you want to handle a folder name collision in a different way, call the <see cref="CreateFolder(string, CreationCollisionOption)"/> method.
        /// 
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be CreateFolderAsync(String).
        ///</remarks>
        public StorageFolder CreateFolder(String desiredName)
        {
            return CreateFolder(desiredName, CreationCollisionOption.FailIfExists);
        }

        /// <summary>
        /// Creates a new subfolder with the specified name in the current folder. This method also specifies what to do if a subfolder with the same name already exists in the current folder.
        /// </summary>
        /// <param name="desiredName">The name of the new subfolder to create in the current folder.</param>
        /// <param name="options">One of the enumeration values that determines how to handle the collision if a subfolder with the specified desiredName already exists in the current folder.</param>
        /// <returns>
        /// When this method completes, it returns a <see cref="StorageFolder"/> that represents the new subfolder.
        /// </returns>
        ///<remarks>
        /// <para>
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be CreateFolderAsync(String, CreationCollisionOption).
        /// </para>
        ///</remarks>
        public StorageFolder CreateFolder(String desiredName, CreationCollisionOption options)
        {
            return CreateFolderNative(desiredName, (UInt32)options);
        }

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

        /// <summary>
        /// Delete the current folder.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the folder doesn't exist then this method will throw an exception.
        /// </para>
        /// <para>This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be DeleteAsync().
        /// </para>
        /// </remarks>
        public void Delete()
        {
            DeleteFolderNative();
        }

        //        public IAsyncAction DeleteAsync(StorageDeleteOption option)
        //        { }

        //        public IAsyncOperation<BasicProperties> GetBasicPropertiesAsync()
        //        { }

        //        public IAsyncOperation<StorageFile> GetFileAsync(String name)
        //        { }


        /// <summary>
        /// Gets the files in the current folder.
        /// </summary>
        /// <returns>
        /// When this method completes successfully, it returns a list of the files in the current folder. 
        /// The list is of type <see cref="StorageFile"/>. Each file in the list is represented by a <see cref="StorageFile"/> object.
        /// </returns>
        ///<remarks>
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be GetFilesAsync().
        ///</remarks> 
        public StorageFile[] GetFiles()
        {
            return GetStorageFilesNative(0, UInt32.MaxValue);
        }

        /// <summary>
        /// Gets the files in the current folder. Also gets the files from the subfolders of the current folder when the value of the query argument is something other than <see cref="CommonFileQuery.DefaultQuery"/>.
        /// Files are sorted based on the specified value from the <see cref="CommonFileQuery"/> enumeration.
        /// </summary>
        /// <param name="query">One of the enumeration values that specifies how to sort the files and determines whether the query is shallow or deep.</param>
        /// <returns>
        /// When this method completes successfully, it returns a flat list of files, sorted as specified by query. 
        /// The list is of type <see cref="StorageFile"/>. Each file in the list is represented by a <see cref="StorageFile"/> object.
        /// </returns>
        ///<remarks>
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be GetFilesAsync(CommonFileQuery).
        ///</remarks> 
        public StorageFile[] GetFiles(CommonFileQuery query)
        {
            // check CommonFileQuery
            if(query != CommonFileQuery.DefaultQuery)
            {
                throw new ArgumentException();
            }

            return GetStorageFilesNative(0, UInt32.MaxValue);
        }

        /// <summary>
        /// Gets an index-based range of files from the list of all files in the current folder. Also gets the files from the subfolders of the current folder when the value of the query argument is something other than <see cref="CommonFileQuery.DefaultQuery"/>. Files are sorted based on the specified value from the <see cref="CommonFileQuery"/> enumeration.
        /// </summary>
        /// <param name="query">One of the enumeration values that specifies how to sort the files and determines whether the query is shallow or deep.</param>
        /// <param name="startIndex">The zero-based index of the first file in the range to retrieve.</param>
        /// <param name="maxItemsToRetrieve">The maximum number of files to retrieve.</param>
        /// <returns>
        /// When this method completes successfully, it returns a flat list of files, sorted as specified by query. 
        /// The list is of type <see cref="StorageFile"/>. Each file in the list is represented by a <see cref="StorageFile"/> object.
        /// </returns>
        ///<remarks>
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be GetFilesAsync(CommonFileQuery, UInt32, UInt32).
        ///</remarks> 
        public StorageFile[] GetFiles(CommonFileQuery query, UInt32 startIndex, UInt32 maxItemsToRetrieve)
        {
            // check CommonFileQuery
            if (query != CommonFileQuery.DefaultQuery)
            {
                throw new ArgumentException();
            }

            return GetStorageFilesNative(startIndex, maxItemsToRetrieve);
        }

        /// <summary>
        /// Gets the subfolder with the specified name from the current folder.
        /// </summary>
        /// <param name="name">The name (or path relative to the current folder) of the subfolder to get.</param>
        /// <returns>
        /// When this method completes successfully, it returns a StorageFolder that represents the specified subfolder.
        /// </returns>
        /// <remarks>
        /// <para>
        /// If the folder doesn't exist it will throw an exception.
        /// </para>
        /// <para>
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be GetFolderAsync(String name).
        /// </para>
        /// </remarks>
        public StorageFolder GetFolder(String name)
        {
            return GetFolderNative(name);
        } 

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
            // RemovableDevices & InternalDevices
            // nothing else is implemented, no need to check as this doesn't get pass the constructor StorageFolder(KnownFolderId folderId)
            if (_knownFolderId == KnownFolderId.RemovableDevices)
            {
                return GetRemovableStorageFoldersNative();
            }
            else if (_knownFolderId == KnownFolderId.InternalDevices)
            {
                return GetInternalStorageFoldersNative();
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

        /// <summary>
        /// Indicates whether the current folder supports the specified <see cref="CommonFileQuery"/>.
        /// </summary>
        /// <param name="query">The value to test.</param>
        /// <returns>
        /// True if the folder supports the specified <see cref="CommonFileQuery"/> otherwise, false.
        /// </returns>
        public bool IsCommonFileQuerySupported(CommonFileQuery query)
        {
            return query == CommonFileQuery.DefaultQuery;
        }

        //        public bool IsCommonFolderQuerySupported(CommonFolderQuery query)
        //        { }

        //        public bool IsEqual(IStorageItem item)
        //        { }

        //        public bool IsOfType(StorageItemTypes type)
        //        { }

        /// <summary>
        /// Renames the current folder.
        /// </summary>
        /// <param name="desiredName">The desired, new name for the current folder.</param>
        /// <remarks>
        /// <para>If the name you specify is invalid or a folder with the same name already exists, 
        /// this method throws an exception. If the target device doesn't support folders then this will also
        /// throw an exception.</para>
        /// <para>This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be RenameAsync(String desiredName).</para>
        /// </remarks>
        public void Rename(String desiredName)
        {
            // Create path to disired folder
            string desiredPath = _path.Substring(0, _path.Length - _name.Length) + desiredName;

            RenameFolderNative(desiredPath);

            // No exception, so update folder Path & name
            _path = desiredPath;
            _name = desiredName;
        }

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
        private extern StorageFolder[] GetInternalStorageFoldersNative();

        [System.Diagnostics.DebuggerStepThrough]
        [System.Diagnostics.DebuggerHidden]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern StorageFolder[] GetStorageFoldersNative();

        [System.Diagnostics.DebuggerStepThrough]
        [System.Diagnostics.DebuggerHidden]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern StorageFile[] GetStorageFilesNative(uint startIndex, uint maxItemsToRetrieve);

        [System.Diagnostics.DebuggerStepThrough]
        [System.Diagnostics.DebuggerHidden]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern StorageFile CreateFileNative(string desiredName, uint options);

        [System.Diagnostics.DebuggerStepThrough]
        [System.Diagnostics.DebuggerHidden]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern StorageFolder CreateFolderNative(string desiredName, uint options);

        [System.Diagnostics.DebuggerStepThrough]
        [System.Diagnostics.DebuggerHidden]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern void DeleteFolderNative();

        [System.Diagnostics.DebuggerStepThrough]
        [System.Diagnostics.DebuggerHidden]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern void RenameFolderNative(String desiredPath);

        [System.Diagnostics.DebuggerStepThrough]
        [System.Diagnostics.DebuggerHidden]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern StorageFolder GetFolderNative(String name);
        #endregion

    }
}
