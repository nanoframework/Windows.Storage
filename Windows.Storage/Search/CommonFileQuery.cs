//
// Copyright (c) .NET Foundation and Contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

namespace Windows.Storage.Search
{
    /// <summary>
    /// Specifies how to sort the files in the query results and determines whether the query is shallow or deep. Query results for deep queries include all files in all of the subfolders of the current folder, sorted according to the specified option.
    /// </summary>
    public enum CommonFileQuery
    {
        /// <summary>
        /// A shallow list of files in the current folder, similar to the list that File Explorer provides.
        /// You can use this option for any storage location.
        /// </summary>
        DefaultQuery,

        /// <summary>
        /// A deep, flat list of files in a folder and its subfolders, sorted by System.ItemNameDisplay.
        /// You can use this option for any storage location.
        /// </summary>
        ///<remarks>
        /// This method is not available in nanoFramework.
        ///</remarks>
        OrderByName,

        /// <summary>
        /// A deep, flat list of files in a folder and its subfolders, sorted by System.Title.
        /// You can use this option only for folders in a library or the HomeGroup folder.
        /// </summary>
        ///<remarks>
        /// This method is not available in nanoFramework.
        ///</remarks>
        OrderByTitle,

        /// <summary>
        /// A deep, flat list of files in a folder and its subfolders, sorted by music properties.
        /// You can use this option only for folders in a library or the HomeGroup folder.
        /// </summary>
        ///<remarks>
        /// This method is not available in nanoFramework.
        ///</remarks>
        OrderByMusicProperties,

        /// <summary>
        /// A deep, flat list of files in a folder and its subfolders, sorted by System.Search.Rank followed by System.DateModified.
        /// You can use this option for any storage location.
        /// </summary>
        ///<remarks>
        /// This method is not available in nanoFramework.
        ///</remarks>
        OrderBySearchRank,

        /// <summary>
        /// A deep, flat list of files in a folder and its subfolders, sorted by System.ItemDate.
        /// You can use this option only for folders in a library or the HomeGroup folder.
        /// </summary>
        ///<remarks>
        /// This method is not available in nanoFramework.
        ///</remarks>
        OrderByDate
    }
}
