using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class AdvertisementCreator
    {
        private static IAdvertisement advertisement = null;

        public static IAdvertisement GetAdvert(string advertid, string title, string description, string price, string quantity, string selleremail)
        {
            if (advertisement != null)
            {
                return advertisement;
            }
            else
            {
                return new Advertisement(advertid, title, description, price, quantity, selleremail);
            }
        }
        public static void SetUser(IAdvertisement aAdvert)
        {
            advertisement = aAdvert;
        }

    }
}
