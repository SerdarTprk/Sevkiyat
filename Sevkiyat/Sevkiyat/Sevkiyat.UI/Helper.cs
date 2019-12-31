using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sevkiyat.UI.Enums;

namespace Sevkiyat.UI
{
    public  class EnumModel
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }
    public static class Helper
    {
        public static event EventHandler RecordReload;
        //public static event EventHandler RecordDeleted;
        public static void LoadHemCombo<T>(this ListControl control)
        {
            List<EnumModel> enums = ((T[])Enum.GetValues(typeof(T))).Select(c => new EnumModel() { Value = Convert.ToInt32(c), Name = c.ToString() }).ToList();

            control.DataSource = enums;
            control.DisplayMember = "Name";
            control.ValueMember = "Value";
         
        }
        public static void KontrolluKaydet(this DbContext db,EventHandler e)
        {
            try
            {
                int ess=db.SaveChanges();
                if (ess > 0)
                {
                    if (RecordReload!=null && RecordReload.Method!=null)
                    {
                        RecordReload(null, EventArgs.Empty);
                    }
                        //e(null, EventArgs.Empty);
                     
                        

                    
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
       
        public static void Load<T>(this ListControl control, DbContext db, string displayMember, string valueMember) where T : class
        {
            control.DataSource = null;
            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
            control.DataSource = db.Set<T>().ToList();
        }
    }

}
