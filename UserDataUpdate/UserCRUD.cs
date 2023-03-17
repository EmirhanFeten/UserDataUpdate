using LoginRegisterPage;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace UserDataUpdate
{
    public class UserCRUD
    {

        Db db = new Db();
        public bool addUser(User gUser)
        {
            int ksay;
            bool answr = true;
            db.open();
            SqlCommand command = new SqlCommand("insert into registertbl values(@a,@b,@c,@d,@e)", db.connection);
            command.Parameters.AddWithValue("@a", gUser.FName);
            command.Parameters.AddWithValue("@b", gUser.LName);
            command.Parameters.AddWithValue("@c", gUser.UsName);
            command.Parameters.AddWithValue("@d", gUser.Mail);
            command.Parameters.AddWithValue("@e", gUser.Psw);
            ksay = command.ExecuteNonQuery();
            if (ksay == 0)
            {
                answr = false;
            }
            db.close();
            return answr;
        }

        public bool list(string p1, string p2)
        {
            bool cevap = true;
            db.open();
            SqlCommand komut = new SqlCommand("select count(usName) from registertbl where usName=@a and psw=@b", db.connection);
            komut.Parameters.AddWithValue("@a", p1);
            komut.Parameters.AddWithValue("@b", p2);
            int kaysay = Convert.ToInt16(komut.ExecuteScalar());
            if (kaysay == 0)
            {
                cevap = false;
            }
            db.close();
            return cevap;
        }
        public bool listRegister(string p1, string p2)
        {
            bool cevap = true;
            db.open();
            SqlCommand komut = new SqlCommand("select count(usName) from registertbl where usName=@a or mail=@b", db.connection);
            komut.Parameters.AddWithValue("@a", p1);
            komut.Parameters.AddWithValue("@b", p2);
            int kaysay = Convert.ToInt16(komut.ExecuteScalar());
            if (kaysay == 0)
            {
                cevap = false;
            }
            db.close();
            return cevap;
        }
        public DataTable listForUpdate()
        {
            DataTable dt = new DataTable();
            db.open();

            SqlCommand command = new SqlCommand("select * from registertbl", db.connection); // * all data
            SqlDataAdapter adp = new SqlDataAdapter(command);
            adp.Fill(dt);
            db.close();
            return dt;
        }
        public bool update(int gsno, User gUser)
        {
            int answ;
            bool durum = true;
            db.open();
            SqlCommand command = new SqlCommand("update registertbl set fName=@a,lName=@b,usName=@c,mail=@d,psw=@e where sNo=@u", db.connection); ;
            command.Parameters.AddWithValue("@a", gUser.FName);
            command.Parameters.AddWithValue("@b", gUser.LName);
            command.Parameters.AddWithValue("@c", gUser.UsName);
            command.Parameters.AddWithValue("@d", gUser.Mail);
            command.Parameters.AddWithValue("@e", gUser.Psw);
            command.Parameters.AddWithValue("@u", gsno);
            answ = command.ExecuteNonQuery();
            if (answ == 0)
            {
                durum = false;
            }
            db.close();
            return durum;
        }
        public DataTable userSearch(int guserId)
        {
            DataTable dt = new DataTable();
            db.open();
            SqlCommand command = new SqlCommand("select * from registertbl where sNo=@a", db.connection); // * tüm alanlar demek
            command.Parameters.AddWithValue("@a", guserId);
            SqlDataAdapter adp = new SqlDataAdapter(command);
            adp.Fill(dt);
            db.close();
            return dt;
        }
    }
}