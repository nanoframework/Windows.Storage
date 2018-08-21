//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;
using System.Collections.Generic;

namespace Windows.Storage
{
    /// <summary>
    /// Provides access to the settings in a settings container. The ApplicationDataContainer.Values property returns an object that can be cast to this type.
    /// </summary>
    public sealed class ApplicationDataContainerSettings : IEnumerable<KeyValuePair<String, Object>>, IDictionary<String, Object>, IObservableMap<String, Object>, IPropertySet
    {
    }
}
