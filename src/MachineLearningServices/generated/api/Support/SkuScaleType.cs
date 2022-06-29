// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support
{

    /// <summary>Node scaling setting for the compute sku.</summary>
    public partial struct SkuScaleType :
        System.IEquatable<SkuScaleType>
    {
        /// <summary>Automatically scales node count.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SkuScaleType Automatic = @"Automatic";

        /// <summary>Node count scaled upon user request.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SkuScaleType Manual = @"Manual";

        /// <summary>Fixed set of nodes.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SkuScaleType None = @"None";

        /// <summary>the value for an instance of the <see cref="SkuScaleType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SkuScaleType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SkuScaleType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SkuScaleType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SkuScaleType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SkuScaleType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type SkuScaleType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SkuScaleType && Equals((SkuScaleType)obj);
        }

        /// <summary>Returns hashCode for enum SkuScaleType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="SkuScaleType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SkuScaleType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SkuScaleType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SkuScaleType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SkuScaleType" />.</param>

        public static implicit operator SkuScaleType(string value)
        {
            return new SkuScaleType(value);
        }

        /// <summary>Implicit operator to convert SkuScaleType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SkuScaleType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SkuScaleType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SkuScaleType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SkuScaleType e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SkuScaleType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SkuScaleType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SkuScaleType e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SkuScaleType e2)
        {
            return e2.Equals(e1);
        }
    }
}