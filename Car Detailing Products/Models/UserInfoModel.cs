using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Detailing_Products.Models
{
    public class UserInfoModel
    {
        public UserInformation GetUserInformation(String guId)
        {
            db_1526927_1526927_co5025Entities db = new db_1526927_1526927_co5025Entities();
            UserInformation info = (from x in db.UserInformations
                                    where
                                     x.GUID == guId
                                    select x).FirstOrDefault();
            return info;
        }
        public void InsertUserInformation(UserInformation Info)
        {
            db_1526927_1526927_co5025Entities db = new db_1526927_1526927_co5025Entities();
            db.UserInformations.Add(Info);
            db.SaveChanges();
        }
    }
}