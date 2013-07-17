﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.RecipeFramework.PackageManagement.Configuration {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.RecipeFramework.PackageManagement.Configuration.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to You must select the Package to explore..
        /// </summary>
        internal static string EnableDisablePackages_MustSelectPackage {
            get {
                return ResourceManager.GetString("EnableDisablePackages_MustSelectPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service {0} is required but was not found in container {1}..
        /// </summary>
        internal static string General_ServiceNotFound {
            get {
                return ResourceManager.GetString("General_ServiceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot load Package {0}.
        /// </summary>
        internal static string PackageManager_CannotLoadPackage {
            get {
                return ResourceManager.GetString("PackageManager_CannotLoadPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot load Package {0}. Do you want to continue?.
        /// </summary>
        internal static string PackageManager_CannotLoadPackageAsking {
            get {
                return ResourceManager.GetString("PackageManager_CannotLoadPackageAsking", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to delete the selected reference?.
        /// </summary>
        internal static string PackageManager_ConfirmDeleteReference {
            get {
                return ResourceManager.GetString("PackageManager_ConfirmDeleteReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Delete Selected Reference.
        /// </summary>
        internal static string PackageManager_DeleteRecipe {
            get {
                return ResourceManager.GetString("PackageManager_DeleteRecipe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Execute Selected Reference.
        /// </summary>
        internal static string PackageManager_ExecuteRecipe {
            get {
                return ResourceManager.GetString("PackageManager_ExecuteRecipe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid target for execution was not selected..
        /// </summary>
        internal static string PackageManager_HostDidntSelect {
            get {
                return ResourceManager.GetString("PackageManager_HostDidntSelect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must select the recipe to execute..
        /// </summary>
        internal static string PackageManager_MustSelectRecipe {
            get {
                return ResourceManager.GetString("PackageManager_MustSelectRecipe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recipe manager service couldn&apos;t be retrieved from the current service provider..
        /// </summary>
        internal static string PackageManager_NoRecipeManagerService {
            get {
                return ResourceManager.GetString("PackageManager_NoRecipeManagerService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown References.
        /// </summary>
        internal static string PackageManager_UnknownReferenceCategory {
            get {
                return ResourceManager.GetString("PackageManager_UnknownReferenceCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actions.
        /// </summary>
        internal static string PackageViewer_ActionsNode {
            get {
                return ResourceManager.GetString("PackageViewer_ActionsNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arguments.
        /// </summary>
        internal static string PackageViewer_ArgumentsNode {
            get {
                return ResourceManager.GetString("PackageViewer_ArgumentsNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} [Version {1}].
        /// </summary>
        internal static string PackageViewer_PackageNode {
            get {
                return ResourceManager.GetString("PackageViewer_PackageNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recipes.
        /// </summary>
        internal static string PackageViewer_RecipesNode {
            get {
                return ResourceManager.GetString("PackageViewer_RecipesNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AppliesTo threw an exception.
        /// </summary>
        internal static string Reference_AppliesToThrew {
            get {
                return ResourceManager.GetString("Reference_AppliesToThrew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The reference has not correctly implemented some attributes because one or some of them threw an exception. The failure ocurred in the attribute(s): {0}.
        /// </summary>
        internal static string Reference_InvalidAttributes {
            get {
                return ResourceManager.GetString("Reference_InvalidAttributes", resourceCulture);
            }
        }
    }
}