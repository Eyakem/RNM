using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RNM.Common;
using RNM.Common.Authentication;
using RNM.Common.Constants;
using RNM.FaultLogging.Domain;
using RNM.FaultLogging.Enums;
using RNM.FaultService.Implementation;
using RNM.Common.Interfaces;
using RNM.FaultLogging.Repository;

namespace RNM.FaultLogging.Tests
{
    [TestClass]
    public class Given_I_Have_LoggedIn_As_A_Call_Center_Agent
    {
        private User _callCenterAgent;
        private FaultFactory faultFactory;
        private IFaultRepository faultLoggerRepository;

        [TestInitialize]
        public void Init()
        {
            _callCenterAgent = new User(UserType.CallCenterAgent);

            faultFactory = new FaultFactory();

            faultLoggerRepository = new FaultLoggingRepository();
        }
 
        [TestMethod]
        [TestCategory("Logging of new Faults")]
        public void When_I_Capture_A_Fault_Then_The_System_Should_Create_A_New_Fault()
        {
            //Arrange
            var geoCode = new GeocodeLocation(LocationType.GeoCode)
            {
                Latitude = -26.0606438M,
                Longtude = 27.9452808M
            };
            var fault = new Mock<Fault>();
            fault.Setup(x => x.Type).Returns(FaultType.TrafficLight);
            fault.Setup(x => x.FaultReference).Returns("1");
            fault.Setup(x => x.Geocode).Returns(geoCode);
            fault.Setup(x => x.Id).Returns(1);
            var faultRepositoryMock = new Mock<IFaultRepository>();
            var faultLogger = new FaultLogger(faultRepositoryMock.Object);

            // action
            faultLogger.Save(fault.Object);

            // assert
            faultRepositoryMock.Verify(x => x.Save(fault.Object), Times.Once());            
        }
    }
}
