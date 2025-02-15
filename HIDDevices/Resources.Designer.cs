﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevDecoder.HIDDevices {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DevDecoder.HIDDevices.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; type does not contain a constructor with the correct parameter types..
        /// </summary>
        internal static string ControllerInvalidConstructor {
            get {
                return ResourceManager.GetString("ControllerInvalidConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The supplied converter must implement IControlConverter&lt;&gt;.
        /// </summary>
        internal static string ControllerInvalidConverter {
            get {
                return ResourceManager.GetString("ControllerInvalidConverter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} is expecting a value of type &apos;{1}&apos; but has a value of type &apos;{2}&apos;..
        /// </summary>
        internal static string ControllerInvalidPropertyType {
            get {
                return ResourceManager.GetString("ControllerInvalidPropertyType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; device type must be assignable to the &apos;{1}&apos; type..
        /// </summary>
        internal static string ControllerInvalidType {
            get {
                return ResourceManager.GetString("ControllerInvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} is expecting a value of type &apos;{1}&apos; but there is no default converter registered for that type, nor explicit converter supplied..
        /// </summary>
        internal static string ControllerMissingConverter {
            get {
                return ResourceManager.GetString("ControllerMissingConverter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vendor: {0}; Product ID: {1}; Release: {2}.
        /// </summary>
        internal static string DefaultControllerName {
            get {
                return ResourceManager.GetString("DefaultControllerName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} device was found..
        /// </summary>
        internal static string DeviceAdd {
            get {
                return ResourceManager.GetString("DeviceAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when a new Device is found and successfully added..
        /// </summary>
        internal static string DeviceAddDescription {
            get {
                return ResourceManager.GetString("DeviceAddDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to {0} Device..
        /// </summary>
        internal static string DeviceConnected {
            get {
                return ResourceManager.GetString("DeviceConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when a connection is established with a device..
        /// </summary>
        internal static string DeviceConnectedDescription {
            get {
                return ResourceManager.GetString("DeviceConnectedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection to the {0} was closed..
        /// </summary>
        internal static string DeviceConnectionClosed {
            get {
                return ResourceManager.GetString("DeviceConnectionClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when a connection is closed to a device..
        /// </summary>
        internal static string DeviceConnectionClosedDescription {
            get {
                return ResourceManager.GetString("DeviceConnectionClosedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to open a connection to the {0} Device..
        /// </summary>
        internal static string DeviceConnectionFailed {
            get {
                return ResourceManager.GetString("DeviceConnectionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when an attempt to open a connection to a Device fails..
        /// </summary>
        internal static string DeviceConnectionFailedDescription {
            get {
                return ResourceManager.GetString("DeviceConnectionFailedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not create the {0} device!.
        /// </summary>
        internal static string DeviceCreationFailure {
            get {
                return ResourceManager.GetString("DeviceCreationFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when an exception is thrown whilst trying to create a Device class, usually this is an access violation..
        /// </summary>
        internal static string DeviceCreationFailureDescription {
            get {
                return ResourceManager.GetString("DeviceCreationFailureDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred whilst listening to the {0} device..
        /// </summary>
        internal static string DeviceError {
            get {
                return ResourceManager.GetString("DeviceError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when an error occurs whilst listening to a device..
        /// </summary>
        internal static string DeviceErrorDescription {
            get {
                return ResourceManager.GetString("DeviceErrorDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} device was removed..
        /// </summary>
        internal static string DeviceRemove {
            get {
                return ResourceManager.GetString("DeviceRemove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when a Device is unplugged..
        /// </summary>
        internal static string DeviceRemoveDescription {
            get {
                return ResourceManager.GetString("DeviceRemoveDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} device was updated..
        /// </summary>
        internal static string DeviceUpdate {
            get {
                return ResourceManager.GetString("DeviceUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when a Device&apos;s definition is changed..
        /// </summary>
        internal static string DeviceUpdateDescription {
            get {
                return ResourceManager.GetString("DeviceUpdateDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HID devices failed to update!.
        /// </summary>
        internal static string RefreshFailure {
            get {
                return ResourceManager.GetString("RefreshFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logged when an exception is thrown whilst trying to load the Devices collection on a change being detected to the list of HID Devices..
        /// </summary>
        internal static string RefreshFailureDescription {
            get {
                return ResourceManager.GetString("RefreshFailureDescription", resourceCulture);
            }
        }
    }
}
