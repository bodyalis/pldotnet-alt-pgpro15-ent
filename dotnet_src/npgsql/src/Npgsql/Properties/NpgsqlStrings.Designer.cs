﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Npgsql.Properties {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class NpgsqlStrings {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NpgsqlStrings() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Npgsql.Properties.NpgsqlStrings", typeof(NpgsqlStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string CannotUseSslVerifyWithUserCallback {
            get {
                return ResourceManager.GetString("CannotUseSslVerifyWithUserCallback", resourceCulture);
            }
        }
        
        internal static string CannotUseSslRootCertificateWithUserCallback {
            get {
                return ResourceManager.GetString("CannotUseSslRootCertificateWithUserCallback", resourceCulture);
            }
        }
        
        internal static string CannotUseSslModeRequireWithoutTrustServerCertificate {
            get {
                return ResourceManager.GetString("CannotUseSslModeRequireWithoutTrustServerCertificate", resourceCulture);
            }
        }
        
        internal static string CannotUseTrustServerCertificate {
            get {
                return ResourceManager.GetString("CannotUseTrustServerCertificate", resourceCulture);
            }
        }
        
        internal static string NoMultirangeTypeFound {
            get {
                return ResourceManager.GetString("NoMultirangeTypeFound", resourceCulture);
            }
        }
        
        internal static string NotSupportedOnDataSourceCommand {
            get {
                return ResourceManager.GetString("NotSupportedOnDataSourceCommand", resourceCulture);
            }
        }
        
        internal static string NotSupportedOnDataSourceBatch {
            get {
                return ResourceManager.GetString("NotSupportedOnDataSourceBatch", resourceCulture);
            }
        }
        
        internal static string CannotSetBothPasswordProviderAndPassword {
            get {
                return ResourceManager.GetString("CannotSetBothPasswordProviderAndPassword", resourceCulture);
            }
        }
        
        internal static string PasswordProviderMissing {
            get {
                return ResourceManager.GetString("PasswordProviderMissing", resourceCulture);
            }
        }
        
        internal static string ArgumentMustBePositive {
            get {
                return ResourceManager.GetString("ArgumentMustBePositive", resourceCulture);
            }
        }
        
        internal static string CannotSpecifyTargetSessionAttributes {
            get {
                return ResourceManager.GetString("CannotSpecifyTargetSessionAttributes", resourceCulture);
            }
        }
        
        internal static string CannotReadIntervalWithMonthsAsTimeSpan {
            get {
                return ResourceManager.GetString("CannotReadIntervalWithMonthsAsTimeSpan", resourceCulture);
            }
        }
        
        internal static string PositionalParameterAfterNamed {
            get {
                return ResourceManager.GetString("PositionalParameterAfterNamed", resourceCulture);
            }
        }
        
        internal static string CannotReadInfinityValue {
            get {
                return ResourceManager.GetString("CannotReadInfinityValue", resourceCulture);
            }
        }
        
        internal static string SyncAndAsyncConnectionInitializersRequired {
            get {
                return ResourceManager.GetString("SyncAndAsyncConnectionInitializersRequired", resourceCulture);
            }
        }
    }
}
