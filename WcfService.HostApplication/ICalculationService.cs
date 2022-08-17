using System.Runtime.Serialization;
using System.ServiceModel;

namespace Jarai.WcfService.HostApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculationService" in both code and config file together.
    [ServiceContract]
    public interface ICalculationService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        [DataMember] public bool BoolValue { get; set; } = true;

        [DataMember] public string StringValue { get; set; } = "Hello ";
    }
}
