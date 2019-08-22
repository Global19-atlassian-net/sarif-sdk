﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.Sarif.Driver {
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
    internal class DriverResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DriverResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.Sarif.Driver.DriverResources", typeof(DriverResources).Assembly);
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
        ///   Looks up a localized string similar to Exactly one of the &apos;{0}&apos; and &apos;{1}&apos; options must be present..
        /// </summary>
        internal static string ExactlyOneOfTwoOptionsIsRequired {
            get {
                return ResourceManager.GetString("ExactlyOneOfTwoOptionsIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A binary was not analyzed as the it does not appear to be a valid portable executable..
        /// </summary>
        internal static string InvalidPE_Description {
            get {
                return ResourceManager.GetString("InvalidPE_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis completed successfully..
        /// </summary>
        internal static string MSG_AnalysisCompletedSuccessfully {
            get {
                return ResourceManager.GetString("MSG_AnalysisCompletedSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis finished but was not complete due to non-fatal runtime errors..
        /// </summary>
        internal static string MSG_AnalysisIncomplete {
            get {
                return ResourceManager.GetString("MSG_AnalysisIncomplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analyzing....
        /// </summary>
        internal static string MSG_Analyzing {
            get {
                return ResourceManager.GetString("MSG_Analyzing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis halted prematurely due to a fatal execution condition..
        /// </summary>
        internal static string MSG_UnexpectedApplicationExit {
            get {
                return ResourceManager.GetString("MSG_UnexpectedApplicationExit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No analyzer paths specified.
        /// </summary>
        internal static string NoAnalyzerPathsSpecified {
            get {
                return ResourceManager.GetString("NoAnalyzerPathsSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to access a DisposableEnumerable which is non-owning..
        /// </summary>
        internal static string NonOwningDisposableViewAccess {
            get {
                return ResourceManager.GetString("NonOwningDisposableViewAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid PREfast defect state..
        /// </summary>
        internal static string PREfastDefectBuilderCannotFreeze {
            get {
                return ResourceManager.GetString("PREfastDefectBuilderCannotFreeze", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PREfast defects require a main SFA where the defect occurs.
        /// </summary>
        internal static string PREfastDefectPrimaryLocationMissing {
            get {
                return ResourceManager.GetString("PREfastDefectPrimaryLocationMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Probability must be between 0.0 and 1.0, inclusive; or be unset..
        /// </summary>
        internal static string PREfastDefectProbabilityMustBeInRange {
            get {
                return ResourceManager.GetString("PREfastDefectProbabilityMustBeInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rank must be between 0 and 10, inclusive; or be unset..
        /// </summary>
        internal static string PREfastDefectRankMustBeInRange {
            get {
                return ResourceManager.GetString("PREfastDefectRankMustBeInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PREfast defects require descriptions with content..
        /// </summary>
        internal static string PREfastDefectsRequireConteintInDescription {
            get {
                return ResourceManager.GetString("PREfastDefectsRequireConteintInDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PREfast defects require content in their defect code..
        /// </summary>
        internal static string PREfastDefectsRequireContentInDefectCode {
            get {
                return ResourceManager.GetString("PREfastDefectsRequireContentInDefectCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The function line number must be strictly positive; files begin at line 1..
        /// </summary>
        internal static string PREfastFunctionReferenceLineMustBeInRange {
            get {
                return ResourceManager.GetString("PREfastFunctionReferenceLineMustBeInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KeyEvent ids must be strictly positive..
        /// </summary>
        internal static string PREfastKeyEventIdMustBeInRange {
            get {
                return ResourceManager.GetString("PREfastKeyEventIdMustBeInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SequenceNumber must be positive, or 0 to disable sequence numbering..
        /// </summary>
        internal static string PREfastSequenceNumberOutOfRange {
            get {
                return ResourceManager.GetString("PREfastSequenceNumberOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application exited unexpectedly..
        /// </summary>
        internal static string UnexpectedApplicationExit {
            get {
                return ResourceManager.GetString("UnexpectedApplicationExit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception was raised during analysis:
        ///{0}.
        /// </summary>
        internal static string UnhandledEngineException {
            get {
                return ResourceManager.GetString("UnhandledEngineException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The local element name was not set..
        /// </summary>
        internal static string XmlElementNameWasUnset {
            get {
                return ResourceManager.GetString("XmlElementNameWasUnset", resourceCulture);
            }
        }
    }
}
