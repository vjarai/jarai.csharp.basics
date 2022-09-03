using System;

namespace Jarai.CSharp.WcfService.HostApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalculationService.svc or CalculationService.svc.cs at the Solution Explorer and start debugging.
    public class CalculationService : ICalculationService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }

            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }

            return composite;
        }
    }
}
