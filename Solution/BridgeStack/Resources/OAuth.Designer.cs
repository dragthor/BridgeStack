﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BridgeStack.Resources {
    using System;
    
    
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
    internal class OAuth {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OAuth() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BridgeStack.Resources.OAuth", typeof(OAuth).Assembly);
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
        ///   Looks up a localized string similar to code.
        /// </summary>
        internal static string AccessCodeParameter {
            get {
                return ResourceManager.GetString("AccessCodeParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to client_id.
        /// </summary>
        internal static string AppIdParameter {
            get {
                return ResourceManager.GetString("AppIdParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to client_secret.
        /// </summary>
        internal static string AppSecretParameter {
            get {
                return ResourceManager.GetString("AppSecretParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://stackexchange.com/oauth/login_success.
        /// </summary>
        internal static string DefaultRedirectUri {
            get {
                return ResourceManager.GetString("DefaultRedirectUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://stackexchange.com/oauth.
        /// </summary>
        internal static string ExplicitUri {
            get {
                return ResourceManager.GetString("ExplicitUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://stackexchange.com/oauth/dialog.
        /// </summary>
        internal static string ImplicitUri {
            get {
                return ResourceManager.GetString("ImplicitUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to redirect_uri.
        /// </summary>
        internal static string RedirectUriParameter {
            get {
                return ResourceManager.GetString("RedirectUriParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://stackexchange.com/oauth/access_token.
        /// </summary>
        internal static string RequestAccessTokenEndpoint {
            get {
                return ResourceManager.GetString("RequestAccessTokenEndpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to no_expiry.
        /// </summary>
        internal static string ScopeNoExpiry {
            get {
                return ResourceManager.GetString("ScopeNoExpiry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to scope.
        /// </summary>
        internal static string ScopeParameter {
            get {
                return ResourceManager.GetString("ScopeParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to read_inbox.
        /// </summary>
        internal static string ScopeReadInbox {
            get {
                return ResourceManager.GetString("ScopeReadInbox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to state.
        /// </summary>
        internal static string StateParameter {
            get {
                return ResourceManager.GetString("StateParameter", resourceCulture);
            }
        }
    }
}