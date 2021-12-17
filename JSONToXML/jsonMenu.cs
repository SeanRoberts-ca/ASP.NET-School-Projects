using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

//Install-Package Newtonsoft.Json -Version 13.0.1
//JSONToXML.csproj...
//< Project Sdk = "Microsoft.NET.Sdk" >
//< PropertyGroup >
//< OutputType > Exe </ OutputType >
//< TargetFramework > net5.0 </ TargetFramework >
//</ PropertyGroup >
//< ItemGroup >
//< PackageReference Include = "Newtonsoft.Json" Version = "13.0.1" />
//</ ItemGroup >
//</ Project >

//Note: Couldn't figure out how to return the xml in: Encoding.UTF8

namespace JSONToXML
{
    class jsonMenu
    {
        static void Main(string[] args)
        {
            //Windows...
            string path = @"c:\temp\svgViewer.json";

            string jsonText = File.ReadAllText(path, Encoding.UTF8);

            XmlDocument doc = (XmlDocument)Newtonsoft.Json.JsonConvert.DeserializeXmlNode(jsonText, "XmlResult");

            doc.Save(Console.Out);

        }

        //
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]

        public partial class menu
        {

            private object[] itemsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("header", typeof(string))]
            [System.Xml.Serialization.XmlElementAttribute("item", typeof(menuItem))]
            [System.Xml.Serialization.XmlElementAttribute("separator", typeof(object))]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class menuItem
        {

            private string actionField;

            private string idField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string action
            {
                get
                {
                    return this.actionField;
                }
                set
                {
                    this.actionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

//------------------------------------------------------------------
    }
}
