using System;
using System.Collections.Generic;
using System.Text;

namespace PcColletion.InfraStructure.Attributes
{

    public class EditorTypeAttribute : Attribute
    {
        public string Name { get; set; }
        public string Param { get; set; }

        public EditorTypeAttribute(string Name, string Param = null)
        {
            this.Name = Name;
            this.Param = Param;
        }
    }
}
