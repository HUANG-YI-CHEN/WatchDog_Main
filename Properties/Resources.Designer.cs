﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatchDog_Main.Properties {
    using System;
    
    
    /// <summary>
    ///   用於查詢當地語系化字串等的強類型資源類別。
    /// </summary>
    // 這個類別是自動產生的，是利用 StronglyTypedResourceBuilder
    // 類別透過 ResGen 或 Visual Studio 這類工具。
    // 若要加入或移除成員，請編輯您的 .ResX 檔，然後重新執行 ResGen
    // (利用 /str 選項)，或重建您的 VS 專案。
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
        ///   傳回這個類別使用的快取的 ResourceManager 執行個體。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WatchDog_Main.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   覆寫目前執行緒的 CurrentUICulture 屬性，對象是所有
        ///   使用這個強類型資源類別的資源查閱。
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
        ///   查詢類似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;!--Timer:單位秒--&gt;
        ///&lt;PS&gt;
        ///  &lt;MainProcess&gt;
        ///    &lt;ProcessItem&gt;
        ///      &lt;Name&gt;WatchDog_Sub&lt;/Name&gt;
        ///      &lt;Path&gt;&lt;/Path&gt;
        ///      &lt;Timer&gt;0.5&lt;/Timer&gt;
        ///    &lt;/ProcessItem&gt;
        ///    &lt;ProcessItem&gt;
        ///      &lt;Name&gt;AA&lt;/Name&gt;
        ///      &lt;Path&gt;&lt;/Path&gt;
        ///      &lt;Timer&gt;5&lt;/Timer&gt;
        ///    &lt;/ProcessItem&gt;
        ///  &lt;/MainProcess&gt;
        ///  &lt;SubProcess&gt;
        ///    &lt;ProcessItem&gt;
        ///      &lt;Name&gt;WatchDog_Main&lt;/Name&gt;
        ///      &lt;Path&gt;&lt;/Path&gt;
        ///      &lt;Timer&gt;0.5&lt;/Timer&gt;     
        ///    &lt;/ProcessItem&gt;
        ///  &lt;/SubProcess&gt;
        ///&lt;/PS&gt;
        ///
        /// 的當地語系化字串。
        /// </summary>
        internal static string AppSettings {
            get {
                return ResourceManager.GetString("AppSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap watchdog_001_16x16 {
            get {
                object obj = ResourceManager.GetObject("watchdog_001_16x16", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類似 (圖示) 的類型 System.Drawing.Icon 當地語系化資源。
        /// </summary>
        internal static System.Drawing.Icon watchdog_001_16x161 {
            get {
                object obj = ResourceManager.GetObject("watchdog_001_16x161", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類似 (圖示) 的類型 System.Drawing.Icon 當地語系化資源。
        /// </summary>
        internal static System.Drawing.Icon watchdog_16x16 {
            get {
                object obj = ResourceManager.GetObject("watchdog_16x16", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap watchdog_16x161 {
            get {
                object obj = ResourceManager.GetObject("watchdog_16x161", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}