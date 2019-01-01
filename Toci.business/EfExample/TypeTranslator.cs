using System.Collections.Generic;

namespace Toci.business.EfExample
{
    public class TypeTranslator
    {
        Dictionary<string, string> TypeMapping = new Dictionary<string, string>()
        {
            { "integer", "int"},
            { "text", "string"},
        };

        public virtual string GetCSharpTypeForDbType(string type)
        {
            if (TypeMapping.ContainsKey(type))
            {
                return TypeMapping[type];
            }

            return "object";
        }
    }
}