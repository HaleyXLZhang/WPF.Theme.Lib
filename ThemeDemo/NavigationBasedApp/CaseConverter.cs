using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace NavigationTheme
{
    public class CaseConverter : IValueConverter
    {
        private CharacterCasing m_Case;

        public CharacterCasing Case
        {
            get
            {
                return this.m_Case;
            }
            set
            {
                this.m_Case = value;
            }
        }
        public CaseConverter()
        {
            this.Case = CharacterCasing.Upper;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = value as string;
            if (value != null)
            {
                switch (this.Case)
                {
                    case CharacterCasing.Lower:
                        return text.ToLower();
                    case CharacterCasing.Normal:
                        return text;
                    case CharacterCasing.Upper:
                        return text.ToUpper();
                    default:
                        return text;
                }
            }
            return string.Empty;
        }

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            return this.Convert(value, targetType, parameter, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
