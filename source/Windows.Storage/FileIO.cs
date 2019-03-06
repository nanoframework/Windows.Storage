//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;
using System.Runtime.CompilerServices;
using Windows.Storage.Streams;

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

        /// <summary>
        /// Reads the contents of the specified file and returns a buffer.
        /// </summary>
        /// <param name="file">The file to read.</param>
        /// <returns>
        /// When this method completes, it returns an object (type <see cref="IBuffer"/>) that represents the contents of the file.
        /// </returns>
        ///<remarks>
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be ReadBufferAsync(IStorageFile).
        ///</remarks>
        public static IBuffer ReadBuffer(IStorageFile file)
        {
            byte[] tempBuffer = null;
            ReadBufferNative(file, ref tempBuffer);
            ByteBuffer buffer = new ByteBuffer(tempBuffer);
            return (IBuffer)buffer;
        }

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
        public static String ReadText(IStorageFile file)
        {
            String text = null;

            ReadTextNative(file, ref text);

            return text;
        }

        //        ReadTextAsync(IStorageFile, UnicodeEncoding)
        //        {

        //        }

        /// <summary>
        /// Writes data from a buffer to the specified file.
        /// </summary>
        /// <param name="file">The file that the buffer of data is written to.</param>
        /// <param name="buffer">The buffer that contains the data to write.</param>
        ///<remarks>
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be WriteBuffer(IStorageFile, IBuffer).
        ///</remarks>
        public static void WriteBuffer(IStorageFile file, IBuffer buffer)
        {
            WriteBytes(file, ((ByteBuffer)buffer).Data);
        }

        /// <summary>
        /// Writes an array of bytes of data to the specified file.
        /// </summary>
        /// <param name="file">The file that the byte is written to.</param>
        /// <param name="buffer">The array of bytes to write.</param>
        ///<remarks>
        /// This method is exclusive of nanoFramework and it's not available in the UWP API.
        /// The equivalent method would be WriteBytesAsync(IStorageFile, Byte[]).
        ///</remarks>
        [System.Diagnostics.DebuggerStepThrough]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern static void WriteBytes(IStorageFile file, Byte[] buffer);

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

        #region Native calls

        [System.Diagnostics.DebuggerStepThrough]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern static void ReadBufferNative(IStorageFile file, ref byte[] buffer);
        [System.Diagnostics.DebuggerStepThrough]

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern static void ReadTextNative(IStorageFile file, ref string text);
        #endregion

    }
}
