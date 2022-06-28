using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Construtores.Util;


public static class UtilityExtension
{
    #region ToInt32
    public static int ToInt32(this string valor)
    {
        if (string.IsNullOrEmpty(valor))
            return 0;

        int resultado = 0;
        int.TryParse(valor, out resultado);
        return resultado;
    }

    public static int ToInt32(this object valor)
    {
        if (valor == null)
            return 0;

        int resultado = 0;
        try
        {
            resultado = (int)valor;
        }
        catch (Exception)
        {
            int.TryParse(valor.ToString(), out resultado);
        }


        return resultado;
    }


    public static byte ToByte(this object valor)
    {

        if (valor == null)
            return 0;

        byte resultado = 0;
        try
        {
            resultado = (byte)valor;
        }
        catch (Exception)
        {
            byte.TryParse(valor.ToString(), out resultado);
        }


        return resultado;
    }

    public static int ToInt32(this string valor, int padrao)
    {
        if (string.IsNullOrEmpty(valor))
            return padrao;

        int resultado = 0;
        int.TryParse(valor, out resultado);
        return resultado;
    }

    public static int ToInt32(this object valor, int padrao)
    {
        if (valor == null)
            return padrao;

        int resultado = 0;
        int.TryParse(valor.ToString(), out resultado);
        return resultado;
    }
    #endregion

    #region Recupera o "Description" de Enums
    public static string GetDescription(this Enum en)
    {
        Type type = en.GetType();

        MemberInfo[] memInfo = type.GetMember(en.ToString());

        if (memInfo != null && memInfo.Length > 0)
        {
            object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attrs != null && attrs.Length > 0)
            {
                return ((DescriptionAttribute)attrs[0]).Description;
            }
        }

        return en.ToString();
    }

    public static string GetExtraDescription(this Enum en)
    {
        Type type = en.GetType();
        MemberInfo[] memInfo = type.GetMember(en.ToString());

        if (memInfo != null && memInfo.Length > 0)
        {
            object[] attrs = memInfo[0].GetCustomAttributes(typeof(ExtraDescriptionAttribute), false);

            if (attrs != null && attrs.Length > 0)
            {
                var x = type.GetField(en.ToString()).GetCustomAttribute<ExtraDescriptionAttribute>();

                return x.Value;
            }
        }

        return "";
    }

    public static Guid GetEnumGuid(this Enum e)
    {
        Type type = e.GetType();

        MemberInfo[] memInfo = type.GetMember(e.ToString());

        if (memInfo != null && memInfo.Length > 0)
        {
            object[] attrs = memInfo[0].GetCustomAttributes(typeof(EnumGuidAttribute), false);
            if (attrs != null && attrs.Length > 0)
                return ((EnumGuidAttribute)attrs[0]).Identificador;
        }

        throw new ArgumentException("Enum " + e + " não definida!");
    }

    public static T GetValueFromEnumGuid<T>(Guid guid)
    {
        var type = typeof(T);
        if (!type.IsEnum) throw new InvalidOperationException();
        foreach (var field in type.GetFields())
        {
            if (Attribute.GetCustomAttribute(field, typeof(EnumGuidAttribute)) is EnumGuidAttribute attribute)
            {
                if (attribute.Identificador == guid)
                    return (T)field.GetValue(null);
            }
        }

        throw new ArgumentException("Not found.", "enum guid");
    }

    #endregion


    #region Enums

    public static T Add<T>(this Enum type, T value)
    {
        try
        {
            return (T)(object)(((int)(object)type | (int)(object)value));
        }
        catch (Exception ex)
        {
            throw new ArgumentException(string.Format("Não foi possível adicionar o valor '{0}'.", typeof(T).Name), ex);
        }
    }

    public static T Remove<T>(this Enum type, T value)
    {
        try
        {
            return (T)(object)(((int)(object)type & ~(int)(object)value));
        }
        catch (Exception ex)
        {
            throw new ArgumentException(
                string.Format("Náo foi possivel remover o valor '{0}'.", typeof(T).Name), ex);
        }
    }

    public static bool Has<T>(this Enum type, T value)
    {
        try
        {
            return (((int)(object)type & (int)(object)value) == (int)(object)value);
        }
        catch
        {
            return false;
        }
    }

    public static bool Is<T>(this Enum type, T value)
    {
        try
        {
            return (int)(object)type == (int)(object)value;
        }
        catch
        {
            return false;
        }
    }



    #endregion
}

