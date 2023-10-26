﻿using Microsoft.UI.Xaml;
using Uno.Extensions.Markup;
using Uno.Extensions.Markup.Internals;

namespace Uno.Themes.Markup;

public static partial class Theme
{
	public static partial class MenuFlyoutItem
	{
		public static partial class Styles
		{
			[ResourceKeyDefinition(typeof(Style), "MenuFlyoutItemStyle", TargetType = typeof(MenuFlyoutItem))]
			public static StaticResourceKey<Style> Default => new("MenuFlyoutItemStyle");
		}
	}
}
