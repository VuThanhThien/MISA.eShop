﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MISA.eSHOP.Common.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MISA.eSHOP.Common.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Không tìm thấy đối tượng yêu cầu.
        /// </summary>
        internal static string CannotFound {
            get {
                return ResourceManager.GetString("CannotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Không lấy được danh sách.
        /// </summary>
        internal static string CanNotGet {
            get {
                return ResourceManager.GetString("CanNotGet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Có lỗi xảy ra, vui lòng liên hệ MISA.
        /// </summary>
        internal static string DefaultDevMsg {
            get {
                return ResourceManager.GetString("DefaultDevMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cửa hàng đã tồn tại, vui lòng kiểm tra mã cửa hàng.
        /// </summary>
        internal static string DupplicatedRestaurant {
            get {
                return ResourceManager.GetString("DupplicatedRestaurant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vui lòng nhập địa chỉ.
        /// </summary>
        internal static string RestaurantAddressRequired {
            get {
                return ResourceManager.GetString("RestaurantAddressRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vui lòng nhập mã cửa hàng.
        /// </summary>
        internal static string RestaurantCodeRequired {
            get {
                return ResourceManager.GetString("RestaurantCodeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vui lòng nhập tên cửa hàng.
        /// </summary>
        internal static string RestaurantNameRequired {
            get {
                return ResourceManager.GetString("RestaurantNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validate dữ liệu thất bại, kiểm tra dữ liệu nhập vào.
        /// </summary>
        internal static string ValidateFail {
            get {
                return ResourceManager.GetString("ValidateFail", resourceCulture);
            }
        }
    }
}
