﻿using System;

namespace Manatee.Json.Schema.Generation
{
	[AttributeUsage(AttributeTargets.Property)]
	public class MinLengthAttribute : Attribute, ISchemaGenerationAttribute
	{
		private readonly uint _value;

		public MinLengthAttribute(uint value)
		{
			_value = value;
		}
		void ISchemaGenerationAttribute.Update(IJsonSchema schema)
		{
			switch (schema)
			{
				case JsonSchema04 schema04:
					schema04.MinLength = _value;
					break;
				case JsonSchema06 schema06:
					schema06.MinLength = _value;
					break;
				case JsonSchema07 schema07:
					schema07.MinLength = _value;
					break;
			}
		}
	}
}