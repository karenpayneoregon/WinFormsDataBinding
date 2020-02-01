using System.Data;

namespace BindingSourceAddingNew.Classes
{
    public class MockedDataOperations
    {
        /// <summary>
        /// Simulate loading data from a database table
        /// </summary>
        /// <returns></returns>
        public static DataTable LoaDataTable()
        {
            using (var mockedData = new DataTable())
            {
                mockedData.Columns.AddRange(new[]
                    {
                        new DataColumn
                        {
                            ColumnName = "Identifier",
                            DataType = typeof(int),
                            AutoIncrement = true
                        },
                        new DataColumn("PartName", typeof(string)),
                        new DataColumn("Quantity", typeof(int)),
                        new DataColumn("Cost", typeof(decimal))
                    }
                );

                mockedData.Rows.Add(null, "Part A", 100, 45.99F);
                mockedData.Rows.Add(null, "Part B", 34, 20.99F);
                mockedData.Rows.Add(null, "Part C", 4, 2.45F);

                return mockedData;
            }
        }
    }
}
