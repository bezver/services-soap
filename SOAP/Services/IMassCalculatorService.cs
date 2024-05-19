using System.ServiceModel;

namespace SOAP.Services
{
	[ServiceContract]
	public interface IMassCalculatorService
	{
		[OperationContract]
		double CalculateGravityForce(double mass);
	}
}
