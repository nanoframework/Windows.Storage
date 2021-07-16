//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Storage
{
    /// <summary>
    /// Provides access to common locations that contain user content. This includes content from a user's local libraries (such as Documents, Pictures, Music, and Videos), HomeGroup, removable devices, and media server devices.
    /// </summary>
    public static class KnownFolders
    {
        //public static StorageFolder AppCaptures { get; }
        //public static StorageFolder CameraRoll { get; }
        //public static StorageFolder DocumentsLibrary { get; }
        //public static StorageFolder HomeGroup { get; }
        //public static StorageFolder MediaServerDevices { get; }
        //public static StorageFolder MusicLibrary { get; }
        //public static StorageFolder Objects3D { get; }
        //public static StorageFolder PicturesLibrary { get; }
        //public static StorageFolder Playlists { get; }
        //public static StorageFolder RecordedCalls { get; }

        /// <summary>
        /// Gets the removable devices folder.
        /// </summary>
        public static StorageFolder RemovableDevices => new StorageFolder(KnownFolderId.RemovableDevices);


        /// <summary>
        /// Gets the internal devices folder.
        /// </summary>
        public static StorageFolder InternalDevices => new StorageFolder(KnownFolderId.InternalDevices);


        //public static StorageFolder SavedPictures { get; }
        //public static StorageFolder VideosLibrary { get; }

        //public static IAsyncOperation<StorageFolder> GetFolderForUserAsync(User user, KnownFolderId folderId)
        //{

        //}

        #region Native methods


        #endregion
    }
}