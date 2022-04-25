namespace HotelListing.Models
{
    public class QueryParameters
    {
        private int _pageSize = 10;
        private int _pageIndex = 1;
        public int PageIndex
        {
            get
            {
                return _pageIndex;
            }
            set
            {
                _pageIndex = value;
            }
        }
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }
    }
}
