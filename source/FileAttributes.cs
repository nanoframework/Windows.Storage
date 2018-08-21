//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace Windows.Storage
{
    /// <summary>
    /// Describes the attributes of a file or folder.
    /// This enumeration has a System.FlagsAttribute attribute that allows a bitwise combination of its member values.
    /// </summary>
    public enum FileAttributes
    {
        /// <summary>
        /// The item is archived.
        /// </summary>
        Archive = 32,
        /// <summary>
        /// The item is a directory.
        /// </summary>
        Directory = 16,
        /// <summary>
        /// The item is locally incomplete. Windows only.
        /// </summary>
        LocallyIncomplete = 512,
        /// <summary>
        /// The item is normal. That is, the item doesn't have any of the other values in the enumeration.
        /// </summary>
        Normal = 0,
        /// <summary>
        /// The item is read-only.
        /// </summary>
        ReadOnly = 1,
        /// <summary>
        /// The item is a temporary file.
        /// </summary>
        Temporary = 256
    }
}
