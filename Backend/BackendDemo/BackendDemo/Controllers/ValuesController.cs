using BackendDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BackendDemo.Controllers
{
    public class ValuesController : ApiController
    {
        // GET 查空給全部
        public IEnumerable<Bookmark> Get()
        {
            using (var db = new BookmarkContext())
            {
                IQueryable<Bookmark> datas = from b in db.Bookmarks
                                             select b;
                var bookmark = datas.ToList();
                return bookmark;
            }
        }

        // GET 查名字給臉書URL
        public string Get(string serno)
        {

            using (var db = new BookmarkContext())
            {
                IQueryable<Bookmark> datas = from b in db.Bookmarks
                                             select b;
                var bookmark = datas.Where(b => b.SerNo == serno).First();
                return bookmark.FBUrl;
            }
        }

        // POST 新增 and 修改
        public string Post(Bookmark bookmark)
        {
            using (var db = new BookmarkContext())
            {
                if ( string.IsNullOrEmpty(bookmark.SerNo))
                {
                    bookmark.SerNo = $"{db.Bookmarks.Count() + 1}";
                    db.Bookmarks.Add(bookmark);
                    db.SaveChanges();
                }
                else
                {
                    Bookmark bookmark2 = db.Bookmarks.FirstOrDefault(b => b.SerNo == bookmark.SerNo);
                    bookmark2 = bookmark;
                    db.SaveChanges();
                }
            }
            return "動作完成";
        }


        // DELETE 給serno刪掉資料
        public void Delete(string serno)
        {
            using (var db = new BookmarkContext())
            {
                Bookmark bookmark = db.Bookmarks.FirstOrDefault(b => b.SerNo == serno);
                db.Bookmarks.Remove(bookmark);
                db.SaveChanges();

            }
        }
    }
}
