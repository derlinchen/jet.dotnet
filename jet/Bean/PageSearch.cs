namespace jet.Bean
{
    public class PageSearch<T>
    {
        public int PageNum { get; set; }
        public int PageSize { get; set; }

        public T? Item { get; set; }
    }
}
