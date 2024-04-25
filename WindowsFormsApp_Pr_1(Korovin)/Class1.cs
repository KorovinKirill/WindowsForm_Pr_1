using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Pr_1_Korovin_
{
    internal class MedicalInstitution
    {
        uint time = 8;
        uint peopleInHour = 4;

        public void MedicalInstitution1(uint time, uint peopleInHour)
        {
            this.time = time;
            this.peopleInHour = peopleInHour;
        }

        public uint MakeAnAppointment(uint a)
        {
            uint accept = time * peopleInHour;
            return accept;
        }
    }
}
