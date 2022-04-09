using System.ComponentModel;

namespace MySocialNetwork.Application.Utils
{
    public static class ExEnum
    {
        public static List<KeyValuePair<string, Enum>> GetCombo<T>()
        {
            var ret = Enum.GetValues(typeof(T)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value

            }).OrderBy(item => item.value).ToList();

            var retDic = new Dictionary<string, Enum>();

            ret.ForEach(n => retDic.Add(n.Description, n.value));

            return retDic.ToList();
        }

        public static string Descricao_Enum(this Enum value)
        {
            // variables  
            var enumType = value.GetType();
            var field = enumType.GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            // return  
            return attributes.Length == 0 ? value.ToString() : ((DescriptionAttribute)attributes[0]).Description;
        }
    }
}
