using LocalDbPractice.BL;
using LocalDbPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDbPractice.HelpingClasses
{
    public static class GeneralPurpose
    {
        public static DateTime DateTimeNow()
        {
            return DateTime.Now;
        }

        public static bool ValidateUser(DatabaseEntities entity, string email, int id = -1)
        {
            return new UserBL().ValidateUser(email, id, entity);
        }

    }
}
