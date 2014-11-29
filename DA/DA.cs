using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Domain;
using Domain.Objects;

namespace DA
{
    public static class DA
    {
        public static bool Save<T>(this T obj)
            where T : IBase
        {
            if (obj == null) return false;
            try
            {
                using (Context context = new Context())
                {
                    if (obj.Id == 0)
                    {
                        //obj.CreatedDate = DateTime.Now;
                        context.Set<T>().Add(obj);
                    }
                    else
                    {
                        context.Set<T>().Attach(obj);
                        context.Entry(obj).State = EntityState.Modified;
                    }
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                //TODO: Log the exception
                return false;
            }
        }

        public static T LoadById<T>(int id)
            where T : IBase
        {
            if (id <= 0)
            {
                return null;
            }

            using (Context context = new Context())
            {
                return context.Set<T>().FirstOrDefault(user => user.Id == id);    
            }
        }
    }
} 