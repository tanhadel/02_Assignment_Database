using _02_Assignment_Database.ConTexts;
using _02_Assignment_Database.ServiceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Assignment_Database.Repository
{
    internal class DriverInfoRepository : Repo<DriverInfoRepository>
    {
        public DriverInfoRepository(DataContext context) : base(context)
        {
        }
    }
}
