﻿using System;
using System.Xml;

namespace UblSharp.UnqualifiedDataTypes
{
    public partial class DateType
    {
        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="DateType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator DateType(string value)
        {
            return string.IsNullOrEmpty(value) ? null : new DateType
            {
#if NETSTANDARD1_1
                Value = XmlConvert.ToDateTimeOffset(value).DateTime
#else
                Value = XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.RoundtripKind)
#endif
            };
        }
    }
}