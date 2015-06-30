using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using RNM.FaultResolution.Domain.Services;

namespace RNM.FaultResolution.Application.Services.Tests
{
    [TestClass]
    public class When_creating_new_issued_work_order
    {
        private IAuthenticateUserService userServiceMock;
        private ICompletedWorkOrderRepository completedWorkOrderRepositoryMock;

        [TestInitialize]
        public void Initialise()
        {
            userServiceMock = MockRepository.GenerateMock<IAuthenticateUserService>();
            completedWorkOrderRepositoryMock = MockRepository.GenerateMock<ICompletedWorkOrderRepository>();
        }

        [TestMethod]
        public void Given_i_have_logged_in_as_a_supervisor_then_a_new_issued_work_order_should_be_created()
        {
            userServiceMock.Stub(user => user.IsSupervisor("")).IgnoreArguments().Return(true);
            var completedWorkOrderApplicationService = new CompletedWorkOrderApplicationService(userServiceMock, completedWorkOrderRepositoryMock);
            completedWorkOrderApplicationService.CreateNewIssuedWorkOrder("");
            completedWorkOrderRepositoryMock.AssertWasCalled(r => r.Commit());
        }

        [TestMethod]
        [ExpectedException(typeof(UnAuthorizedException))]
        public void Given_i_have_logged_in_as_a_normal_user_then_a_new_issued_work_order_should_not_be_created()
        {
            userServiceMock.Stub(user => user.IsSupervisor("")).IgnoreArguments().Return(false);
            var completedWorkOrderApplicationService = new CompletedWorkOrderApplicationService(userServiceMock, completedWorkOrderRepositoryMock);
            completedWorkOrderApplicationService.CreateNewIssuedWorkOrder("");
        }
    }
}
