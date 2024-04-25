using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Pr_1_Korovin_
{
    internal class MedicalInstitution
    {
        int time = 8;
        int peopleInHour = 4;
        int a;

        public void MedicalInstitution1(int a)
        {
            this.a = a;
        }

        public int MakeAnAppointment(int a)
        {
            int accept;
            if (a > 32)
            {
                accept = time * peopleInHour;
            }
            else
            {
                accept = a;
            }
            return accept;
        }
        public int DoNotMakeAnAppointment(int a)
        {
            int notAccept;
            if (a <= 32) notAccept = 0;
            else notAccept = (time * peopleInHour - a) * (-1);
            return notAccept;
        }
    }
}
