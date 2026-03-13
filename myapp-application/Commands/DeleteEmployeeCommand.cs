using MediatR;
using myapp_domain.Interfaces;

namespace myapp_application.Commands
{
    public record DeleteEmployeeCommand(Guid EmployeeId) : IRequest<bool>;
    internal class DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.DeleteEmployeeAsync(request.EmployeeId);
        }
    }
}
