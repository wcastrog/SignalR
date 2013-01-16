﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNet.SignalR.Client {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
#if NETFX_CORE
                    var assembly = typeof(Resources).GetTypeInfo().Assembly;
#else
                    var assembly = typeof(Resources).Assembly;
#endif
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNet.SignalR.Client.Resources", assembly);
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
        ///   Looks up a localized string similar to The connection was stopped before it could be started..
        /// </summary>
        internal static string Error_ConnectionCancelled {
            get {
                return ResourceManager.GetString("Error_ConnectionCancelled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection has not been established..
        /// </summary>
        internal static string Error_ConnectionHasNotBeenEstablished {
            get {
                return ResourceManager.GetString("Error_ConnectionHasNotBeenEstablished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incompatible protocol version..
        /// </summary>
        internal static string Error_IncompatibleProtocolVersion {
            get {
                return ResourceManager.GetString("Error_IncompatibleProtocolVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A HubProxy cannot be added after the connection has been started..
        /// </summary>
        internal static string Error_ProxiesCannotBeAddedConnectionStarted {
            get {
                return ResourceManager.GetString("Error_ProxiesCannotBeAddedConnectionStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server negotiation failed..
        /// </summary>
        internal static string Error_ServerNegotiationFailed {
            get {
                return ResourceManager.GetString("Error_ServerNegotiationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Start method must be called before data can be sent..
        /// </summary>
        internal static string Error_StartMustBeCalledBeforeDataCanBeSent {
            get {
                return ResourceManager.GetString("Error_StartMustBeCalledBeforeDataCanBeSent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Url cannot contain query string directly. Pass query string values in using available overload..
        /// </summary>
        internal static string Error_UrlCantContainQueryStringDirectly {
            get {
                return ResourceManager.GetString("Error_UrlCantContainQueryStringDirectly", resourceCulture);
            }
        }
    }
}
