using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Project
{
    using System;

    public class Notice
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string PostedBy { get; set; }
        public DateTime Date { get; set; }
    }

    // Notice Manager Class to handle all notice operations
    public static class NoticeManager
    {
        private static List<Notice> notices = new List<Notice>();
        private static int nextId = 1;

        public static void AddNotice(string title, string details, string postedBy, DateTime date)
        {
            var notice = new Notice
            {
                Id = nextId++,
                Title = title,
                Details = details,
                PostedBy = postedBy,
                Date = date
            };
            notices.Insert(0, notice); // Insert at beginning to show latest first
        }

        public static List<Notice> GetAllNotices()
        {
            return new List<Notice>(notices);
        }

        public static void ClearAllNotices()
        {
            notices.Clear();
        }
    }
}
