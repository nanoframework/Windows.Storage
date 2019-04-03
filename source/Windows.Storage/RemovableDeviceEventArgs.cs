﻿//
// Copyright (c) 2019 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using nanoFramework.Runtime.Events;

namespace Windows.Storage
{
    /// <summary>
    /// Contains argument values for Removable Devices events.
    /// </summary>
    public class RemovableDeviceEventArgs : EventArgs
    {
        private readonly string _path;
        private readonly RemovableDeviceEvent _event;

        internal RemovableDeviceEventArgs(string path, RemovableDeviceEvent deviceEvent)
        {
            _path = path;
            _event = deviceEvent;
        }

        /// <summary>
        /// The path of the Removable Device.
        /// </summary>
        public string Path
        {
            get
            {
                return _path;
            }
        }

        /// <summary>
        /// The <see cref="RemovableDeviceEvent"/> occurred.
        /// </summary>
        public RemovableDeviceEvent Event
        {
            get
            {
                return _event;
            }
        }

        /// <summary>
        /// Specifies the type of event occurred with the Removable Device specified.
        /// </summary>
        /// <remarks>
        /// This enum is specific to nanoFramework. There is no equivalent in the UWP API.
        /// </remarks>
        public enum RemovableDeviceEvent
        {
            /// <summary>
            /// A Removable Device has been inserted.
            /// </summary>
            Inserted,

            /// <summary>
            /// A Removable Device has been removed.
            /// </summary>
            Removed,
        }
    }
}
