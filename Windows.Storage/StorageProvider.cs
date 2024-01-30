//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using System.Runtime.CompilerServices;

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

        /// <summary>
        /// Formats the specified volume.
        /// *** NOTE THAT THIS OPERATION IS NOT REVERSIBLE ***.
        /// </summary>
        /// <param name="driveNane">The <see cref="KnownFolderId"/> to format.</param>
        /// <exception cref="System.ArgumentException">Thrown when the <paramref name="driveNane"/> is not a supported <see cref="KnownFolderId"/>.</exception>"
        /// <exception cref="System.NotSupportedException">Thrown when the target doesn't have support for performing the format operation on the specified folder.</exception>
        /// <exception cref="System.IO.IOException">Thrown when the operation fails.</exception>"
        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern void FormatVolume(string driveNane);

        //public IAsyncOperation<bool> IsPropertySupportedForPartialFileAsync(String propertyCanonicalName)
        //{ }

    }
}
