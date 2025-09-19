using CSharpFundamentals.Core.Interfaces.SOLIDPrinciples;

namespace CSharpFundamentals.Core.SOLIDPrinciples.Principle_DIP
{
    // High-level module depends directly on a low-level module.
    class ReportGenerator
    {
        //private readonly SQLDatabase _db;

        ISQLDatabase _db;
        public ReportGenerator(ISQLDatabase db)
        {
            //  _db = new SQLDatabase(); // Direct dependency on a specific implementation.
            _db = db;

        }



        public string GenerateReport()
        {
            var data = _db.GetData();
            return data;

            //var data = _db.GetData();
            // ... generate report ...
        }
    }
}
