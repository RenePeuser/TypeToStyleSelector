using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TypeToStyleSelector
{
    public class TypeStyleSelector : StyleSelector
    {
        public List<TypeToStyle> TypeToDataTemplates { get; set; } = new List<TypeToStyle>();


        public override Style SelectStyle(object item, DependencyObject container)
        {
            var type = item.GetType();
            var typeToDataTemplate = TypeToDataTemplates.FirstOrDefault(t => t.Type == type);
            return typeToDataTemplate?.Style;
        }
    }
}
