// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Contact Details.</summary>
    [System.ComponentModel.TypeConverter(typeof(ContactDetailsTypeConverter))]
    public partial class ContactDetails
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ContactDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ContactDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).ContactName = (string) content.GetValueForProperty("ContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).ContactName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).Phone = (string) content.GetValueForProperty("Phone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).Phone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).PhoneExtension = (string) content.GetValueForProperty("PhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).PhoneExtension, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).Mobile = (string) content.GetValueForProperty("Mobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).Mobile, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).EmailList = (string[]) content.GetValueForProperty("EmailList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).EmailList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).NotificationPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.INotificationPreference[]) content.GetValueForProperty("NotificationPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).NotificationPreference, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.INotificationPreference>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.NotificationPreferenceTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ContactDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ContactDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).ContactName = (string) content.GetValueForProperty("ContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).ContactName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).Phone = (string) content.GetValueForProperty("Phone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).Phone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).PhoneExtension = (string) content.GetValueForProperty("PhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).PhoneExtension, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).Mobile = (string) content.GetValueForProperty("Mobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).Mobile, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).EmailList = (string[]) content.GetValueForProperty("EmailList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).EmailList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).NotificationPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.INotificationPreference[]) content.GetValueForProperty("NotificationPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetailsInternal)this).NotificationPreference, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.INotificationPreference>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.NotificationPreferenceTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ContactDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ContactDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ContactDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ContactDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ContactDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Contact Details.
    [System.ComponentModel.TypeConverter(typeof(ContactDetailsTypeConverter))]
    public partial interface IContactDetails

    {

    }
}