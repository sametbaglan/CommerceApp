using CommerceApp.DbConnection;
using System.Linq;

namespace CommerceApp.Models
{
    public class Functions
    {
        static DataContext db = new DataContext();
        public static string parentidcategoryname(int? id)
        {
            return db.categories.FirstOrDefault(x => x.id == id).name;
        }
        public static bool SubCategoriaControll(int id)
        {
            var controll = db.categories.Where(x => x.parentId == id).ToList();
            if (controll.Count > 0)
                return true;
            else
                return false;
        }
        public static bool AttributeValueControll(int id)
        {
            var controll = db.attributeValues.Where(x => x.categoryAttirbuteid == id).ToList();
            if (controll.Count > 0)
                return true;
            else
                return false;
        }
        public static string attributename(int id)
        {
            return db.attributes.Where(x => x.id == id).FirstOrDefault().name;
        }
    }
}
