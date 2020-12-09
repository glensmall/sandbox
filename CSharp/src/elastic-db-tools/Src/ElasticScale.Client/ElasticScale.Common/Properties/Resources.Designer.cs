﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.TransientFaultHandling.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager(typeof(Resources));
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
        ///   Looks up a localized string similar to The specified argument {0} cannot be greater than its ceiling value of {1}..
        /// </summary>
        internal static string ArgumentCannotBeGreaterThanBaseline {
            get {
                return ResourceManager.GetString("ArgumentCannotBeGreaterThanBaseline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified argument {0} cannot be initialized with a negative value..
        /// </summary>
        internal static string ArgumentCannotBeNegative {
            get {
                return ResourceManager.GetString("ArgumentCannotBeNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default retry strategy for technology {0}, named &apos;{1}&apos;, is not defined..
        /// </summary>
        internal static string DefaultRetryStrategyMappingNotFound {
            get {
                return ResourceManager.GetString("DefaultRetryStrategyMappingNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default retry strategy for technology {0} was not not defined, and there is no overall default strategy..
        /// </summary>
        internal static string DefaultRetryStrategyNotFound {
            get {
                return ResourceManager.GetString("DefaultRetryStrategyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The RetryManager is already set..
        /// </summary>
        internal static string ExceptionRetryManagerAlreadySet {
            get {
                return ResourceManager.GetString("ExceptionRetryManagerAlreadySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default RetryManager has not been set. Set it by invoking the RetryManager.SetDefault static method, or if you are using declarative configuration, you can invoke the RetryPolicyFactory.CreateDefault() method to automatically create the retry manager from the configuration file..
        /// </summary>
        internal static string ExceptionRetryManagerNotSet {
            get {
                return ResourceManager.GetString("ExceptionRetryManagerNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The action has exceeded its defined retry limit..
        /// </summary>
        internal static string RetryLimitExceeded {
            get {
                return ResourceManager.GetString("RetryLimitExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The retry strategy with name &apos;{0}&apos; cannot be found..
        /// </summary>
        internal static string RetryStrategyNotFound {
            get {
                return ResourceManager.GetString("RetryStrategyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified string argument {0} must not be empty..
        /// </summary>
        internal static string StringCannotBeEmpty {
            get {
                return ResourceManager.GetString("StringCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified argument &apos;{0}&apos; cannot return a null task when invoked..
        /// </summary>
        internal static string TaskCannotBeNull {
            get {
                return ResourceManager.GetString("TaskCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified argument &apos;{0}&apos; must return a scheduled task (also known as &quot;hot&quot; task) when invoked..
        /// </summary>
        internal static string TaskMustBeScheduled {
            get {
                return ResourceManager.GetString("TaskMustBeScheduled", resourceCulture);
            }
        }
    }
}
