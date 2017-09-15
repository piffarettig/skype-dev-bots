﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FridgeBot.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FridgeBot.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Thank you for the {0} Appreciate it :).
        /// </summary>
        internal static string ADDED {
            get {
                return ResourceManager.GetString("ADDED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to clear up the fridge? Say yes or no..
        /// </summary>
        internal static string CLEAR {
            get {
                return ResourceManager.GetString("CLEAR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Whew. I knew it! I will keep everything..
        /// </summary>
        internal static string CLEAR_NO {
            get {
                return ResourceManager.GetString("CLEAR_NO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I cleared up myself! I am hungry now because I am empty..
        /// </summary>
        internal static string CLEAR_YES {
            get {
                return ResourceManager.GetString("CLEAR_YES", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi, I am your fridge, Fridge Bot :)
        ///What can I do for you today? Say &apos;help&apos; for help..
        /// </summary>
        internal static string GREET {
            get {
                return ResourceManager.GetString("GREET", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I am your Fridge Bot, and I take care of your fridge inventory. You can put things in, take things out and see what is in the fridge. You can say &apos;put apple&apos; and I will add an apple, or &apos;remove apple&apos; and I will remove an apple. You can say &apos;show what you have&apos; and I will show you the inventory, or say &apos;clear all&apos; and I will clear out the fridge for you. Try it out now and say &apos;add an apple&apos; :). This sample bot does not support numerics..
        /// </summary>
        internal static string HELP {
            get {
                return ResourceManager.GetString("HELP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Did you forget to mention what you want to add? Try again..
        /// </summary>
        internal static string NO_ITEM_TO_ADD {
            get {
                return ResourceManager.GetString("NO_ITEM_TO_ADD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Did you forget to mention what you want to remove? Try again..
        /// </summary>
        internal static string NO_ITEM_TO_REMOVE {
            get {
                return ResourceManager.GetString("NO_ITEM_TO_REMOVE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, we do not support that action yet..
        /// </summary>
        internal static string NOT_YET_SUPPORTED {
            get {
                return ResourceManager.GetString("NOT_YET_SUPPORTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I don&apos;t have {0} in my stomach; are you sure you fed it to me?.
        /// </summary>
        internal static string REMOVED_ERR {
            get {
                return ResourceManager.GetString("REMOVED_ERR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Here&apos;s the {0}! It&apos;s no longer in my tummy..
        /// </summary>
        internal static string REMOVED_SUCC {
            get {
                return ResourceManager.GetString("REMOVED_SUCC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I have {0} in my stomach!.
        /// </summary>
        internal static string SHOW {
            get {
                return ResourceManager.GetString("SHOW", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to yes.
        /// </summary>
        internal static string YES {
            get {
                return ResourceManager.GetString("YES", resourceCulture);
            }
        }
    }
}
