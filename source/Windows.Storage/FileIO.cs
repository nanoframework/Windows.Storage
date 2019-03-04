//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;
using System.Runtime.CompilerServices;

namespace Windows.Storage
{
    /// <summary>
    /// Provides helper methods for reading and writing files that are represented by objects of type IStorageFile.
    /// </summary>
    public static class FileIO
    {
        //        AppendLinesAsync(IStorageFile, IIterable<String>)
        //        {

        //        }

        //        AppendLinesAsync(IStorageFile, IIterable<String>, UnicodeEncoding)
        //        {

        //        }

        //        AppendTextAsync(IStorageFile, String)
        //        {

        //        }

        //        AppendTextAsync(IStorageFile, String, UnicodeEncoding)
        //        {

        //        }

        //        ReadBufferAsync(IStorageFile)
        //        {

        //        }

        //        ReadLinesAsync(IStorageFile)
        //        {

        //        }

        //        ReadLinesAsync(IStorageFile, UnicodeEncoding)
        //        {

        //        }

        /// <summary>
        /// Reads the contents of the specified file and returns text.
        /// </summary>
        /// <param name="file">The file to read.</param>
        /// <returns>
        /// When this method completes successfully, it returns the contents of the file as a text string.
        /// </returns>
        ///<remarks>
        /// The encoding will always be <see cref="Streams.UnicodeEncoding.Utf8"/> which is the only supported encoding in nanoFramework.
        /// 
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be ReadTextAsync(IStorageFile).
        ///</remarks>
        [System.Diagnostics.DebuggerStepThrough]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern static String ReadText(IStorageFile file);

        //        ReadTextAsync(IStorageFile, UnicodeEncoding)
        //        {

        //        }

        //        WriteBufferAsync(IStorageFile, IBuffer)
        //        {

        //        }

        //        WriteBytesAsync(IStorageFile, Byte[])
        //        {

        //        }

        //        WriteLinesAsync(IStorageFile, IIterable<String>)
        //        {

        //        }

        //        WriteLinesAsync(IStorageFile, IIterable<String>, UnicodeEncoding)
        //        {

        //        }

        /// <summary>
        /// Writes text to the specified file.
        /// </summary>
        /// <param name="file">The file that the text is written to.</param>
        /// <param name="contents">The text to write.</param>
        /// <return>
        /// No object or value is returned when this method completes.
        /// </return>
        ///<remarks>
        /// The encoding will always be <see cref="Streams.UnicodeEncoding.Utf8"/> which is the only supported encoding in nanoFramework.
        /// 
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be WriteTextAsync(IStorageFile, String).
        ///</remarks>
        [System.Diagnostics.DebuggerStepThrough]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern static void WriteText(IStorageFile file, String contents);

        //        WriteTextAsync(IStorageFile, String, UnicodeEncoding)
        //        {

        //        }
    }
}
