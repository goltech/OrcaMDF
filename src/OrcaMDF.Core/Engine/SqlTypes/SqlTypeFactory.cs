﻿using System;
using OrcaMDF.Core.Engine.Records;
using OrcaMDF.Core.MetaData;

namespace OrcaMDF.Core.Engine.SqlTypes
{
	public static class SqlTypeFactory
	{
		public static ISqlType Create(DataColumn column, RecordReadState readState, CompressionContext compression)
		{
			switch(column.Type)
			{
				case ColumnType.Binary:
					return new SqlBinary((short)column.VariableFixedLength);

				case ColumnType.BigInt:
					return new SqlBigInt();

				case ColumnType.Bit:
					return new SqlBit(readState);

				case ColumnType.Char:
					return new SqlChar((short)column.VariableFixedLength);

				case ColumnType.DateTime:
					return new SqlDateTime();

				case ColumnType.Decimal:
					return new SqlDecimal(column.Precision, column.Scale, compression.UsesVardecimals);
				
				case ColumnType.Image:
					return new SqlImage();

				case ColumnType.Int:
					return new SqlInt();

				case ColumnType.Money:
					return new SqlMoney();

				case ColumnType.NChar:
					return new SqlNChar((short)column.VariableFixedLength);

				case ColumnType.NText:
					return new SqlNText();

				case ColumnType.NVarchar:
					return new SqlNVarchar();

				case ColumnType.RID:
					return new SqlRID();

				case ColumnType.SmallInt:
					return new SqlSmallInt();

				case ColumnType.SmallMoney:
					return new SqlSmallMoney();

				case ColumnType.Text:
					return new SqlText();

				case ColumnType.TinyInt:
					return new SqlTinyInt();

				case ColumnType.UniqueIdentifier:
					return new SqlUniqueIdentifier();

				case ColumnType.Uniquifier:
					return new SqlUniquifier();

				case ColumnType.VarBinary:
					return new SqlVarBinary();

				case ColumnType.Varchar:
					return new SqlVarchar();
			}

			throw new ArgumentException("Unsupported type: " + column);
		}
	}
}
