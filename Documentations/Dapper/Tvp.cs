using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace Whatever
{
    public static class Tvp
    {
        public static SqlMapper.ICustomQueryParameter GetBigintList(IEnumerable<long> values)
        {
            var tvp = new DataTable();

            tvp.Columns.Add(new DataColumn
            {
                DataType = Type.GetType("System.Int64"),
                ColumnName = "TV_COLUMN_NAME_1"
            });

            //tvp.Columns.Add(new DataColumn
            //{
            //    DataType = Type.GetType("System.Int64"),
            //    ColumnName = "TV_COLUMN_NAME_2"
            //});
			
            if (items != null)
            {
                foreach (var value in values)
                {
                    var row = tvp.NewRow();
                    row["TV_COLUMN_NAME_1"] = value;
                    //row["TV_COLUMN_NAME_2"] = ...;
                    tvp.Rows.Add(row);
                }
            }

            return tvp.AsTableValuedParameter("SCHEMA_NAME.TVP_NAME");
        }
    }
}