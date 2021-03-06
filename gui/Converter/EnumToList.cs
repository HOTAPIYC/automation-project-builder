﻿using AutomationProjectBuilder.Gui;
using System;
using System.Linq;
using System.Windows.Data;

namespace AutomationProjectBuilder.Gui.Converter
{
	public class EnumConverterToList : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return Enum.GetValues(value.GetType()).Cast<Enum>().Select(e => new EnumValueDescription() { Value = e, Description = EnumHelper.Description(e) });
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}

	
}
