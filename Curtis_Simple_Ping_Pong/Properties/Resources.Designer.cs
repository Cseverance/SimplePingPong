﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Curtis_Simple_Ping_Pong.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Curtis_Simple_Ping_Pong.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Implemented in the future.
        /// </summary>
        internal static string Error_Not_Implemented {
            get {
                return ResourceManager.GetString("Error_Not_Implemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A name for player one must be entered..
        /// </summary>
        internal static string Error_Player1_Must_Be_Entered {
            get {
                return ResourceManager.GetString("Error_Player1_Must_Be_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A name for player two must be entered..
        /// </summary>
        internal static string Error_Player2_Must_Be_Entered {
            get {
                return ResourceManager.GetString("Error_Player2_Must_Be_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has won the game! Rematch?.
        /// </summary>
        internal static string Msg_Winner {
            get {
                return ResourceManager.GetString("Msg_Winner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ServiceIcon {
            get {
                object obj = ResourceManager.GetObject("ServiceIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
