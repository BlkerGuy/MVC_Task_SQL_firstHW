namespace MVC_Task_SQL_firstHW.Models
{
    public class Car
    {
        public int Id { get; set; }
        public  string Year { get; set; }
        public  string Color { get; set; }
        public int ModelId { get; set; }
        //public int BrandId { get; set; }//yeni

        public Model Model { get; set; }//yeni


    }
}
