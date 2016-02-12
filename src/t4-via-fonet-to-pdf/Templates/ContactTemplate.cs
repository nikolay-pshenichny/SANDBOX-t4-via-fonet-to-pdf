﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace t4_via_fonet_to_pdf.Templates
{
    using System.Linq;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class ContactTemplate : ContactTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<fo:root xmlns:fo=""http://www.w3.org/1999/XSL/Format"">

  <fo:layout-master-set>
    <fo:simple-page-master master-name=""simple""
                  page-height=""29.7cm""
                  page-width=""21cm""
                  margin-top=""1cm""
                  margin-bottom=""2cm""
                  margin-left=""2.5cm""
                  margin-right=""2.5cm"">
      <fo:region-body margin-top=""3cm""/>
      <fo:region-before extent=""3cm""/>
      <fo:region-after extent=""1.5cm""/>
    </fo:simple-page-master>
  </fo:layout-master-set>

  <fo:page-sequence master-reference=""simple"">
    <fo:flow flow-name=""xsl-region-body"" font-size=""18pt"" color=""black"" font-family=""Helvetica"">
      
      <fo:table table-layout=""fixed"" width=""100%"">
        <fo:table-column column-width=""proportional-column-width(1)""/>
        <fo:table-column column-width=""proportional-column-width(1)""/>
        <fo:table-body>
          <!-- Name -->
          <fo:table-row>
            <fo:table-cell column-number=""1"">
              <fo:block font-weight=""bold"">Name:</fo:block>
            </fo:table-cell>
            <fo:table-cell column-number=""2"">
              <fo:block>
                ");
            
            #line 35 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Data.FirstName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 35 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Data.LastName));
            
            #line default
            #line hidden
            this.Write(@"
              </fo:block>
            </fo:table-cell>
          </fo:table-row>

          <!-- Birthdate -->
          <fo:table-row>
            <fo:table-cell column-number=""1"">
              <fo:block font-weight=""bold"">Birth date:</fo:block>
            </fo:table-cell>
            <fo:table-cell column-number=""2"">
              <fo:block>
                ");
            
            #line 47 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Data.Birthdate));
            
            #line default
            #line hidden
            this.Write("\r\n              </fo:block>\r\n            </fo:table-cell>\r\n          </fo:table-r" +
                    "ow>\r\n\r\n          <!-- Phone numbers, if any -->\r\n\t\t  ");
            
            #line 53 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
 if ((this.Data.Phones != null) && (this.Data.Phones.Any()))
		  {
			  foreach (var phone in this.Data.Phones)
			  { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<fo:table-row>\r\n\t\t\t\t\t  <fo:table-cell column-number=\"1\">\r\n\t\t\t\t\t\t  <fo:block " +
                    "font-weight=\"bold\">");
            
            #line 59 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(phone.Type.ToString()  + " phone:"));
            
            #line default
            #line hidden
            this.Write("</fo:block>\r\n\t\t\t\t\t  </fo:table-cell>\r\n\t\t\t\t\t  <fo:table-cell column-number=\"2\">\r\n\t" +
                    "\t\t\t\t\t  <fo:block>\r\n\t\t\t\t\t\t\t");
            
            #line 63 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(phone.Number));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\t  </fo:block>\r\n\t\t\t\t\t  </fo:table-cell>\r\n\t\t\t\t\t</fo:table-row>\r\n\t\t\t  ");
            
            #line 67 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
 } 
		  } 
            
            #line default
            #line hidden
            this.Write("    \r\n          <!-- Email addresses, if any -->\r\n          ");
            
            #line 71 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
 if ((this.Data.Emails != null) && (this.Data.Emails.Any()))
          {
          foreach (var email in this.Data.Emails)
          { 
            
            #line default
            #line hidden
            this.Write("          <fo:table-row>\r\n            <fo:table-cell column-number=\"1\">\r\n        " +
                    "      <fo:block font-weight=\"bold\">\r\n                ");
            
            #line 78 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(email.Type.ToString()  + " email:"));
            
            #line default
            #line hidden
            this.Write("\r\n              </fo:block>\r\n            </fo:table-cell>\r\n            <fo:table-" +
                    "cell column-number=\"2\">\r\n              <fo:block>\r\n                ");
            
            #line 83 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(email.Address));
            
            #line default
            #line hidden
            this.Write("\r\n              </fo:block>\r\n            </fo:table-cell>\r\n          </fo:table-r" +
                    "ow>\r\n          ");
            
            #line 87 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"
 } 
		  } 
            
            #line default
            #line hidden
            this.Write("          \r\n        </fo:table-body>\r\n      </fo:table>      \r\n      \r\n    </fo:f" +
                    "low>\r\n  </fo:page-sequence>\r\n\r\n</fo:root>");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\src\t4-via-fonet-to-pdf\t4-via-fonet-to-pdf\Templates\ContactTemplate.tt"

private global::t4_via_fonet_to_pdf.Models.Card _DataField;

/// <summary>
/// Access the Data parameter of the template.
/// </summary>
private global::t4_via_fonet_to_pdf.Models.Card Data
{
    get
    {
        return this._DataField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool DataValueAcquired = false;
if (this.Session.ContainsKey("Data"))
{
    this._DataField = ((global::t4_via_fonet_to_pdf.Models.Card)(this.Session["Data"]));
    DataValueAcquired = true;
}
if ((DataValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Data");
    if ((data != null))
    {
        this._DataField = ((global::t4_via_fonet_to_pdf.Models.Card)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class ContactTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
