//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Globalization;
using System.Reflection;

namespace Octopus.Web.XmlTransform.Test.Properties {
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
        
        private static CultureInfo resourceCulture;
        
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Octopus.Web.XmlTransform.Test.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        internal static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;configuration&gt;
        ///  &lt;connectionStrings&gt;
        ///    &lt;!-- Attributes on this element should be separated by single spaces --&gt;
        ///    &lt;add name=&quot;AddingScenario1&quot; connectionString=&quot;Just ask Joe, he&apos;ll do it&quot; providerName=&quot;Joe&quot;/&gt;
        ///    &lt;!-- Attributes on this element should be separated by spaces, with providerName wrapped using a generated tab --&gt;
        ///    &lt;add name=&quot;AddingScenario2&quot; connectionString=&quot;Just ask Joe, he&apos;ll do it&quot;
        ///      providerName=&quot;Joe, the great provider of data who will provide your  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AttributeFormating_destination {
            get {
                return ResourceManager.GetString("AttributeFormating_destination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;configuration&gt;
        ///  &lt;connectionStrings&gt;
        ///    &lt;!-- Attributes on this element should be separated by single spaces --&gt;
        ///    &lt;add  name=&quot;AddingScenario1&quot;   connectionString=&quot;Data Source=JODAVIS-DEV1;Initial Catalog=Northwind;Integrated Security=True&quot;    providerName=&quot;System.Data.SqlClient&quot; /&gt;
        ///    &lt;!-- Attributes on this element should be separated by spaces, with providerName wrapped using a generated tab --&gt;
        ///    &lt;add  name=&quot;AddingScenario2&quot;   connectionString=&quot;Data Source=JODAVIS-DEV1 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AttributeFormating_source {
            get {
                return ResourceManager.GetString("AttributeFormating_source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;configuration xmlns:xct=&quot;http://schemas.microsoft.com/XML-Document-Transform&quot;&gt;
        ///  &lt;connectionStrings&gt;
        ///    &lt;!-- ADDING ATTRIBUTE SCENARIOS --&gt;
        ///    &lt;!-- 1. All attributes added, no newlines required --&gt;
        ///    &lt;add name=&quot;AddingScenario1&quot; connectionString=&quot;Just ask Joe, he&apos;ll do it&quot; providerName=&quot;Joe&quot; xct:Transform=&quot;Replace&quot; xct:Locator=&quot;Match(name)&quot;/&gt;
        ///    &lt;!-- 2. All attributes added, No newlines from siblings --&gt;
        ///    &lt;add name=&quot;AddingScenario2&quot; connectionString=&quot;Just ask Joe, he&apos;ll  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AttributeFormating_transform {
            get {
                return ResourceManager.GetString("AttributeFormating_transform", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing Replace (transform line 6, 97)
        ///  on /configuration/connectionStrings/add[@name=&apos;AddingScenario1&apos;]
        ///  Applying to &apos;add&apos; element (source line 5, 6)
        ///  Replaced &apos;add&apos; element
        ///Done executing Replace
        ///Executing Replace (transform line 8, 165)
        ///  on /configuration/connectionStrings/add[@name=&apos;AddingScenario2&apos;]
        ///  Applying to &apos;add&apos; element (source line 7, 6)
        ///  Replaced &apos;add&apos; element
        ///Done executing Replace
        ///Executing Replace (transform line 10, 165)
        ///  on /configuration/connectionStrings/add[@name=&apos;Ad [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AttributeFormatting_log {
            get {
                return ResourceManager.GetString("AttributeFormatting_log", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;html&gt;
        ///    &lt;head&gt;
        ///        &lt;title&gt;TITLEHEADINGHERE&lt;/title&gt;
        ///        &lt;meta http-equiv=&quot;Content-Type&amp;gt;&quot; content=&quot;text/html; charset=utf-8&quot; /&gt;
        ///    &lt;/head&gt;
        ///    &lt;body&gt;
        ///        &lt;p&gt;my para&lt;/p&gt;
        ///    &lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string EdgeCase_destination {
            get {
                return ResourceManager.GetString("EdgeCase_destination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing Replace (transform line 4, 16)
        ///  on /html/head/title
        ///  Applying to &apos;title&apos; element (source line 4, 10)
        ///  Replaced &apos;title&apos; element
        ///Done executing Replace.
        /// </summary>
        internal static string EdgeCase_log {
            get {
                return ResourceManager.GetString("EdgeCase_log", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;html&gt;
        ///    &lt;head&gt;
        ///        &lt;title&gt;STREAM Interactive - UAT&lt;/title&gt;
        ///        &lt;meta http-equiv=&quot;Content-Type&gt;&quot; content=&quot;text/html; charset=utf-8&quot; /&gt;
        ///    &lt;/head&gt;
        ///    &lt;body&gt;
        ///        &lt;p&gt;my para&lt;/p&gt;
        ///    &lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string EdgeCase_source {
            get {
                return ResourceManager.GetString("EdgeCase_source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;html xmlns:xdt=&quot;http://schemas.microsoft.com/XML-Document-Transform&quot;&gt;
        ///    &lt;head&gt;
        ///        &lt;title xdt:Transform=&quot;Replace&quot;&gt;TITLEHEADINGHERE&lt;/title&gt;
        ///    &lt;/head&gt;
        ///&lt;/html&gt;
        ///.
        /// </summary>
        internal static string EdgeCase_transform {
            get {
                return ResourceManager.GetString("EdgeCase_transform", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;configuration&gt;
        ///  &lt;!-- LookAheadTarget and LookAheadInserted should line up with LookAheadIndent --&gt;
        ///  &lt;appSettings&gt;
        ///    &lt;add key=&quot;LookAheadInserted&quot; value=&quot;This tag was added&quot;/&gt;
        ///    &lt;add key=&quot;LookAheadTarget&quot; value=&quot;No indent established before this&quot;/&gt;   &lt;!-- This should be on the same line as LookAheadTarget --&gt;
        ///    &lt;add key=&quot;LookAheadIndent&quot; value=&quot;We should use this tag&apos;s indent&quot; /&gt;
        ///    &lt;!-- There should be no blank line after this comment --&gt;
        ///      &lt;!-- This comment should [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TagFormatting_destination {
            get {
                return ResourceManager.GetString("TagFormatting_destination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing Remove (transform line 4, 30)
        ///  on /configuration/appSettings/add[@key=&apos;RemoveNewLine&apos;]
        ///  Applying to &apos;add&apos; element (source line 7, 6)
        ///  Removed &apos;add&apos; element
        ///Done executing Remove
        ///Executing Remove (transform line 5, 34)
        ///  on /configuration/appSettings/add[@key=&apos;RemoveExtraSpace1&apos;]
        ///  Applying to &apos;add&apos; element (source line 10, 6)
        ///  Removed &apos;add&apos; element
        ///Done executing Remove
        ///Executing InsertBefore (transform line 6, 58)
        ///  on /configuration/appSettings/add
        ///  Applying to &apos;appSettings&apos; ele [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TagFormatting_log {
            get {
                return ResourceManager.GetString("TagFormatting_log", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;configuration&gt;
        ///  &lt;!-- LookAheadTarget and LookAheadInserted should line up with LookAheadIndent --&gt;
        ///  &lt;appSettings&gt;&lt;add key=&quot;LookAheadTarget&quot; value=&quot;No indent established before this&quot;/&gt;   &lt;!-- This should be on the same line as LookAheadTarget --&gt;
        ///    &lt;add key=&quot;LookAheadIndent&quot; value=&quot;We should use this tag&apos;s indent&quot; /&gt;
        ///    &lt;!-- There should be no blank line after this comment --&gt;
        ///    &lt;add key=&quot;RemoveNewLine&quot; value=&quot;This tag will be removed&quot;/&gt;
        ///      &lt;!-- This comment should be  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TagFormatting_source {
            get {
                return ResourceManager.GetString("TagFormatting_source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;configuration xmlns:xct=&quot;http://schemas.microsoft.com/XML-Document-Transform&quot;&gt;
        ///  &lt;appSettings&gt;
        ///    &lt;add key=&quot;RemoveNewLine&quot; xct:Transform=&quot;Remove&quot; xct:Locator=&quot;Match(key)&quot;/&gt;
        ///    &lt;add key=&quot;RemoveExtraSpace1&quot; xct:Transform=&quot;Remove&quot; xct:Locator=&quot;Match(key)&quot;/&gt;
        ///    &lt;add key=&quot;InsertNewLine1&quot; value=&quot;This tag was added&quot; xct:Transform=&quot;InsertBefore(add[@key=&apos;InsertTarget1&apos;])&quot;/&gt;
        ///    &lt;add key=&quot;InsertNewLine2&quot; value=&quot;This tag was added&quot; xct:Transform=&quot;InsertAfter(add[@key=&apos;InsertTarget1&apos;])&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TagFormatting_transform {
            get {
                return ResourceManager.GetString("TagFormatting_transform", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to transform.config (43, 4) warning: Unknown tag &apos;xct:Foo&apos;
        ///transform.config (5, 10) error: Could not resolve &apos;Foo&apos; as a type of Transform
        ///transform.config (6, 10) error: &apos;Octopus.Web.XmlTransform.Match&apos; is not a type of Transform
        ///transform.config (9, 10) error: Could not resolve &apos;NoValidConstructor&apos; as a type of Transform
        ///transform.config (12, 20) error: Transform and Locator attributes must contain only a type name, or a type name followed by a list of attributes in parentheses.
        ///transform.config (13, 2 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string WarningsAndErrors_log {
            get {
                return ResourceManager.GetString("WarningsAndErrors_log", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;configuration&gt;
        ///  &lt;connectionStrings&gt;
        ///    &lt;add name=&quot;NorthwindConnectionString&quot; connectionString=&quot;Data Source=JODAVIS-DEV1;Initial Catalog=Northwind;Integrated Security=True&quot; providerName=&quot;System.Data.SqlClient&quot; /&gt;
        ///  &lt;/connectionStrings&gt;
        ///&lt;/configuration&gt;
        ///.
        /// </summary>
        internal static string WarningsAndErrors_source {
            get {
                return ResourceManager.GetString("WarningsAndErrors_source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;configuration xmlns:xct=&quot;http://schemas.microsoft.com/XML-Document-Transform&quot;&gt;
        ///  &lt;connectionStrings&gt;
        ///    &lt;!-- BadTypeName --&gt;
        ///    &lt;add xct:Transform=&quot;Foo&quot;/&gt;
        ///    &lt;add xct:Transform=&quot;Match&quot;/&gt;
        ///
        ///    &lt;!-- NoValidConstructor --&gt;
        ///    &lt;add xct:Transform=&quot;NoValidConstructor&quot;/&gt;
        ///
        ///    &lt;!-- BadArgumentValue --&gt;
        ///    &lt;add foo=&quot;foo&quot; xct:Transform=&quot;SetAttributes:foo&quot;/&gt;
        ///    &lt;add foo=&quot;foo&quot; xct:Transform=&quot;SetAttributes(foo&quot;/&gt;
        ///    &lt;add foo=&quot;foo&quot; xct:Transform=&quot;#SetAttributes#&quot;/&gt;
        ///
        ///    &lt;!-- I [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string WarningsAndErrors_transform {
            get {
                return ResourceManager.GetString("WarningsAndErrors_transform", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;configuration&gt;
        ///
        ///    &lt;appSettings /&gt;
        ///    &lt;connectionStrings /&gt;
        ///    &lt;system.web&gt;
        ///        &lt;compilation debug=&quot;true&quot;&gt;
        ///
        ///        &lt;/compilation&gt;
        ///        &lt;!--
        ///            The &lt;authentication&gt; section enables configuration 
        ///            of the security authentication mode used by 
        ///            ASP.NET to identify an incoming user. 
        ///        --&gt;
        ///        &lt;authentication mode=&quot;Windows&quot; /&gt;
        ///        &lt;!--
        ///            The &lt;customErrors&gt; section enables configuration 
        ///            of what  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Web {
            get {
                return ResourceManager.GetString("Web", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///
        ///&lt;!-- For more information on using web.config transformation visit http://go.microsoft.com/fwlink/?LinkId=125889 --&gt;
        ///
        ///&lt;configuration xmlns:xdt=&quot;http://schemas.microsoft.com/XML-Document-Transform&quot;&gt;
        ///  &lt;!--
        ///    In the example below, the &quot;SetAttributes&quot; transform will change the value of 
        ///    &quot;connectionString&quot; to use &quot;ReleaseSQLServer&quot; only when the &quot;Match&quot; locator 
        ///    finds an attribute &quot;name&quot; that has a value of &quot;MyDB&quot;.
        ///    
        ///    &lt;connectionStrings&gt;
        ///      &lt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Web_Release {
            get {
                return ResourceManager.GetString("Web_Release", resourceCulture);
            }
        }
    }
}
