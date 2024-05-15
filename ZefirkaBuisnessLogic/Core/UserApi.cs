using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zefirka.Domain.Entites.Responce;
using Zefirka.Domain.Entites.User;
using Zefirka.Domain.User;
using Zefirka.Domain;
using Zefirka.Domain.Enum;

namespace ZefirkaBuisnessLogic.Interfaces
{
    public class UserApi
    {
        public ULoginResp RLoginUpService(ULoginData data)
        {
            UDBTable user;
            using (var db = new UserContext())
            {
                user = db.Users.FirstOrDefault(us => us.Credential == data.Credential);
                if (user == null) return new ULoginResp { Status = false };
                else
                {
                    if (user.Password == data.Password)
                    {
                        if (user.Level == URole.Admin)
                            return new ULoginResp { Status = true, Message = "Admin" };

                        return new ULoginResp { Status = true };
                    }

                }
            }
            return new ULoginResp { Status = false };
        }
        public ULoginResp RRegisterNewUserAction(URegisterData data)
        {
            using (var db = new UserContext())
            {
                bool existingUser = db.Users.Any(u => u.Credential == data.Credential);

                if (existingUser)
                {
                    return new ULoginResp { Status = false, Message = "A user exist" };
                }
                var newUser = new UDBTable
                {
                    Credential = data.Credential,
                    Password = data.Password,
                    LasIp = "",
                    LastLogin = DateTime.Now,
                    Level = URole.User
                };
                if (data.Password != data.ConfirmPassword)
                    return new ULoginResp { Status = false, Message = "Wrong password" };
                db.Users.Add(newUser);
                db.SaveChanges();
                return new ULoginResp { Status = true, Message = "User registered successfully" };
            }
            //return new ULoginResp { Status = false, Message = "Error" };
        }

    }
}
