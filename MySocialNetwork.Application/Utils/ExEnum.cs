using System.ComponentModel;

namespace MySocialNetwork.Application.Utils
{
    public static class ExEnum
    {
        public static List<KeyValuePair<string, Enum>> GetCombo<T>()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'element' in 'Attribute? Attribute.GetCustomAttribute(MemberInfo element, Type attributeType)'.
            var ret = Enum.GetValues(typeof(T)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value

            }).OrderBy(item => item.value).ToList();
#pragma warning restore CS8604 // Possible null reference argument for parameter 'element' in 'Attribute? Attribute.GetCustomAttribute(MemberInfo element, Type attributeType)'.
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            var retDic = new Dictionary<string, Enum>();

            ret.ForEach(n => retDic.Add(n.Description, n.value));

            return retDic.ToList();
        }

        public static string Descricao_Enum(this Enum value)
        {
            // variables  
            var enumType = value.GetType();
            var field = enumType.GetField(value.ToString());
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            // return  
            return attributes.Length == 0 ? value.ToString() : ((DescriptionAttribute)attributes[0]).Description;
        }
    }
}
