using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Domain;
using Domain.Objects;

namespace DA
{
    public static class DA
    {
        public static bool Save<T>(this T obj)
            where T : Base
        {
            if (obj == null) return false;

            try
            {
                bool saveCall = (obj.Id == 0);
                if (obj.Id == 0 && !obj.PreSave()) return false;
                if (obj.Id > 0 && !obj.PreUpdate()) return false;

                using (Context context = new Context())
                {
                    if (obj.Id == 0)
                    {
                        obj.CreatedDate = DateTime.Now;
                        context.Set<T>().Add(obj);
                    }
                    else
                    {
                        context.Set<T>().Attach(obj);
                        context.Entry(obj).State = EntityState.Modified;
                    }
                    context.SaveChanges();
                }

                if(obj.PostSave != null && saveCall) Task.Factory.StartNew(obj.PostSave);
                else if (obj.PostUpdate != null) Task.Factory.StartNew(obj.PostUpdate);
                return true;
            }
            catch (Exception ex)
            {
                //TODO: Log the exception
                return false;
            }
        }

        public static T LoadById<T>(int id)
            where T : Base
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