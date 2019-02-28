//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace Windows.Storage
{
    /// <summary>
    /// Contains info about the service that stores files and folders. Files and folders may be stored either by the local file system or by a remote service like Microsoft OneDrive.
    /// </summary>
    public sealed class StorageProvider : IStorageProvider
    {

        #pragma warning disable 0649

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly string _displayName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly string _id;

        #pragma warning restore 0649

        /// <summary>
        /// Gets a user-friendly name for the current provider of files and folders.
        /// </summary>
        /// <value>
        /// The user-friendly name for the provider. This name is localized to the current system locale.
        /// </value> 
        public string DisplayName => _displayName;

        /// <summary>
        /// Gets an identifier for the current provider of files and folders.
        /// </summary>
        /// <value>
        /// The identifier for the provider.
        /// </value>
        /// <remarks>
        /// The ID can be Local, Network, or OneDrive depending on your provider.
        /// </remarks>
        public string Id => _id;

        //public IAsyncOperation<bool> IsPropertySupportedForPartialFileAsync(String propertyCanonicalName)
        //{ }

    }
}
