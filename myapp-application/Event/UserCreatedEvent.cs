using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp_application.Event;

    public record UserCreatedEvent(Guid UserId) : INotification{}
