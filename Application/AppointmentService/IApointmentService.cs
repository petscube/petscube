using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDevExercise.Abstractions
{
  public interface IAppointmentService
  {
    Task BookAppointment(Pet appointment);
    Task CancelAppointment(int appointmentId);
  }
}
