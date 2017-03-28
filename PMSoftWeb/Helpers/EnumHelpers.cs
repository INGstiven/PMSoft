using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PMSoftWeb.Helpers
{
   public static class EnumHelpers
   {
      public static IEnumerable<SelectListItem> GetItems(
         this Type enumtype, int? selectedValue)
      {
         if (!typeof(Enum).IsAssignableFrom(enumtype))
         {
            throw new ArgumentException("El tipo debe ser enumeración");
         }

         var names = Enum.GetNames(enumtype);
         var values = Enum.GetValues(enumtype).Cast<int>();

         var items = names.Zip(values, (name, value) =>
               new SelectListItem {
                  Text = GetName(enumtype, name),
                  Value = value.ToString(),
                  Selected = (value == selectedValue)});
         return items;
      }

      public static string GetName(Type enumType, string name)
      {
         var result = name;
         var attribute = enumType.GetField(name).GetCustomAttributes(inherit: false).OfType<DisplayAttribute>().FirstOrDefault();
         if (attribute != null)
         {
            result = attribute.GetName();
         }
         return result;
      }
   }
}
