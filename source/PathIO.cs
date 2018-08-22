//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Storage
{
    /// <summary>
    /// Provides helper methods for reading and writing a file using the absolute path or Uniform Resource Identifier (URI) of the file.
    /// </summary>
    public static class PathIO
    {
        public static IAsyncAction AppendLinesAsync(String absolutePath, IEnumerable<String> lines)
        { }

        public static IAsyncAction AppendLinesAsync(String absolutePath, IEnumerable<String> lines, UnicodeEncoding encoding)
        { }

        public static IAsyncAction AppendTextAsync(String absolutePath, String contents)
        { }

        public static IAsyncAction AppendTextAsync(String absolutePath, String contents, UnicodeEncoding encoding)
        { }

        public static IAsyncOperation<IBuffer> ReadBufferAsync(String absolutePath)
        { }

        public static IAsyncOperation<IList<string>> ReadLinesAsync(String absolutePath)
        { }

        public static IAsyncOperation<IList<string>> ReadLinesAsync(String absolutePath, UnicodeEncoding encoding)
        { }

        public static IAsyncOperation<string> ReadTextAsync(String absolutePath)
        { }

        public static IAsyncOperation<string> ReadTextAsync(String absolutePath, UnicodeEncoding encoding)
        { }

        public static IAsyncAction WriteBufferAsync(String absolutePath, IBuffer buffer)
        { }

        public static IAsyncAction WriteBytesAsync(String absolutePath, Byte[] buffer)
        { }

        public static IAsyncAction WriteLinesAsync(String absolutePath, IEnumerable<String> lines)
        { }

        public static IAsyncAction WriteLinesAsync(String absolutePath, IEnumerable<String> lines, UnicodeEncoding encoding)
        { }

        public static IAsyncAction WriteTextAsync(String absolutePath, String contents)
        { }

        public static IAsyncAction WriteTextAsync(String absolutePath, String contents, UnicodeEncoding encoding)
        { }

    }
}
