using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RNM.Common;
using RNM.Common.Constants;
using RNM.Common.Interfaces;
using RNM.FaultLogging.Domain;
using RNM.FaultLogging.Enums;
using RNM.FaultService.Implementation;

namespace RNM.FaultLogging.Tests
{
    [TestClass]
    public class Given_I_Have_LoggedIn_As_A_Fault_Investigator
    {

        [TestMethod]
        [TestCategory("Verifying of Faults")]
        public void When_I_Confirm_The_Existence_And_Address_And_FaultType_To_Verification_In_Progress()
        {
            //Arrange
            var geoCode = new GeocodeLocation(LocationType.GeoCode)
            {
                Latitude = -26.0606438M,
                Longtude = 27.9452808M
            };

            var address = new PhysicalLocation(LocationType.Physical)
            {
                StreetNumber = 29,
                StreetName = "Malibongwe Road",
                City = "Johannesburg"
            };

            var fault = new Mock<Fault>();
            fault.Setup(x => x.Type).Returns(FaultType.TrafficLight);
            fault.Setup(x => x.Status).Returns(FaultStatus.VerificationInProgress);
            fault.Setup(x => x.Priority).Returns(FaultPriority.Low);
            fault.Setup(x => x.Geocode).Returns(geoCode);
            fault.Setup(x => x.Address).Returns(address);
            fault.Setup(x => x.Id).Returns(1);
            var faultRepositoryMock = new Mock<IFaultRepository>();
            var faultVerifier = new FaultVerifier(faultRepositoryMock.Object);

            // action
            faultVerifier.Verify(fault.Object);

            // assert
            faultRepositoryMock.Verify(x => x.Update(fault.Object), Times.Once());
        }
    }
}
