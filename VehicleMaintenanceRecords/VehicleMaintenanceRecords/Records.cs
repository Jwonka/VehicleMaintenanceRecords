using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceRecords
{
    internal class Records
    {
        public Owner Owner { get; set; }
        public Vehicle Vehicle { get; set; }
        public Maintenance Maintenance { get; set; }

        public Records(Owner owner, Vehicle vehicle, Maintenance maintenance)
        {
            Owner = owner;
            Vehicle = vehicle;
            Maintenance = maintenance;
        }
    }
}
