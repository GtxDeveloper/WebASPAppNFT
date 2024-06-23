using System.Globalization;

namespace WebASPAppNFT.Entities
{
    public class NFTItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImgSrc { get; set; }

        public double CurrentBidInETH { get; set; }

        public double CurrentBidInUSD { get; set; }

        public TimeSpan EndsIn { get; set; }

        public DateTime DateOfCreating { get; set; }

        public string Slug { get; set; }

        public Collection Collection { get; set; }
        public int? CollectionId { get; set; } = null;

        public string GetDateOfCreating()
        {
            return FormatDateWithSuffix(DateOfCreating);
        }

        public string GetEndsIn()
        {
            return FormatTimeSpan(EndsIn);
        }

        private static string FormatDateWithSuffix(DateTime date)
        {
            int day = date.Day;
            string daySuffix = GetDaySuffix(day);
            string monthName = date.ToString("MMMM", CultureInfo.InvariantCulture);
            string formattedDate = $"{monthName} {day}{daySuffix}, {date.Year}";
            return formattedDate;
        }

        private static string GetDaySuffix(int day)
        {
            if (day >= 11 && day <= 13)
            {
                return "th";
            }

            switch (day % 10)
            {
                case 1: return "st";
                case 2: return "nd";
                case 3: return "rd";
                default: return "th";
            }
        }

        private static string FormatTimeSpan(TimeSpan timeSpan)
        {
            return $"{timeSpan.Hours:D2}H {timeSpan.Minutes:D2}M {timeSpan.Seconds:D2}S";
        }
    }
}
