//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace Windows.Storage
{
    /// <summary>
    /// Indicates the reason that data could not be streamed.
    /// </summary>
    public enum StreamedFileFailureMode
    {
        /// <summary>
        /// The data could not be accessed.
        /// </summary>
        CurrentlyUnavailable = 1,
        /// <summary>
        /// Streaming the data failed.
        /// </summary>
        Failed = 0,
        /// <summary>
        /// Streaming the data failed to complete.
        /// </summary>
        Incomplete = 2
    }
}
