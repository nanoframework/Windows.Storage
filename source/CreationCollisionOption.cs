//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace Windows.Storage
{
    /// <summary>
    /// Specifies what to do if a file or folder with the specified name already exists in the current folder when you create a new file or folder.
    /// </summary>
    public enum CreationCollisionOption
    {
        /// <summary>
        /// Raise an exception of type System.Exception if the file or folder already exists.
        /// Methods that don't explicitly pass a value from the CreationCollisionOption enumeration use the FailIfExists value as the default when you try to create, rename, copy, or move a file or folder.
        /// </summary>
        FailIfExists = 2,
        /// <summary>
        /// Automatically append a number to the base of the specified name if the file or folder already exists.
        /// For example, if MyFile.txt already exists, then the new file is named MyFile(2).txt.If MyFolder already exists, then the new folder is named MyFolder(2).
        /// </summary>
        GenerateUniqueName = 0,
        /// <summary>
        /// Return the existing item if the file or folder already exists.
        /// </summary>
        OpenIfExists = 3,
        /// <summary>
        /// Replace the existing item if the file or folder already exists.
        /// </summary>
        ReplaceExisting = 1
    }
}
