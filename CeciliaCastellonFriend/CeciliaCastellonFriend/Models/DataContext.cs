
using System.Data.Entity;


namespace MVCCeciliaCastellonFriend.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCCeciliaCastellonFriend.Models.CeciliaCastellonFriend> CeciliaCastellonFriends{ get; set; }
    }
}