//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Storage
{
    /// <summary>
    /// Represents the method that will stream data into a StorageFile when that file is first accessed.
    /// </summary>
    /// <param name="stream">The request for the streamed data in the StorageFile that was created by the CreateStreamedFileAsync or ReplaceWithStreamedFileAsync method.</param>
    public delegate void StreamedFileDataRequestedHandler(StreamedFileDataRequest stream)
    {
    }
}
