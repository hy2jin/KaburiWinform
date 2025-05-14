using System.ComponentModel;

namespace KaburiKiosk.Converters
{
  public class PropertyFilterConverter : TypeConverter
  {
    // 포함할 속성 이름 리스트
    public List<string> IncludedProperties { get; set; } = new List<string>();

    // 제외할 속성 이름 리스트
    public List<string> ExcludedProperties { get; set; } = new List<string>();

    public override bool GetPropertiesSupported(ITypeDescriptorContext? context)
    {
      return true; // 속성 지원
    }

    public override PropertyDescriptorCollection? GetProperties(ITypeDescriptorContext? context, object? value, Attribute[]? attributes)
    {
      PropertyDescriptorCollection allProperties = TypeDescriptor.GetProperties(context!.Instance!);

      // Include와 Exclude 조건에 따라 필터링
      return FilterProperties(allProperties, IncludedProperties, ExcludedProperties);
    }

    // Include와 Exclude를 반영한 필터링 로직
    public static PropertyDescriptorCollection FilterProperties(
        PropertyDescriptorCollection properties,
        List<string> includeProperties,
        List<string> excludeProperties)
    {
      List<PropertyDescriptor> filteredProperties = new List<PropertyDescriptor>();

      foreach (PropertyDescriptor property in properties)
      {
        bool includeCondition = includeProperties.Count == 0 || includeProperties.Contains(property.Name);
        bool excludeCondition = !excludeProperties.Contains(property.Name);

        if (includeCondition && excludeCondition)
        {
          filteredProperties.Add(property);
        }
      }

      return new PropertyDescriptorCollection(filteredProperties.ToArray());
    }

    // 정적 메서드: Include 설정
    public static PropertyFilterConverter IncludedPropertyNames(object instance, List<string> includedPropertyNames)
    {
      var converter = (PropertyFilterConverter)TypeDescriptor.GetConverter(instance);
      converter.IncludedProperties = includedPropertyNames;
      return converter;
    }

    // 정적 메서드: Exclude 설정
    public static PropertyFilterConverter ExcludedPropertyNames(object instance, List<string> excludedPropertyNames)
    {
      var converter = (PropertyFilterConverter)TypeDescriptor.GetConverter(instance);
      converter.ExcludedProperties = excludedPropertyNames;
      return converter;
    }
  }
}
