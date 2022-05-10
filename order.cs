using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB
{
    public class order
    {
        string userID;
        string nameID;
        string productID;
        string imgsp;
        int gia;

        public order(string userID, string nameID, string productID, string imgsp, int gia)
        {
            this.UserID = userID;
            NameID1 = nameID;
            ProductID1 = productID;
            this.ImgSp = imgsp;
            this.Gia = gia;
            
        }
        public string ProductID1
        {
            get { return productID; }
            set { productID = value; }
        }
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string NameID1
        {
            get { return nameID; }
            set { nameID = value; }
        }
        public string ImgSp
        {
            get { return imgsp; }
            set { imgsp = value; }
        }
        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }
    }
}