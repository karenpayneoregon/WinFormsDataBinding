using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Example1Library.HelperClasses
{
    public class ListHelpers
    {
        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            var properties = TypeDescriptor.GetProperties(typeof(T));
            var dataTable = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                dataTable.Columns.Add(prop.Name, 
                    Nullable.GetUnderlyingType(prop.PropertyType) 
                    ?? prop.PropertyType);
            }

            foreach (var item in data)
            {
                var row = dataTable.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }

                dataTable.Rows.Add(row);
            }
            return dataTable;

        }
    }
}
