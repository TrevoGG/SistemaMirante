namespace MiranteClasses.Classes
{
    public class Cafe
    {
        public class Unit
        {
            public int Data { get; set; } 
            public int Id { get; set; }
            public double TotalBruto { get; set; }
            public double Gastos { get; set; }
            public double TotalLivre { get; set; }


        }
        public class List
        {
            public List<Unit> ListUnity { get; set; }
        }
       
    }
}