namespace jet.Bean
{
    public class PageInfo<T>
    {
        public int PageNum { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }

        public int PageCount { get; set; }

        public List<T>? Lists { get; set; }
    }
}
