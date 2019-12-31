using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sevkiyat.UI.Enums;

namespace Sevkiyat.UI
{

    public static class Helper
    {
        
        public static void EnumLoad<TEnum>(this ListControl control)
        {
            if(!typeof(TEnum).IsEnum)
            {
                throw new Exception("Bu metot sadece enum tipi için kullanılabilir.");
            }

            var enums = ((TEnum[])Enum.GetValues(typeof(TEnum))) // bu satırdaki kod enum üzerindeki tüm değerleri dizi olarak verir.
                .Select(e => new  { Value = Convert.ToInt32(e), Name = e.ToString() }) //burada ilgili dizi elemanlarını listeleme öğelerinde görünmesi için value ve text(display) formatına çekiyoruz.
                .ToList();

            control.DataSource = enums;
            control.DisplayMember = "Name";
            control.ValueMember = "Value";         
        }
        public static void KontrolluKaydet(this DbContext db,EventHandler e=null)
        {
            try
            {
                int ess=db.SaveChanges();
                if (ess > 0)
                {
                    if (e!=null && e.Method!=null)
                    {
                     e(null, EventArgs.Empty);
                    }

                    MessageBox.Show("Islem basarilidir.");

                }
                else
                {
                    MessageBox.Show("Islem gerektiren bir durum bulunamadi.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata nedeniyle işlem yapılamadi.");
            }
        }
       
        public static void Load<T>(this ListControl control, DbContext db, string displayMember, string valueMember, Expression<Func<T, bool>> filter=null, Expression<Func<T, bool>> filter2 = null) where T : class
        {
           
            control.DataSource = null;
            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;

            if (filter != null)
            {
                control.DataSource = db.Set<T>().Where(filter).Where(filter2).ToList();
            }
            else
            {
                control.DataSource = db.Set<T>().ToList();
            }
            
        }

    }

}
