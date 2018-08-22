//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Storage
{
    /// <summary>
    /// Contains info about the service that stores files and folders. Files and folders may be stored either by the local file system or by a remote service like Microsoft OneDrive.
    /// </summary>
    public sealed class StorageProvider : IStorageProvider
    {
        public string DisplayName { get; }

        public string Id { get; }

        public IAsyncOperation<bool> IsPropertySupportedForPartialFileAsync(String propertyCanonicalName)
        { }

    }
}
