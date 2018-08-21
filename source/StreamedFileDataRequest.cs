//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Storage
{
    /// <summary>
    /// Represents a sequential-access output stream that indicates a request for the data stream of a StorageFile that was created by calling CreateStreamedFileAsync or ReplaceWithStreamedFileAsync.
    /// </summary>
    public sealed class StreamedFileDataRequest : IDisposable, IStreamedFileDataRequest, IOutputStream
    {
    }
}
