using ONG.Domain.Seedwork.Notify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ONG.Domain.Utils
{
    public class BaseAdapter<TDomain, TModel> : NotificationContext
    {
        public static TModel Map(TDomain model)
        {
            var domain = (TModel)Activator.CreateInstance(typeof(TModel));
            var properties = MapProperties<TModel, TDomain>();
            foreach (var propertyName in properties)
            {
                var valueDomain = model.GetType().GetProperty(propertyName).GetValue(model);
                domain.GetType().GetProperty(propertyName).SetValue(domain, valueDomain);
            }
            return domain;
        }

        public static TDomain Map(TModel model)
        {
            var domain = (TDomain)Activator.CreateInstance(typeof(TDomain));
            var properties = MapProperties<TDomain, TModel>();
            foreach (var propertyName in properties)
            {
                var valueDomain = model.GetType().GetProperty(propertyName).GetValue(model);
                domain.GetType().GetProperty(propertyName).SetValue(domain, valueDomain);
            }
            return domain;
        }

        public static List<string> MapProperties<TDomain, TModel>()
        {
            var domain = GetProperties<TDomain>();
            var model = GetProperties<TModel>();
            var properties = new List<string>();
            foreach (var property in model)
            {
                var domainProperty = domain.Find(p => p.Name == property.Name && p.CanWrite && p.PropertyType.BaseType != null && (p.PropertyType.IsPrimitive || p.PropertyType.IsEnum || p.PropertyType.IsSealed));
                if (domainProperty != null) properties.Add(property.Name);
            }
            return properties;
        }

        private static List<PropertyInfo> GetProperties<T>()
        {
            return typeof(T).GetProperties(BindingFlags.Public| BindingFlags.SetProperty| BindingFlags.Instance).ToList();
        }
    }
}
