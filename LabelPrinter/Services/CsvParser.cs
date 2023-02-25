namespace LabelPrinter.Services
{
    using Models;
    public static class CsvParser
    {
        public static System.Collections.Generic.IEnumerable<ThermostatLabelData> ParseCsvString(string input)
        {
            var entities = input.Trim().Split("\r\n");

            foreach (var entity in entities)
            {
                var parsedEntity = entity.Split('\t');

                yield return new ThermostatLabelData
                    (parsedEntity[0], parsedEntity[1]);
            }
        }
    }
}
