using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class AdvertisementCreator
    {
        private static Advertisement advertisement = null;

        public static Advertisement GetAdvert(string advertid, string title, string description, string price, string quantity, string selleremail)
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
        public static void SetAdvert(Advertisement aAdvert)
        {
            advertisement = aAdvert;
        }

    }
}
