using FileReader;
using System.Linq;

namespace TransactionSurchargeApp
{
    public static class CalculateSurcharge
    {
        private const string JsonFilePath = @"C:\Users\jkehinde\source\repos\ParkWayAssessment\TransactionFeeCalculator\StaticFiles\Json\fees.config.json";

        public static decimal Calculate(decimal amountToBeTransferred)
        {
            var fees = ReadFile.ReadFromFile(JsonFilePath);
            decimal result = 0;
            var firstItem = fees.Fees.First();
            var lastItem = fees.Fees.LastOrDefault();

            if (amountToBeTransferred < firstItem.MinAmount)
            {
                result = -1;
            }
            else if (amountToBeTransferred > lastItem.MaxAmount)
            {
                result = 0;
            }
            else
            {
                foreach (var fee in fees.Fees)
                {
                    if (amountToBeTransferred >= fee.MinAmount && amountToBeTransferred <= fee.MaxAmount)
                    {
                        result = amountToBeTransferred + fee.FeeAmount;
                        break;
                    }
                }
            }


            return result;
        }
    }
}
